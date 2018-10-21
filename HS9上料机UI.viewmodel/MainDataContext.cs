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
using ViewROI;

namespace HS9上料机UI.viewmodel
{
    public partial class mainData
    {
        #region 属性
        #region Twincat
        public TwinCATCoil1 PhotoCMD { set; get; }
        public TwinCATCoil1 PhotoComplete { set; get; }
        public TwinCATCoil1 PhotoHave1 { set; get; }
        public TwinCATCoil1 PhotoHave2 { set; get; }
        public TwinCATCoil1 PhotoHave3 { set; get; }
        public TwinCATCoil1 PhotoHave4 { set; get; }
        public TwinCATCoil1 PhotoHave5 { set; get; }
        public TwinCATCoil1 PhotoHave6 { set; get; }
        public TwinCATCoil1 PhotoHave7 { set; get; }
        public TwinCATCoil1 PhotoHave8 { set; get; }
        public TwinCATCoil1 PhotoHave9 { set; get; }
        public TwinCATCoil1 PhotoHave10 { set; get; }
        public TwinCATCoil1 XErrorCode { set; get; }
        public TwinCATCoil1 YErrorCode { set; get; }
        public TwinCATCoil1 HErrorCode { set; get; }
        public TwinCATCoil1 SErrorCode { set; get; }
        public TwinCATCoil1 FErrorCode { set; get; }
        public TwinCATCoil1 TErrorCode { set; get; }
        public TwinCATCoil1 UErrorCode { set; get; }

        public TwinCATCoil1 SaveButton { set; get; }
        public TwinCATCoil1 SuckValue1 { set; get; }
        public TwinCATCoil1 SuckValue2 { set; get; }
        public TwinCATCoil1 SuckValue3 { set; get; }
        public TwinCATCoil1 SuckValue4 { set; get; }
        public TwinCATCoil1 SuckValue5 { set; get; }
        public TwinCATCoil1 SuckValue6 { set; get; }
        public TwinCATCoil1 SuckValue7 { set; get; }
        public TwinCATCoil1 SuckValue8 { set; get; }
        public TwinCATCoil1 SuckValue9 { set; get; }
        public TwinCATCoil1 SuckValue10 { set; get; }
        public TwinCATCoil1 RSuckValue1 { set; get; }
        public TwinCATCoil1 RSuckValue2 { set; get; }
        public TwinCATCoil1 RSuckValue3 { set; get; }
        public TwinCATCoil1 RSuckValue4 { set; get; }
        public TwinCATCoil1 RSuckValue5 { set; get; }
        public TwinCATCoil1 RSuckValue6 { set; get; }
        public TwinCATCoil1 RSuckValue7 { set; get; }
        public TwinCATCoil1 RSuckValue8 { set; get; }
        public TwinCATCoil1 RSuckValue9 { set; get; }
        public TwinCATCoil1 RSuckValue10 { set; get; }
        public TwinCATCoil1 Suck1 { set; get; }
        public TwinCATCoil1 Suck2 { set; get; }
        public TwinCATCoil1 Suck3 { set; get; }
        public TwinCATCoil1 Suck4 { set; get; }
        public TwinCATCoil1 Suck5 { set; get; }
        public TwinCATCoil1 Suck6 { set; get; }
        public TwinCATCoil1 Suck7 { set; get; }
        public TwinCATCoil1 Suck8 { set; get; }
        public TwinCATCoil1 Suck9 { set; get; }
        public TwinCATCoil1 Suck10 { set; get; }
        public TwinCATCoil1 BFI1 { set; get; }
        public TwinCATCoil1 BFI2 { set; get; }
        public TwinCATCoil1 BFI3 { set; get; }
        public TwinCATCoil1 BFI4 { set; get; }
        public TwinCATCoil1 BFI5 { set; get; }
        public TwinCATCoil1 BFI6 { set; get; }
        public TwinCATCoil1 BFI7 { set; get; }
        public TwinCATCoil1 BFI8 { set; get; }
        public TwinCATCoil1 BFI9 { set; get; }
        public TwinCATCoil1 BFI10 { set; get; }
        public TwinCATCoil1 BFI11 { set; get; }
        public TwinCATCoil1 BFI12 { set; get; }
        public TwinCATCoil1 BFI13 { set; get; }
        public TwinCATCoil1 BFI14 { set; get; }
        public TwinCATCoil1 BFI15 { set; get; }
        public TwinCATCoil1 BFI16 { set; get; }

        public TwinCATCoil1 BFO1 { set; get; }
        public TwinCATCoil1 BFO2 { set; get; }
        public TwinCATCoil1 BFO3 { set; get; }
        public TwinCATCoil1 BFO4 { set; get; }
        public TwinCATCoil1 BFO5 { set; get; }
        public TwinCATCoil1 BFO6 { set; get; }
        public TwinCATCoil1 BFO7 { set; get; }
        public TwinCATCoil1 BFO8 { set; get; }
        public TwinCATCoil1 BFO9 { set; get; }
        public TwinCATCoil1 BFO10 { set; get; }
        public TwinCATCoil1 BFO11 { set; get; }
        public TwinCATCoil1 BFO12 { set; get; }
        public TwinCATCoil1 BFO13 { set; get; }
        public TwinCATCoil1 BFO14 { set; get; }
        public TwinCATCoil1 BFO15 { set; get; }
        public TwinCATCoil1 BFO16 { set; get; }

        public TwinCATCoil1 XPos { set; get; }
        public TwinCATCoil1 YPos { set; get; }
        public TwinCATCoil1 FPos { set; get; }
        public TwinCATCoil1 TPos { set; get; }
        public TwinCATCoil1 HPos { set; get; }
        public TwinCATCoil1 SPos { set; get; }
        public TwinCATCoil1 UPos { set; get; }

        public TwinCATCoil1 PickPositionX { set; get; }
        public TwinCATCoil1 PickPositionY { set; get; }
        public TwinCATCoil1 WaitPositionX { set; get; }
        public TwinCATCoil1 WaitPositionY { set; get; }

        public TwinCATCoil1 ReleasePositionX1 { set; get; }
        public TwinCATCoil1 ReleasePositionY1 { set; get; }
        public TwinCATCoil1 ReleasePositionX2 { set; get; }
        public TwinCATCoil1 ReleasePositionY2 { set; get; }
        public TwinCATCoil1 ReleasePositionX3 { set; get; }
        public TwinCATCoil1 ReleasePositionY3 { set; get; }

        public TwinCATCoil1 HSuckPosition { set; get; }
        public TwinCATCoil1 HReleasePosition { set; get; }
        public TwinCATCoil1 SUPPosition { set; get; }
        public TwinCATCoil1 SDownSuckPosition { set; get; }
        public TwinCATCoil1 SDownReleasePosition { set; get; }
        public TwinCATCoil1 SDownReleasePosition1 { set; get; }

        public TwinCATCoil1 PowerOn1 { set; get; }
        public TwinCATCoil1 PowerOn2 { set; get; }
        public TwinCATCoil1 PowerOn3 { set; get; }
        public TwinCATCoil1 PowerOn4 { set; get; }
        public TwinCATCoil1 PowerOn5 { set; get; }
        public TwinCATCoil1 PowerOn6 { set; get; }
        public TwinCATCoil1 PowerOn7 { set; get; }

        public TwinCATCoil1 ServoRst1 { set; get; }
        public TwinCATCoil1 ServoRst2 { set; get; }
        public TwinCATCoil1 ServoRst3 { set; get; }
        public TwinCATCoil1 ServoRst4 { set; get; }
        public TwinCATCoil1 ServoRst5 { set; get; }
        public TwinCATCoil1 ServoRst6 { set; get; }
        public TwinCATCoil1 ServoRst7 { set; get; }

        public TwinCATCoil1 ServoSVN1 { set; get; }
        public TwinCATCoil1 ServoSVN2 { set; get; }
        public TwinCATCoil1 ServoSVN3 { set; get; }
        public TwinCATCoil1 ServoSVN4 { set; get; }
        public TwinCATCoil1 ServoSVN5 { set; get; }
        public TwinCATCoil1 ServoSVN6 { set; get; }
        public TwinCATCoil1 ServoSVN7 { set; get; }

        public TwinCATCoil1 XRDY { set; get; }
        public TwinCATCoil1 YRDY { set; get; }
        public TwinCATCoil1 FRDY { set; get; }
        public TwinCATCoil1 TRDY { set; get; }
        public TwinCATCoil1 HRDY { set; get; }
        public TwinCATCoil1 SRDY { set; get; }

        public TwinCATCoil1 FPosition1 { set; get; }
        public TwinCATCoil1 FPosition2 { set; get; }
        public TwinCATCoil1 FPosition3 { set; get; }
        public TwinCATCoil1 FPosition4 { set; get; }
        public TwinCATCoil1 FPosition5 { set; get; }
        public TwinCATCoil1 FPosition6 { set; get; }
        public TwinCATCoil1 FPosition7 { set; get; }
        public TwinCATCoil1 FPosition8 { set; get; }

        public TwinCATCoil1 TPosition1 { set; get; }
        public TwinCATCoil1 TPosition2 { set; get; }
        public TwinCATCoil1 TPosition3 { set; get; }
        public TwinCATCoil1 TPosition4 { set; get; }
        public TwinCATCoil1 TPosition5 { set; get; }
        public TwinCATCoil1 TPosition6 { set; get; }
        public TwinCATCoil1 TPosition7 { set; get; }

        public TwinCATCoil1 XYRDYtoDebug { set; get; }
        public TwinCATCoil1 HSRDYtoDebug { set; get; }
        public TwinCATCoil1 FRDYtoDebug { set; get; }
        public TwinCATCoil1 TRDYtoDebug { set; get; }

        public TwinCATCoil1 XYInDebug { set; get; }
        public TwinCATCoil1 HSInDebug { set; get; }
        public TwinCATCoil1 FInDebug { set; get; }
        public TwinCATCoil1 TInDebug { set; get; }

        public TwinCATCoil1 XYDebugCMD { set; get; }
        public TwinCATCoil1 HSDebugCMD { set; get; }
        public TwinCATCoil1 FDebugCMD { set; get; }
        public TwinCATCoil1 TDebugCMD { set; get; }

        public TwinCATCoil1 XYDebugComplete { set; get; }
        public TwinCATCoil1 HSDebugComplete { set; get; }
        public TwinCATCoil1 FDebugComplete { set; get; }
        public TwinCATCoil1 TDebugComplete { set; get; }

        public TwinCATCoil1 EF104 { set; get; }
        public TwinCATCoil1 EF114 { set; get; }
        public TwinCATCoil1 HS104 { set; get; }
        public TwinCATCoil1 HS114 { set; get; }

        public TwinCATCoil1 EF100 { set; get; }
        public TwinCATCoil1 EF101 { set; get; }
        public TwinCATCoil1 EF102 { set; get; }
        public TwinCATCoil1 EF110 { set; get; }
        public TwinCATCoil1 EF111 { set; get; }
        public TwinCATCoil1 EF112 { set; get; }

        public TwinCATCoil1 EFU0 { set; get; }

        public TwinCATCoil1 HS100 { set; get; }
        public TwinCATCoil1 HS101 { set; get; }
        public TwinCATCoil1 HS102 { set; get; }
        public TwinCATCoil1 HS110 { set; get; }
        public TwinCATCoil1 HS111 { set; get; }
        public TwinCATCoil1 HS112 { set; get; }

        public TwinCATCoil1 F200 { set; get; }
        public TwinCATCoil1 F201 { set; get; }
        public TwinCATCoil1 F202 { set; get; }
        public TwinCATCoil1 F204 { set; get; }

        public TwinCATCoil1 T200 { set; get; }
        public TwinCATCoil1 T201 { set; get; }
        public TwinCATCoil1 T202 { set; get; }
        public TwinCATCoil1 T204 { set; get; }

        public TwinCATCoil1 DebugXTargetPositon { set; get; }
        public TwinCATCoil1 DebugYTargetPositon { set; get; }
        public TwinCATCoil1 DebugHTargetPositon { set; get; }
        public TwinCATCoil1 DebugSTargetPositon { set; get; }
        public TwinCATCoil1 DebugFTargetPositon { set; get; }
        public TwinCATCoil1 DebugTTargetPositon { set; get; }
        public TwinCATCoil1 DebugUTargetPositon { set; get; }

        public virtual TwinCATCoil1 Calc_Start { set; get; }

        public TwinCATCoil1 UPDirect { set; get; }
        public TwinCATCoil1 UNDirect { set; get; }
        #endregion
        #region 界面
        public string HomePageVisibility { set; get; } = "Visible";
        public string CameraPageVisibility { set; get; } = "Collapsed";
        public string ParameterPageVisibility { set; get; } = "Collapsed";
        public string TwinCATPageVisibility { set; get; } = "Collapsed";
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
        private string TwincatParameterPath = System.Environment.CurrentDirectory + "\\TwincatParameter.ini";
        public static DispatcherTimer dispatcherTimer = new DispatcherTimer();
        int loadintimes = 0;
        double DebugTargetX = 0;
        double DebugTargetH = 0;
        double DebugTargetS = 0;
        double DebugTargetY = 0;
        double DebugTargetF = 0;
        double DebugTargetT = 0;
        double DebugTargetU = 0;
        private HdevEngine hdevEngine = new HdevEngine();
        public HObject curImage;
        private bool[] FindFill = new bool[10];
        #endregion
        #region 功能
        #region 初始化
        #region 构造函数
        public mainData()
        {
            TwincatVarInit();
            Init();
            cameraHcInit();
            Async.RunFuncAsync(PLCWork, null);
            Async.RunFuncAsync(Run, null);
        }
        #endregion
        #region Twincat实例化
        private void TwincatVarInit()
        {
            XErrorCode = new TwinCATCoil1(new TwinCATCoil("MAIN.XErrorCode", typeof(uint), TwinCATCoil.Mode.Notice), _TwinCATAds);
            YErrorCode = new TwinCATCoil1(new TwinCATCoil("MAIN.YErrorCode", typeof(uint), TwinCATCoil.Mode.Notice), _TwinCATAds);
            FErrorCode = new TwinCATCoil1(new TwinCATCoil("MAIN.FErrorCode", typeof(uint), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TErrorCode = new TwinCATCoil1(new TwinCATCoil("MAIN.TErrorCode", typeof(uint), TwinCATCoil.Mode.Notice), _TwinCATAds);
            HErrorCode = new TwinCATCoil1(new TwinCATCoil("MAIN.HErrorCode", typeof(uint), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SErrorCode = new TwinCATCoil1(new TwinCATCoil("MAIN.SErrorCode", typeof(uint), TwinCATCoil.Mode.Notice), _TwinCATAds);
            UErrorCode = new TwinCATCoil1(new TwinCATCoil("MAIN.UErrorCode", typeof(uint), TwinCATCoil.Mode.Notice), _TwinCATAds);

            XPos = new TwinCATCoil1(new TwinCATCoil("MAIN.XPos", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            YPos = new TwinCATCoil1(new TwinCATCoil("MAIN.YPos", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            FPos = new TwinCATCoil1(new TwinCATCoil("MAIN.FPos", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TPos = new TwinCATCoil1(new TwinCATCoil("MAIN.TPos", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            HPos = new TwinCATCoil1(new TwinCATCoil("MAIN.HPos", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SPos = new TwinCATCoil1(new TwinCATCoil("MAIN.SPos", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            UPos = new TwinCATCoil1(new TwinCATCoil("MAIN.UPos", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);

            PickPositionX = new TwinCATCoil1(new TwinCATCoil("MAIN.PickPositionX", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PickPositionY = new TwinCATCoil1(new TwinCATCoil("MAIN.PickPositionY", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);

            WaitPositionX = new TwinCATCoil1(new TwinCATCoil("MAIN.WaitPositionX", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            WaitPositionY = new TwinCATCoil1(new TwinCATCoil("MAIN.WaitPositionY", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);

            ReleasePositionX1 = new TwinCATCoil1(new TwinCATCoil("MAIN.ReleasePositionX1", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ReleasePositionY1 = new TwinCATCoil1(new TwinCATCoil("MAIN.ReleasePositionY1", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ReleasePositionX2 = new TwinCATCoil1(new TwinCATCoil("MAIN.ReleasePositionX2", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ReleasePositionY2 = new TwinCATCoil1(new TwinCATCoil("MAIN.ReleasePositionY2", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ReleasePositionX3 = new TwinCATCoil1(new TwinCATCoil("MAIN.ReleasePositionX3", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ReleasePositionY3 = new TwinCATCoil1(new TwinCATCoil("MAIN.ReleasePositionY3", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);

            HSuckPosition = new TwinCATCoil1(new TwinCATCoil("MAIN.HSuckPosition", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            HReleasePosition = new TwinCATCoil1(new TwinCATCoil("MAIN.HReleasePosition", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SUPPosition = new TwinCATCoil1(new TwinCATCoil("MAIN.SUPPosition", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SDownSuckPosition = new TwinCATCoil1(new TwinCATCoil("MAIN.SDownSuckPosition", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SDownReleasePosition = new TwinCATCoil1(new TwinCATCoil("MAIN.SDownReleasePosition", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SDownReleasePosition1 = new TwinCATCoil1(new TwinCATCoil("MAIN.SDownReleasePosition1", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);

            PowerOn1 = new TwinCATCoil1(new TwinCATCoil("MAIN.PowerOn1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PowerOn2 = new TwinCATCoil1(new TwinCATCoil("MAIN.PowerOn2", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PowerOn3 = new TwinCATCoil1(new TwinCATCoil("MAIN.PowerOn3", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PowerOn4 = new TwinCATCoil1(new TwinCATCoil("MAIN.PowerOn4", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PowerOn5 = new TwinCATCoil1(new TwinCATCoil("MAIN.PowerOn5", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PowerOn6 = new TwinCATCoil1(new TwinCATCoil("MAIN.PowerOn6", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PowerOn7 = new TwinCATCoil1(new TwinCATCoil("MAIN.PowerOn7", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            ServoRst1 = new TwinCATCoil1(new TwinCATCoil("MAIN.E2", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ServoRst2 = new TwinCATCoil1(new TwinCATCoil("MAIN.F2", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ServoRst3 = new TwinCATCoil1(new TwinCATCoil("MAIN.G2", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ServoRst4 = new TwinCATCoil1(new TwinCATCoil("MAIN.H2", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ServoRst5 = new TwinCATCoil1(new TwinCATCoil("MAIN.K2", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ServoRst6 = new TwinCATCoil1(new TwinCATCoil("MAIN.J2", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ServoRst7 = new TwinCATCoil1(new TwinCATCoil("MAIN.U2", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            ServoSVN1 = new TwinCATCoil1(new TwinCATCoil("MAIN.E1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ServoSVN2 = new TwinCATCoil1(new TwinCATCoil("MAIN.F1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ServoSVN3 = new TwinCATCoil1(new TwinCATCoil("MAIN.G1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ServoSVN4 = new TwinCATCoil1(new TwinCATCoil("MAIN.H1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ServoSVN5 = new TwinCATCoil1(new TwinCATCoil("MAIN.K1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ServoSVN6 = new TwinCATCoil1(new TwinCATCoil("MAIN.J1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            ServoSVN7 = new TwinCATCoil1(new TwinCATCoil("MAIN.U1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            XRDY = new TwinCATCoil1(new TwinCATCoil("MAIN.XRDY", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            YRDY = new TwinCATCoil1(new TwinCATCoil("MAIN.YRDY", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            FRDY = new TwinCATCoil1(new TwinCATCoil("MAIN.FRDY", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TRDY = new TwinCATCoil1(new TwinCATCoil("MAIN.TRDY", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            HRDY = new TwinCATCoil1(new TwinCATCoil("MAIN.HRDY", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SRDY = new TwinCATCoil1(new TwinCATCoil("MAIN.SRDY", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            FPosition1 = new TwinCATCoil1(new TwinCATCoil("MAIN.FPosition1", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            FPosition2 = new TwinCATCoil1(new TwinCATCoil("MAIN.FPosition2", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            FPosition3 = new TwinCATCoil1(new TwinCATCoil("MAIN.FPosition3", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            FPosition4 = new TwinCATCoil1(new TwinCATCoil("MAIN.FPosition4", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            FPosition5 = new TwinCATCoil1(new TwinCATCoil("MAIN.FPosition5", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            FPosition6 = new TwinCATCoil1(new TwinCATCoil("MAIN.FPosition6", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            FPosition7 = new TwinCATCoil1(new TwinCATCoil("MAIN.FPosition7", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            FPosition8 = new TwinCATCoil1(new TwinCATCoil("MAIN.FPosition8", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);

            TPosition1 = new TwinCATCoil1(new TwinCATCoil("MAIN.TPosition1", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TPosition2 = new TwinCATCoil1(new TwinCATCoil("MAIN.TPosition2", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TPosition3 = new TwinCATCoil1(new TwinCATCoil("MAIN.TPosition3", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TPosition4 = new TwinCATCoil1(new TwinCATCoil("MAIN.TPosition4", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TPosition5 = new TwinCATCoil1(new TwinCATCoil("MAIN.TPosition5", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TPosition6 = new TwinCATCoil1(new TwinCATCoil("MAIN.TPosition6", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TPosition7 = new TwinCATCoil1(new TwinCATCoil("MAIN.TPosition7", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);

            UPDirect = new TwinCATCoil1(new TwinCATCoil("MAIN.UPDirect", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            UNDirect = new TwinCATCoil1(new TwinCATCoil("MAIN.UNDirect", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);

            XYInDebug = new TwinCATCoil1(new TwinCATCoil("MAIN.XYInDebug", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            HSInDebug = new TwinCATCoil1(new TwinCATCoil("MAIN.HSInDebug", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            FInDebug = new TwinCATCoil1(new TwinCATCoil("MAIN.FInDebug", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TInDebug = new TwinCATCoil1(new TwinCATCoil("MAIN.TInDebug", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            XYRDYtoDebug = new TwinCATCoil1(new TwinCATCoil("MAIN.XYRDYtoDebug", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            HSRDYtoDebug = new TwinCATCoil1(new TwinCATCoil("MAIN.HSRDYtoDebug", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            FRDYtoDebug = new TwinCATCoil1(new TwinCATCoil("MAIN.FRDYtoDebug", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TRDYtoDebug = new TwinCATCoil1(new TwinCATCoil("MAIN.TRDYtoDebug", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            XYDebugCMD = new TwinCATCoil1(new TwinCATCoil("MAIN.XYDebugCMD", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            HSDebugCMD = new TwinCATCoil1(new TwinCATCoil("MAIN.HSDebugCMD", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            FDebugCMD = new TwinCATCoil1(new TwinCATCoil("MAIN.FDebugCMD", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TDebugCMD = new TwinCATCoil1(new TwinCATCoil("MAIN.TDebugCMD", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            XYDebugComplete = new TwinCATCoil1(new TwinCATCoil("MAIN.XYDebugComplete", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            HSDebugComplete = new TwinCATCoil1(new TwinCATCoil("MAIN.HSDebugComplete", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            FDebugComplete = new TwinCATCoil1(new TwinCATCoil("MAIN.FDebugComplete", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TDebugComplete = new TwinCATCoil1(new TwinCATCoil("MAIN.TDebugComplete", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            HS100 = new TwinCATCoil1(new TwinCATCoil("MAIN.HS100", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            HS101 = new TwinCATCoil1(new TwinCATCoil("MAIN.HS101", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            HS102 = new TwinCATCoil1(new TwinCATCoil("MAIN.HS102", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            HS110 = new TwinCATCoil1(new TwinCATCoil("MAIN.HS110", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            HS111 = new TwinCATCoil1(new TwinCATCoil("MAIN.HS111", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            HS112 = new TwinCATCoil1(new TwinCATCoil("MAIN.HS112", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            F200 = new TwinCATCoil1(new TwinCATCoil("MAIN.F200", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            F201 = new TwinCATCoil1(new TwinCATCoil("MAIN.F201", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            F202 = new TwinCATCoil1(new TwinCATCoil("MAIN.F202", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            F204 = new TwinCATCoil1(new TwinCATCoil("MAIN.F204", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            T200 = new TwinCATCoil1(new TwinCATCoil("MAIN.T200", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            T201 = new TwinCATCoil1(new TwinCATCoil("MAIN.T201", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            T202 = new TwinCATCoil1(new TwinCATCoil("MAIN.T202", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            T204 = new TwinCATCoil1(new TwinCATCoil("MAIN.T204", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            DebugXTargetPositon = new TwinCATCoil1(new TwinCATCoil("MAIN.DebugXTargetPositon", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            DebugYTargetPositon = new TwinCATCoil1(new TwinCATCoil("MAIN.DebugYTargetPositon", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            DebugHTargetPositon = new TwinCATCoil1(new TwinCATCoil("MAIN.DebugHTargetPositon", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            DebugSTargetPositon = new TwinCATCoil1(new TwinCATCoil("MAIN.DebugSTargetPositon", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            DebugFTargetPositon = new TwinCATCoil1(new TwinCATCoil("MAIN.DebugFTargetPositon", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            DebugTTargetPositon = new TwinCATCoil1(new TwinCATCoil("MAIN.DebugTTargetPositon", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);
            DebugUTargetPositon = new TwinCATCoil1(new TwinCATCoil("MAIN.DebugUTargetPositon", typeof(double), TwinCATCoil.Mode.Notice), _TwinCATAds);

            EF104 = new TwinCATCoil1(new TwinCATCoil("MAIN.EF104", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            EF114 = new TwinCATCoil1(new TwinCATCoil("MAIN.EF114", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            HS104 = new TwinCATCoil1(new TwinCATCoil("MAIN.HS104", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            HS114 = new TwinCATCoil1(new TwinCATCoil("MAIN.HS114", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            EF100 = new TwinCATCoil1(new TwinCATCoil("MAIN.EF100", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            EF101 = new TwinCATCoil1(new TwinCATCoil("MAIN.EF101", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            EF102 = new TwinCATCoil1(new TwinCATCoil("MAIN.EF102", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            EF110 = new TwinCATCoil1(new TwinCATCoil("MAIN.EF110", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            EF111 = new TwinCATCoil1(new TwinCATCoil("MAIN.EF111", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            EF112 = new TwinCATCoil1(new TwinCATCoil("MAIN.EF112", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            EFU0 = new TwinCATCoil1(new TwinCATCoil("MAIN.EFU0", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            BFI1 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFI2 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI2", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFI3 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI3", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFI4 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI4", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFI5 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI5", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFI6 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI6", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFI7 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI7", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFI8 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI8", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFI9 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI9", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFI10 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI10", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFI11 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI11", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFI12 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI12", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFI13 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI13", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFI14 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI14", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFI15 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI15", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFI16 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFI16", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            BFO1 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFO2 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO2", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFO3 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO3", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFO4 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO4", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFO5 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO5", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFO6 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO6", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFO7 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO7", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFO8 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO8", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFO9 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO9", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFO10 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO10", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFO11 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO11", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFO12 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO12", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFO13 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO13", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFO14 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO14", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFO15 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO15", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            BFO16 = new TwinCATCoil1(new TwinCATCoil("MAIN.BFO16", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            Suck1 = new TwinCATCoil1(new TwinCATCoil("MAIN.Suck1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            Suck2 = new TwinCATCoil1(new TwinCATCoil("MAIN.Suck2", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            Suck3 = new TwinCATCoil1(new TwinCATCoil("MAIN.Suck3", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            Suck4 = new TwinCATCoil1(new TwinCATCoil("MAIN.Suck4", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            Suck5 = new TwinCATCoil1(new TwinCATCoil("MAIN.Suck5", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            Suck6 = new TwinCATCoil1(new TwinCATCoil("MAIN.Suck6", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            Suck7 = new TwinCATCoil1(new TwinCATCoil("MAIN.Suck7", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            Suck8 = new TwinCATCoil1(new TwinCATCoil("MAIN.Suck8", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            Suck9 = new TwinCATCoil1(new TwinCATCoil("MAIN.Suck9", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            Suck10 = new TwinCATCoil1(new TwinCATCoil("MAIN.Suck10", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            SuckValue1 = new TwinCATCoil1(new TwinCATCoil("MAIN.SuckValue1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SuckValue2 = new TwinCATCoil1(new TwinCATCoil("MAIN.SuckValue2", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SuckValue3 = new TwinCATCoil1(new TwinCATCoil("MAIN.SuckValue3", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SuckValue4 = new TwinCATCoil1(new TwinCATCoil("MAIN.SuckValue4", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SuckValue5 = new TwinCATCoil1(new TwinCATCoil("MAIN.SuckValue5", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SuckValue6 = new TwinCATCoil1(new TwinCATCoil("MAIN.SuckValue6", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SuckValue7 = new TwinCATCoil1(new TwinCATCoil("MAIN.SuckValue7", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SuckValue8 = new TwinCATCoil1(new TwinCATCoil("MAIN.SuckValue8", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SuckValue9 = new TwinCATCoil1(new TwinCATCoil("MAIN.SuckValue9", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            SuckValue10 = new TwinCATCoil1(new TwinCATCoil("MAIN.SuckValue10", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            RSuckValue1 = new TwinCATCoil1(new TwinCATCoil("MAIN.RSuckValue1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            RSuckValue2 = new TwinCATCoil1(new TwinCATCoil("MAIN.RSuckValue2", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            RSuckValue3 = new TwinCATCoil1(new TwinCATCoil("MAIN.RSuckValue3", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            RSuckValue4 = new TwinCATCoil1(new TwinCATCoil("MAIN.RSuckValue4", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            RSuckValue5 = new TwinCATCoil1(new TwinCATCoil("MAIN.RSuckValue5", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            RSuckValue6 = new TwinCATCoil1(new TwinCATCoil("MAIN.RSuckValue6", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            RSuckValue7 = new TwinCATCoil1(new TwinCATCoil("MAIN.RSuckValue7", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            RSuckValue8 = new TwinCATCoil1(new TwinCATCoil("MAIN.RSuckValue8", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            RSuckValue9 = new TwinCATCoil1(new TwinCATCoil("MAIN.RSuckValue9", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            RSuckValue10 = new TwinCATCoil1(new TwinCATCoil("MAIN.RSuckValue10", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            Calc_Start = new TwinCATCoil1(new TwinCATCoil("MAIN.Calc_Start", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            SaveButton = new TwinCATCoil1(new TwinCATCoil("MAIN.SaveButton", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            PhotoCMD = new TwinCATCoil1(new TwinCATCoil("MAIN.PhotoCMD", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            PhotoComplete = new TwinCATCoil1(new TwinCATCoil("MAIN.PhotoComplete", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            PhotoHave1 = new TwinCATCoil1(new TwinCATCoil("MAIN.PhotoHave1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PhotoHave2 = new TwinCATCoil1(new TwinCATCoil("MAIN.PhotoHave2", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PhotoHave3 = new TwinCATCoil1(new TwinCATCoil("MAIN.PhotoHave3", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PhotoHave4 = new TwinCATCoil1(new TwinCATCoil("MAIN.PhotoHave4", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PhotoHave5 = new TwinCATCoil1(new TwinCATCoil("MAIN.PhotoHave5", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PhotoHave6 = new TwinCATCoil1(new TwinCATCoil("MAIN.PhotoHave6", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PhotoHave7 = new TwinCATCoil1(new TwinCATCoil("MAIN.PhotoHave7", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PhotoHave8 = new TwinCATCoil1(new TwinCATCoil("MAIN.PhotoHave8", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PhotoHave9 = new TwinCATCoil1(new TwinCATCoil("MAIN.PhotoHave9", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PhotoHave10 = new TwinCATCoil1(new TwinCATCoil("MAIN.PhotoHave10", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
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
                    TwinCATPageVisibility = "Collapsed";
                    LoginString = "登录";
                    Isloagin = false;
                    break;
                case "1":
                    HomePageVisibility = "Collapsed";
                    CameraPageVisibility = "Visible";
                    ParameterPageVisibility = "Collapsed";
                    TwinCATPageVisibility = "Collapsed";
                    LoginString = "登录";
                    Isloagin = false;
                    break;
                case "2":
                    HomePageVisibility = "Collapsed";
                    CameraPageVisibility = "Collapsed";
                    ParameterPageVisibility = "Collapsed";
                    TwinCATPageVisibility = "Visible";
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
                    TwinCATPageVisibility = "Collapsed";
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
        public async void EpsonOpetate(object p)
        {
            switch (p.ToString())
            {
                case "1":
                    if (epsonRC90.CtrlStatus && EpsonStatusReady && !EpsonStatusEStop)
                    {
                        await epsonRC90.CtrlNet.SendAsync("$start,2");
                    }
                    if (epsonRC90.TestSendStatus)
                    {
                        await epsonRC90.TestSentNet.SendAsync("IndexArray_i;" + "0;1;2;3");
                    }
                    break;
                //暂停
                case "2":
                    if (epsonRC90.CtrlStatus)
                    {
                        await epsonRC90.CtrlNet.SendAsync("$pause");
                    }
                    break;
                case "3":
                    if (epsonRC90.CtrlStatus)
                    {
                        await epsonRC90.CtrlNet.SendAsync("$continue");            
                    }
                    break;
                case "4":
                    GlobalVar.metro.ChangeAccent("Red");
                    var r = await GlobalVar.metro.ShowConfirm("确认","确定进行停止机械手重启操作吗？");
                    if (r && epsonRC90.CtrlStatus)
                    {
                        await epsonRC90.CtrlNet.SendAsync("$stop");
                        await Task.Delay(300);
                        await epsonRC90.CtrlNet.SendAsync("$SetMotorOff,1");
                        await Task.Delay(400);
                        await epsonRC90.CtrlNet.SendAsync("$reset");
                    }
                    GlobalVar.metro.ChangeAccent("Blue");
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
        #region TwinCATOperate
        public void TwinCATButtonOperate(object p)
        {
            try
            {
                switch (p.ToString())
                {
                    case "0":
                        if ((bool)HSRDYtoDebug.Value)
                        {
                            HSDebugCMD.Value = true;
                        }
                        break;
                    case "1":
                        if ((bool)HSInDebug.Value)
                        {
                            HSDebugComplete.Value = true;
                        }
                        break;
                    case "2":
                        ServoSVN5.Value = !(bool)ServoSVN5.Value;
                        break;
                    case "3":
                        ServoRst5.Value = !(bool)ServoRst5.Value;
                        break;
                    case "4":
                        ServoSVN6.Value = !(bool)ServoSVN6.Value;
                        break;
                    case "5":
                        ServoRst6.Value = !(bool)ServoRst6.Value;
                        break;

                    case "6":
                        if ((bool)XYRDYtoDebug.Value)
                        {
                            XYDebugCMD.Value = true;
                        }
                        break;
                    case "7":
                        if ((bool)XYInDebug.Value)
                        {
                            XYDebugComplete.Value = true;
                        }
                        break;
                    case "8":
                        ServoSVN1.Value = !(bool)ServoSVN1.Value;
                        break;
                    case "9":
                        ServoRst1.Value = !(bool)ServoRst1.Value;
                        break;
                    case "10":
                        ServoSVN2.Value = !(bool)ServoSVN2.Value;
                        break;
                    case "11":
                        ServoRst2.Value = !(bool)ServoRst2.Value;
                        break;
                    case "20":
                        ServoSVN7.Value = !(bool)ServoSVN7.Value;
                        break;
                    case "21":
                        ServoRst7.Value = !(bool)ServoRst7.Value;
                        break;
                    case "12":
                        if ((bool)FRDYtoDebug.Value)
                        {
                            FDebugCMD.Value = true;
                        }
                        break;
                    case "13":
                        if ((bool)FInDebug.Value)
                        {
                            FDebugComplete.Value = true;
                        }
                        break;
                    case "14":
                        ServoSVN3.Value = !(bool)ServoSVN3.Value;
                        break;
                    case "15":
                        ServoRst3.Value = !(bool)ServoRst3.Value;
                        break;
                    case "16":
                        if ((bool)TRDYtoDebug.Value)
                        {
                            TDebugCMD.Value = true;
                        }
                        break;
                    case "17":
                        if ((bool)TInDebug.Value)
                        {
                            TDebugComplete.Value = true;
                        }
                        break;
                    case "18":
                        ServoSVN4.Value = !(bool)ServoSVN4.Value;
                        break;
                    case "19":
                        ServoRst4.Value = !(bool)ServoRst4.Value;
                        break;
                    default:
                        break;
                }
            }
            catch 
            {

               
            }
            

        }
        public void JogActionH_Plus()
        {
            try
            {
                if ((bool)HSInDebug.Value)
                {
                    HS110.Value = true;
                }
            }
            catch
            {


            }
        }
        public void JogActionH_Minus()
        {
            try
            {
                if ((bool)HSInDebug.Value)
                {
                    HS111.Value = true;
                }
            }
            catch
            {


            }
        }
        public void JogActionH_Stop()
        {
            try
            {
                if ((bool)HSInDebug.Value)
                {
                    HS110.Value = false;
                    HS111.Value = false;
                }
            }
            catch
            {


            }
        }
        public void JogActionS_Plus()
        {
            try
            {
                if ((bool)HSInDebug.Value)
                {
                    HS100.Value = true;
                }
            }
            catch
            {


            }
        }
        public void JogActionS_Minus()
        {
            try
            {
                if ((bool)HSInDebug.Value)
                {
                    HS101.Value = true;
                }
            }
            catch
            {


            }
        }
        public void JogActionS_Stop()
        {
            try
            {
                if ((bool)HSInDebug.Value)
                {
                    HS100.Value = false;
                    HS101.Value = false;
                }
            }
            catch
            {


            }
        }
        private void ServoPTPXY()
        {
            DebugXTargetPositon.Value = DebugTargetX;
            DebugYTargetPositon.Value = DebugTargetY;
            EF102.Value = true;
            EF112.Value = true;

        }
        private void ServoPTPU()
        {
            DebugUTargetPositon.Value = DebugTargetU;
            EFU0.Value = true;
        }
        private void ServoPTPH()
        {
            DebugHTargetPositon.Value = DebugTargetH;

            HS112.Value = true;


        }
        private void ServoPTPS()
        {
            DebugSTargetPositon.Value = DebugTargetS;

            HS102.Value = true;


        }
        public void JogActionF_Plus()
        {
            try
            {
                if ((bool)FInDebug.Value)
                {
                    F200.Value = true;
                }
            }
            catch
            {


            }
        }
        public void JogActionF_Minus()
        {
            try
            {
                if ((bool)FInDebug.Value)
                {
                    F201.Value = true;
                }
            }
            catch
            {


            }
        }
        public void JogActionF_Stop()
        {
            try
            {
                if ((bool)FInDebug.Value)
                {
                    F200.Value = false;
                    F201.Value = false;
                }
            }
            catch
            {


            }
        }
        private void ServoPTPF()
        {
            DebugFTargetPositon.Value = DebugTargetF;

            F202.Value = true;


        }

        public void JogActionT_Plus()
        {
            try
            {
                if ((bool)TInDebug.Value)
                {
                    T200.Value = true;
                }
            }
            catch
            {


            }
        }
        public void JogActionT_Minus()
        {
            try
            {
                if ((bool)TInDebug.Value)
                {
                    T201.Value = true;
                }
            }
            catch
            {


            }
        }
        public void JogActionT_Stop()
        {
            try
            {
                if ((bool)TInDebug.Value)
                {
                    T200.Value = false;
                    T201.Value = false;
                }
            }
            catch
            {


            }
        }
        private void ServoPTPT()
        {
            DebugTTargetPositon.Value = DebugTargetT;

            T202.Value = true;


        }
        public void JogActionX_Plus()
        {
            try
            {
                if ((bool)XYInDebug.Value)
                {
                    EF100.Value = true;
                }
            }
            catch
            {


            }
        }
        public void JogActionX_Minus()
        {
            try
            {
                if ((bool)XYInDebug.Value)
                {
                    EF101.Value = true;
                }
            }
            catch
            {


            }
        }
        public void JogActionX_Stop()
        {
            try
            {
                if ((bool)XYInDebug.Value)
                {
                    EF100.Value = false;
                    EF101.Value = false;
                }
            }
            catch
            {


            }
        }
        public void JogActionY_Plus()
        {
            try
            {
                if ((bool)XYInDebug.Value)
                {
                    EF110.Value = true;
                }
            }
            catch
            {


            }
        }
        public void JogActionY_Minus()
        {
            try
            {
                if ((bool)XYInDebug.Value)
                {
                    EF111.Value = true;
                }
            }
            catch
            {


            }
        }
        public void JogActionY_Stop()
        {
            try
            {
                if ((bool)XYInDebug.Value)
                {
                    EF110.Value = false;
                    EF111.Value = false;
                }
            }
            catch
            {


            }
        }
        public void MovetoPointAction(object p)
        {
            try
            {
                if ((bool)XYInDebug.Value)
                {
                    switch (p.ToString())
                    {
                        case "1":
                            DebugTargetX = (double)ReleasePositionX1.Value;
                            DebugTargetY = (double)ReleasePositionY1.Value;
                            ServoPTPXY();
                            break;
                        case "2":
                            DebugTargetX = (double)ReleasePositionX2.Value;
                            DebugTargetY = (double)ReleasePositionY2.Value;
                            ServoPTPXY();
                            break;
                        case "3":
                            DebugTargetX = (double)ReleasePositionX3.Value;
                            DebugTargetY = (double)ReleasePositionY3.Value;
                            ServoPTPXY();
                            break;
                        case "4":
                            DebugTargetX = (double)PickPositionX.Value;
                            DebugTargetY = (double)PickPositionY.Value;
                            ServoPTPXY();
                            break;
                        case "5":
                            DebugTargetX = (double)WaitPositionX.Value;
                            DebugTargetY = (double)WaitPositionY.Value;
                            ServoPTPXY();
                            break;
                        case "26":
                            DebugTargetU = (double)UPDirect.Value;
                            ServoPTPU();
                            break;
                        case "27":
                            DebugTargetU = (double)UNDirect.Value;
                            ServoPTPU();
                            break;
                        default:
                            break;
                    }
                }
                if ((bool)FInDebug.Value)
                {
                    switch (p.ToString())
                    {
                        case "6":
                            DebugTargetF = (double)FPosition1.Value;
                            ServoPTPF();
                            break;
                        case "7":
                            DebugTargetF = (double)FPosition2.Value;
                            ServoPTPF();
                            break;
                        case "8":
                            DebugTargetF = (double)FPosition3.Value;
                            ServoPTPF();
                            break;
                        case "9":
                            DebugTargetF = (double)FPosition4.Value;
                            ServoPTPF();
                            break;
                        case "10":
                            DebugTargetF = (double)FPosition5.Value;
                            ServoPTPF();
                            break;
                        case "11":
                            DebugTargetF = (double)FPosition6.Value;
                            ServoPTPF();
                            break;
                        case "12":
                            DebugTargetF = (double)FPosition7.Value;
                            ServoPTPF();
                            break;
                        case "24":
                            DebugTargetF = (double)FPosition8.Value;
                            ServoPTPF();
                            break;
                        default:
                            break;
                    }
                }

                if ((bool)HSInDebug.Value)
                {
                    switch (p.ToString())
                    {
                        case "18":
                            DebugTargetH = (double)HSuckPosition.Value;
                            ServoPTPH();
                            break;
                        case "19":
                            DebugTargetH = (double)HReleasePosition.Value;
                            ServoPTPH();
                            break;
                        case "20":
                            DebugTargetS = (double)SUPPosition.Value;
                            ServoPTPS();
                            break;
                        case "21":
                            DebugTargetS = (double)SDownSuckPosition.Value;
                            ServoPTPS();
                            break;
                        case "22":
                            DebugTargetS = (double)SDownReleasePosition.Value;
                            ServoPTPS();
                            break;
                        case "23":
                            DebugTargetS = (double)SDownReleasePosition1.Value;
                            ServoPTPS();
                            break;
                        default:
                            break;
                    }
                }
                if ((bool)TInDebug.Value)
                {
                    switch (p.ToString())
                    {
                        case "13":
                            DebugTargetT = (double)TPosition1.Value;
                            ServoPTPT();
                            break;
                        case "14":
                            DebugTargetT = (double)TPosition2.Value;
                            ServoPTPT();
                            break;
                        case "15":
                            DebugTargetT = (double)TPosition3.Value;
                            ServoPTPT();
                            break;
                        case "16":
                            DebugTargetT = (double)TPosition4.Value;
                            ServoPTPT();
                            break;
                        case "17":
                            DebugTargetT = (double)TPosition5.Value;
                            ServoPTPT();
                            break;

                        default:
                            break;
                    }
                }
            }
            catch
            {


            }
        }
        public void GetCoord(object p)
        {
            try
            {
                switch (p.ToString())
                {
                    case "1":
                        ReleasePositionX1.Value = (double)XPos.Value;
                        ReleasePositionY1.Value = (double)YPos.Value;
                        Calc_Start.Value = true;
                        break;
                    case "2":
                        ReleasePositionX2.Value = (double)XPos.Value;
                        ReleasePositionY2.Value = (double)YPos.Value;
                        Calc_Start.Value = true;
                        break;
                    case "3":
                        ReleasePositionX3.Value = (double)XPos.Value;
                        ReleasePositionY3.Value = (double)YPos.Value;
                        Calc_Start.Value = true;
                        break;
                    case "4":
                        PickPositionX.Value = (double)XPos.Value;
                        PickPositionY.Value = (double)YPos.Value;
                        Calc_Start.Value = true;
                        break;
                    case "5":
                        WaitPositionX.Value = (double)XPos.Value;
                        WaitPositionY.Value = (double)YPos.Value;
                        Calc_Start.Value = true;
                        break;
                    case "6":
                        FPosition1.Value = (double)FPos.Value;
                        break;
                    case "7":
                        FPosition2.Value = (double)FPos.Value;
                        break;
                    case "8":
                        FPosition3.Value = (double)FPos.Value;
                        break;
                    case "9":
                        FPosition4.Value = (double)FPos.Value;
                        break;
                    case "10":
                        FPosition5.Value = (double)FPos.Value;
                        break;
                    case "11":
                        FPosition6.Value = (double)FPos.Value;
                        break;
                    case "12":
                        FPosition7.Value = (double)FPos.Value;
                        break;
                    case "24":
                        FPosition8.Value = (double)FPos.Value;
                        break;
                    case "13":
                        TPosition1.Value = (double)TPos.Value;
                        break;
                    case "14":
                        TPosition2.Value = (double)TPos.Value;
                        break;
                    case "15":
                        TPosition3.Value = (double)TPos.Value;
                        break;
                    case "16":
                        TPosition4.Value = (double)TPos.Value;
                        break;
                    case "17":
                        TPosition5.Value = (double)TPos.Value;
                        break;

                    case "18":
                        HSuckPosition.Value = (double)HPos.Value;
                        break;
                    case "19":
                        HReleasePosition.Value = (double)HPos.Value;
                        break;
                    case "20":
                        SUPPosition.Value = (double)SPos.Value;
                        break;
                    case "21":
                        SDownSuckPosition.Value = (double)SPos.Value;
                        break;
                    case "22":
                        SDownReleasePosition.Value = (double)SPos.Value;
                        break;
                    case "23":
                        SDownReleasePosition1.Value = (double)SPos.Value;
                        break;
                    case "26":
                        UPDirect.Value = (double)UPos.Value;
                        break;
                    case "27":
                        UNDirect.Value = (double)UPos.Value;
                        break;
                    default:
                        break;
                }
            }
            catch
            {


            }
        }
        public void TwinCATIOOperate(object p)
        {
            switch (p.ToString())
            {
                case "1":
                    BFO1.Value = !(bool)BFO1.Value;
                    break;
                case "2":
                    BFO2.Value = !(bool)BFO2.Value;
                    break;
                case "3":
                    BFO3.Value = !(bool)BFO3.Value;
                    break;
                case "4":
                    BFO4.Value = !(bool)BFO4.Value;
                    break;
                case "5":
                    BFO5.Value = !(bool)BFO5.Value;
                    break;
                case "6":
                    BFO6.Value = !(bool)BFO6.Value;
                    break;
                case "7":
                    BFO7.Value = !(bool)BFO7.Value;
                    break;
                case "8":
                    BFO8.Value = !(bool)BFO8.Value;
                    break;
                case "9":
                    BFO9.Value = !(bool)BFO9.Value;
                    break;
                case "10":
                    BFO10.Value = !(bool)BFO10.Value;
                    break;
                case "11":
                    BFO11.Value = !(bool)BFO11.Value;
                    break;
                case "12":
                    BFO12.Value = !(bool)BFO12.Value;
                    break;
                case "13":
                    BFO13.Value = !(bool)BFO13.Value;
                    break;
                case "14":
                    BFO14.Value = !(bool)BFO14.Value;
                    break;
                case "15":
                    BFO15.Value = !(bool)BFO15.Value;
                    break;
                case "16":
                    BFO16.Value = !(bool)BFO16.Value;
                    break;
                default:
                    break;
            }
        }
        public void TwinCATEXIOSuck(object p)
        {
            switch (p.ToString())
            {
                case "1":
                    Suck1.Value = !(bool)Suck1.Value;
                    break;
                case "2":
                    Suck2.Value = !(bool)Suck2.Value;
                    break;
                case "3":
                    Suck3.Value = !(bool)Suck3.Value;
                    break;
                case "4":
                    Suck4.Value = !(bool)Suck4.Value;
                    break;
                case "5":
                    Suck5.Value = !(bool)Suck5.Value;
                    break;
                case "6":
                    Suck6.Value = !(bool)Suck6.Value;
                    break;
                case "7":
                    Suck7.Value = !(bool)Suck7.Value;
                    break;
                case "8":
                    Suck8.Value = !(bool)Suck8.Value;
                    break;
                case "9":
                    Suck9.Value = !(bool)Suck9.Value;
                    break;
                case "10":
                    Suck10.Value = !(bool)Suck10.Value;
                    break;
                default:
                    break;
            }
        }
        public void SaveTwincatDataAction()
        {
            try
            {
                Inifile.INIWriteValue(TwincatParameterPath, "XY", "ReleasePositionX1", ReleasePositionX1.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "XY", "ReleasePositionY1", ReleasePositionY1.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "XY", "ReleasePositionX2", ReleasePositionX2.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "XY", "ReleasePositionY2", ReleasePositionY2.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "XY", "ReleasePositionX3", ReleasePositionX3.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "XY", "ReleasePositionY3", ReleasePositionY3.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "XY", "PickPositionX", PickPositionX.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "XY", "PickPositionY", PickPositionY.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "XY", "WaitPositionX", WaitPositionX.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "XY", "WaitPositionY", WaitPositionY.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "F", "FPosition1", FPosition1.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "F", "FPosition2", FPosition2.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "F", "FPosition3", FPosition3.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "F", "FPosition4", FPosition4.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "F", "FPosition5", FPosition5.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "F", "FPosition6", FPosition6.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "F", "FPosition7", FPosition7.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "F", "FPosition8", FPosition8.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "T", "TPosition1", TPosition1.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "T", "TPosition2", TPosition2.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "T", "TPosition3", TPosition3.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "T", "TPosition4", TPosition4.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "T", "TPosition5", TPosition5.Value.ToString());

                Inifile.INIWriteValue(TwincatParameterPath, "H", "HSuckPosition", HSuckPosition.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "H", "HReleasePosition", HReleasePosition.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "S", "SUPPosition", SUPPosition.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "S", "SDownSuckPosition", SDownSuckPosition.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "S", "SDownReleasePosition", SDownReleasePosition.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "S", "SDownReleasePosition1", SDownReleasePosition1.Value.ToString());

                Inifile.INIWriteValue(TwincatParameterPath, "U", "UPDirect", UPDirect.Value.ToString());
                Inifile.INIWriteValue(TwincatParameterPath, "U", "UNDirect", UNDirect.Value.ToString());

                //TPosition1
                //FPosition1
                //PickPositionX
                //WaitPositionX
                SaveButton.Value = true;
                MsgText = AddMessage("保存轴控参数完成");
            }
            catch (Exception ex)
            {

                MsgText = AddMessage("保存轴控参数失败 " + ex.Message);
            }
        }
        public void ReadTwinCatDatafromIni()
        {
            try
            {
                ReleasePositionX1.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "XY", "ReleasePositionX1", "224.3008"));
                ReleasePositionY1.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "XY", "ReleasePositionY1", "320.7936"));
                ReleasePositionX2.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "XY", "ReleasePositionX2", "224.2896"));
                ReleasePositionY2.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "XY", "ReleasePositionY2", "0.2528"));
                ReleasePositionX3.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "XY", "ReleasePositionX3", "25.6064"));
                ReleasePositionY3.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "XY", "ReleasePositionY3", "319.9712"));
                PickPositionX.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "XY", "PickPositionX", "368.448"));
                PickPositionY.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "XY", "PickPositionY", "509.976"));
                WaitPositionX.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "XY", "WaitPositionX", "28.9152"));
                WaitPositionY.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "XY", "WaitPositionY", "509.4416"));
                FPosition1.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "F", "FPosition1", "466.234"));
                FPosition2.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "F", "FPosition2", "565.634"));
                FPosition3.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "F", "FPosition3", "293.882"));
                FPosition4.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "F", "FPosition4", "12.91"));
                FPosition5.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "F", "FPosition5", "12.91"));
                FPosition6.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "F", "FPosition6", "260.402"));
                FPosition7.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "F", "FPosition7", "170.004"));
                FPosition8.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "F", "FPosition8", "170.004"));
                TPosition1.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "T", "TPosition1", "-28.4904"));
                TPosition2.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "T", "TPosition2", "-303.9456"));
                TPosition3.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "T", "TPosition3", "-565.848"));
                TPosition4.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "T", "TPosition4", "-565.848"));
                TPosition5.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "T", "TPosition5", "-1136.144"));

                HSuckPosition.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "H", "HSuckPosition", "7.6"));
                HReleasePosition.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "H", "HReleasePosition", "316.07"));

                SUPPosition.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "S", "SUPPosition", "6.84"));
                SDownSuckPosition.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "S", "SDownSuckPosition", "106.12"));
                SDownReleasePosition.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "S", "SDownReleasePosition", "85.43"));
                SDownReleasePosition1.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "S", "SDownReleasePosition1", "85.43"));

                UPDirect.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "U", "UPDirect", "85.43"));
                UNDirect.Value = double.Parse(Inifile.INIGetStringValue(TwincatParameterPath, "U", "UNDirect", "85.43"));


                Calc_Start.Value = true;
                SaveButton.Value = true;
                MsgText = AddMessage("载入轴控参数完成");
            }
            catch (Exception ex)
            {

                MsgText = AddMessage("载入轴控参数失败 " + ex.Message);
            }
        }
        #endregion
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
        public void Run()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(10);
                try
                {
                    #region 映射
                    XinJieIn[0] = (bool)Suck1.Value;
                    XinJieIn[1] = (bool)Suck2.Value;
                    XinJieIn[2] = (bool)Suck3.Value;
                    XinJieIn[3] = (bool)Suck4.Value;
                    XinJieIn[4] = (bool)Suck5.Value;
                    XinJieIn[5] = (bool)Suck6.Value;
                    XinJieIn[6] = (bool)Suck7.Value;
                    XinJieIn[7] = (bool)Suck8.Value;
                    XinJieIn[8] = (bool)Suck9.Value;
                    XinJieIn[9] = (bool)Suck10.Value;

                    SuckValue1.Value = XinJieOut[0];
                    SuckValue2.Value = XinJieOut[1];
                    SuckValue3.Value = XinJieOut[2];
                    SuckValue4.Value = XinJieOut[3];
                    SuckValue5.Value = XinJieOut[4];
                    SuckValue6.Value = XinJieOut[5];
                    SuckValue7.Value = XinJieOut[6];
                    SuckValue8.Value = XinJieOut[7];
                    SuckValue9.Value = XinJieOut[12];
                    SuckValue10.Value = XinJieOut[13];

                    //测试机测试结果信号，从PLC X10210读出
                    epsonRC90.Rc90In[20] = XinJieOut[40];
                    epsonRC90.Rc90In[21] = XinJieOut[41];
                    epsonRC90.Rc90In[22] = XinJieOut[42];
                    epsonRC90.Rc90In[23] = XinJieOut[43];
                    epsonRC90.Rc90In[24] = XinJieOut[44];
                    epsonRC90.Rc90In[25] = XinJieOut[45];
                    epsonRC90.Rc90In[26] = XinJieOut[46];
                    epsonRC90.Rc90In[27] = XinJieOut[47];
                    //测试机测试结果信号，从倍服 BFI14读出
                    epsonRC90.Rc90In[28] = (bool)BFI14.Value;
                    epsonRC90.Rc90In[29] = (bool)BFI15.Value;
                    //测试机启动测试信号，向倍服 BFO06写入
                    BFO6.Value = epsonRC90.Rc90Out[30];
                    BFO7.Value = epsonRC90.Rc90Out[31];
                    BFO8.Value = epsonRC90.Rc90Out[32];
                    BFO9.Value = epsonRC90.Rc90Out[33];
                    //倍服告知机械手是否有料
                    epsonRC90.Rc90In[5] = (bool)RSuckValue1.Value;
                    epsonRC90.Rc90In[6] = (bool)RSuckValue2.Value;
                    epsonRC90.Rc90In[7] = (bool)RSuckValue3.Value;
                    epsonRC90.Rc90In[8] = (bool)RSuckValue4.Value;
                    epsonRC90.Rc90In[9] = (bool)RSuckValue5.Value;
                    epsonRC90.Rc90In[10] = (bool)RSuckValue6.Value;
                    epsonRC90.Rc90In[11] = (bool)RSuckValue7.Value;
                    epsonRC90.Rc90In[12] = (bool)RSuckValue8.Value;
                    epsonRC90.Rc90In[13] = (bool)RSuckValue9.Value;
                    epsonRC90.Rc90In[14] = (bool)RSuckValue10.Value;

                    IsTCPConnect = epsonRC90.TestSendStatus & epsonRC90.TestReceiveStatus & epsonRC90.MsgReceiveStatus & epsonRC90.IOReceiveStatus & epsonRC90.CtrlStatus & epsonRC90.TestSendFlexStatus & epsonRC90.TestReceiveFlexStatus;
                    #endregion
                    #region 任务
                    if ((bool)PhotoCMD.Value)
                    {
                        PhotoCMD.Value = false;
                        MsgText = AddMessage("开始拍照 自动");
                        Async.RunFuncAsync(cameraHcInspect, TakePhoteCallback);

                    }
                    #endregion
                }
                catch
                {

                   
                }

            }
        }
        private void TakePhoteCallback()
        {
            if (FindFill[0])
            {
                PhotoHave1.Value = true;
            }
            else
            {
                PhotoHave1.Value = false;
            }
            if (FindFill[1])
            {
                PhotoHave2.Value = true;
            }
            else
            {
                PhotoHave2.Value = false;
            }
            if (FindFill[2])
            {
                PhotoHave3.Value = true;
            }
            else
            {
                PhotoHave3.Value = false;
            }
            if (FindFill[3])
            {
                PhotoHave4.Value = true;
            }
            else
            {
                PhotoHave4.Value = false;
            }
            if (FindFill[4])
            {
                PhotoHave5.Value = true;
            }
            else
            {
                PhotoHave5.Value = false;
            }
            if (FindFill[5])
            {
                PhotoHave6.Value = true;
            }
            else
            {
                PhotoHave6.Value = false;
            }
            if (FindFill[6])
            {
                PhotoHave7.Value = true;
            }
            else
            {
                PhotoHave7.Value = false;
            }
            if (FindFill[7])
            {
                PhotoHave8.Value = true;
            }
            else
            {
                PhotoHave8.Value = false;
            }
            if (FindFill[8])
            {
                PhotoHave9.Value = true;
            }
            else
            {
                PhotoHave9.Value = false;
            }
            if (FindFill[9])
            {
                PhotoHave10.Value = true;
            }
            else
            {
                PhotoHave10.Value = false;
            }
            PhotoComplete.Value = true;
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
        #region 相机
        public void cameraHcInit()
        {
            hdevEngine.initialengine("检测相机脚本");
            hdevEngine.loadengine();
            try
            {
                if (!Directory.Exists(@"E:\images"))
                {
                    Directory.CreateDirectory(@"E:\images");
                }
                string[] imagefilenames = Directory.GetFiles(@"E:\images");
                if (imagefilenames.Length >= 200)
                {
                    for (int i = 0; i < imagefilenames.Length; i++)
                    {
                        File.Delete(imagefilenames[i]);
                    }
                    MsgText = AddMessage("清理照片");
                }
            }
            catch (Exception ex)
            {

                MsgText = AddMessage(ex.Message);
            }

        }
        public void CameraHcInspect()
        {
            MsgText = AddMessage("开始拍照 手动");
            Async.RunFuncAsync(cameraHcInspect, null);
        }
        public void cameraHcInspect()
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    FindFill[i] = false;
                }
                
                hdevEngine.inspectengine();
                GlobalVar.hWndCtrl.addIconicVar(hdevEngine.getImage("Image"));
                GlobalVar.hWndCtrl.repaint();
                string rst = "";
                for (int i = 0; i < 10; i++)
                {
                    FindFill[i] = hdevEngine.getmeasurements("fill" + (i + 1).ToString()).ToString() == "1";
                    if (FindFill[i])
                    {
                        rst += "1";
                    }
                    else
                    {
                        rst += "0";
                    }
                }
                GlobalVar.hWndCtrl.addIconicVar(hdevEngine.getRegion("Regions1"));
                GlobalVar.hWndCtrl.addIconicVar(hdevEngine.getRegion("Regions2"));
                GlobalVar.hWndCtrl.addIconicVar(hdevEngine.getRegion("Regions3"));
                GlobalVar.hWndCtrl.addIconicVar(hdevEngine.getRegion("Regions4"));
                GlobalVar.hWndCtrl.addIconicVar(hdevEngine.getRegion("Regions5"));
                GlobalVar.hWndCtrl.addIconicVar(hdevEngine.getRegion("Regions6"));
                GlobalVar.hWndCtrl.addIconicVar(hdevEngine.getRegion("Regions7"));
                GlobalVar.hWndCtrl.addIconicVar(hdevEngine.getRegion("Regions8"));
                GlobalVar.hWndCtrl.addIconicVar(hdevEngine.getRegion("Regions9"));
                GlobalVar.hWndCtrl.addIconicVar(hdevEngine.getRegion("Regions10"));
                GlobalVar.hWndCtrl.repaint();
                MsgText = AddMessage("拍照完成: " + rst);
            }
            catch(Exception ex)
            {
                MsgText = AddMessage(ex.Message);
            }

        }
        #endregion
        #endregion

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
