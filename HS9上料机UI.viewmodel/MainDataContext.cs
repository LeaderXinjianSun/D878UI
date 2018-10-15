using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using System.IO;
using BingLibrary.hjb.Metro;
using HS9上料机UI.model;
using BingLibrary.hjb.PLC;
using BingLibrary.hjb.tools;
using System.Collections.ObjectModel;
using BingLibrary.hjb.file;
using System.Windows.Threading;

namespace HS9上料机UI.viewmodel
{
    public partial class mainData
    {
        #region 属性
        #region Twincat
        public TwinCATCoil1 XPos { set; get; }
        public TwinCATCoil1 YPos { set; get; }
        public TwinCATCoil1 FPos { set; get; }
        public TwinCATCoil1 TPos { set; get; }
        public TwinCATCoil1 HPos { set; get; }
        public TwinCATCoil1 SPos { set; get; }
        #endregion
        #region 界面
        public string HomePageVisibility { set; get; } = "Visible";
        public string CameraPageVisibility { set; get; } = "Collapsed";
        public string ParameterPageVisibility { set; get; } = "Collapsed";
        public string LoginString { set; get; } = "登录";
        public bool Isloagin { set; get; } = false;
        public string MsgText { set; get; }
        public bool IsPLCConnect { set; get; }
        public bool IsTCPConnect { set; get; }
        public bool IsDBConnect { set; get; }
        #endregion
        #region EPSON
        public bool EpsonStatusAuto { set; get; } = false;
        public bool EpsonStatusWarning { set; get; } = false;
        public bool EpsonStatusSError { set; get; } = false;
        public bool EpsonStatusSafeGuard { set; get; } = false;
        public bool EpsonStatusEStop { set; get; } = false;
        public bool EpsonStatusError { set; get; } = false;
        public bool EpsonStatusPaused { set; get; } = false;
        public bool EpsonStatusRunning { set; get; } = false;
        public bool EpsonStatusReady { set; get; } = false;
        #endregion
        #region 参数
        public string SerialPortCom { set; get; }
        #endregion
        #endregion
        #region 变量
        TwinCATAds _TwinCATAds = new TwinCATAds();
        string MessageStr = "";
        private EpsonRC90 epsonRC90;
        ThingetPLC Xinjie;
        ObservableCollection<bool> XinJieOut;
        bool[] XinJieIn = new bool[64];
        private string iniParameterPath = System.Environment.CurrentDirectory + "\\Parameter.ini";
        public static DispatcherTimer dispatcherTimer = new DispatcherTimer();
        int loadintimes = 0;
        #endregion
        #region 功能
        #region 初始化
        #region 构造函数
        public mainData()
        {
            TwincatVarInit();
            Init();
            Async.RunFuncAsync(PLCWork, null);
        }
        #endregion
        #region Twincat实例化
        private void TwincatVarInit()
        {
            XPos = new TwinCATCoil1(new TwinCATCoil("MAIN.XPos", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            _TwinCATAds.StartNotice();
        }
        #endregion
        #region 硬件实例化
        private void Init()
        {
            ReadParameter();
            Xinjie = new ThingetPLC();           
            epsonRC90 = new EpsonRC90();
            epsonRC90.ModelPrint += ModelPrintEventProcess;
            epsonRC90.EpsonStatusUpdate += EpsonStatusUpdateProcess;
            dispatcherTimer.Tick += new EventHandler(DispatcherTimerTickUpdateUi);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 6);
            dispatcherTimer.Start();
        }
        #endregion
        #endregion
        #region 界面
        public async void ChoosePage(object p)
        {
            switch (p.ToString())
            {
                case "0":
                    HomePageVisibility = "Visible";
                    CameraPageVisibility = "Collapsed";
                    ParameterPageVisibility = "Collapsed";
                    LoginString = "登录";
                    Isloagin = false;
                    break;
                case "1":
                    HomePageVisibility = "Collapsed";
                    CameraPageVisibility = "Visible";
                    ParameterPageVisibility = "Collapsed";
                    LoginString = "登录";
                    Isloagin = false;
                    break;
                case "5":
                    if (LoginString != "登出")
                    {
                        string rr = await GlobalVar.metro.ShowLoginOnlyPassword("登录");
                        string ss = GetPassWord();
                        if (rr == ss)
                        {
                            LoginString = "登出";
                            Isloagin = true;
                        }
                    }
                    else
                    {
                        LoginString = "登录";
                        Isloagin = false;
                    }
                    break;
                case "6": 
                    HomePageVisibility = "Collapsed";
                    CameraPageVisibility = "Collapsed";
                    ParameterPageVisibility = "Visible";               
                    break;
                default:
                    break;
            }
        }
        public void FuncButton(object p)
        {
            switch (p.ToString())
            {
                case "0":
                    WriteParameter();
                    break;
                default:
                    break;
            }
        }
        string GetPassWord()
        {
            int day = System.DateTime.Now.Day;
            int month = System.DateTime.Now.Month;
            string ss = (day + month).ToString();
            string passwordstr = "";
            for (int i = 0; i < 4 - ss.Length; i++)
            {
                passwordstr += "0";
            }
            passwordstr += ss;
            return passwordstr;
        }
        private string AddMessage(string str)
        {
            string[] s = MessageStr.Split('\n');
            if (s.Length > 1000)
            {
                MessageStr = "";
            }
            if (MessageStr != "")
            {
                MessageStr += "\n";
            }
            MessageStr += System.DateTime.Now.ToString() + " " + str;
            return MessageStr;
        }
        #endregion
        #region 事件响应函数
        private void ModelPrintEventProcess(string str)
        {
            MsgText = AddMessage(str);
        }
        private void EpsonStatusUpdateProcess(string str)
        {
            EpsonStatusAuto = str[2] == '1';
            EpsonStatusWarning = str[3] == '1';
            EpsonStatusSError = str[4] == '1';
            EpsonStatusSafeGuard = str[5] == '1';
            EpsonStatusEStop = str[6] == '1';
            EpsonStatusError = str[7] == '1';
            EpsonStatusPaused = str[8] == '1';
            EpsonStatusRunning = str[9] == '1';
            EpsonStatusReady = str[10] == '1';
        }
        private void DispatcherTimerTickUpdateUi(Object sender, EventArgs e)
        {
            if (Isloagin || !(LoginString != "登出"))
            {
                if (++loadintimes > 5)
                {
                    Isloagin = false;
                    LoginString = "登录";
                    MsgText = AddMessage("自动登出");
                }
            }
            else
            {
                loadintimes = 0;
            }
        }
        #endregion
        #region 后台
        public void PLCWork()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(10);
                IsPLCConnect = Xinjie.ReadSM(0);
                if (IsPLCConnect)
                {
                    XinJieOut = Xinjie.ReadMultiMCoil(20000);
                    Xinjie.WritMultiMCoil(20200, XinJieIn);
                }
                else
                {
                    System.Threading.Thread.Sleep(1000);
                    Xinjie.ModbusDisConnect();
                    Xinjie.ModbusInit(SerialPortCom, 19200, System.IO.Ports.Parity.Even, 8, System.IO.Ports.StopBits.One);
                    Xinjie.ModbusConnect();
                }
            }
        }
        #endregion
        #region 应用函数
        private void ReadParameter()
        {
            try
            {
                SerialPortCom = Inifile.INIGetStringValue(iniParameterPath, "System", "PLCCOM", "COM7");
            }
            catch (Exception ex)
            {

                MsgText = AddMessage(ex.Message);
            }
        }
        private void WriteParameter()
        {
            try
            {
                Inifile.INIWriteValue(iniParameterPath, "System", "PLCCOM", SerialPortCom);
                MsgText = AddMessage("参数保存完成");
            }
            catch (Exception ex)
            {

                MsgText = AddMessage(ex.Message);
            }
        }
        #endregion
        #endregion
        public HObject curImage;
        public void OpenImage()
        {
            if (File.Exists(System.Environment.CurrentDirectory + "\\image_1.tiff"))
            {
                curImage?.Dispose();
                HOperatorSet.ReadImage(out curImage, System.Environment.CurrentDirectory + "\\image_1.tiff");
                GlobalVar.hWndCtrl.addIconicVar(new HImage(curImage));
                GlobalVar.hWndCtrl.repaint();
            }
        }
    }
}
