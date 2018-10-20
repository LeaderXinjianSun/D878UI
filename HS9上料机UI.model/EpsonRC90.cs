using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BingLibrary.hjb.net;
using BingLibrary.hjb.file;
using BingLibrary.hjb.tools;

namespace HS9上料机UI.model
{
    public class EpsonRC90
    {
        #region 变量
        #region EPSON
        public TcpIpClient TestSentNet = new TcpIpClient();
        public TcpIpClient TestReceiveNet = new TcpIpClient();
        public TcpIpClient TestSentFlexNet = new TcpIpClient();
        public TcpIpClient TestReceiveFlexNet = new TcpIpClient();
        public TcpIpClient MsgReceiveNet = new TcpIpClient();
        public TcpIpClient CtrlNet = new TcpIpClient();
        public TcpIpClient IOReceiveNet = new TcpIpClient();
        string ip = "192.168.1.2";
        public bool CtrlStatus = false, IOReceiveStatus = false;
        private bool isLogined = false;
        public bool[] Rc90In = new bool[100];
        public bool[] Rc90Out = new bool[100];
        #endregion
        private string iniParameterPath = System.Environment.CurrentDirectory + "\\Parameter.ini";

        #endregion
        #region 事件
        public delegate void PrintEventHandler(string ModelMessageStr);
        public event PrintEventHandler ModelPrint;
        public event PrintEventHandler EpsonStatusUpdate;
        #endregion
        #region 功能

        /// <summary>
        /// 构造函数
        /// </summary>
        public EpsonRC90()
        {
            ip = Inifile.INIGetStringValue(iniParameterPath, "Epson", "EpsonIp", "192.168.1.2");
            Async.RunFuncAsync(checkCtrlNet, null);
            Async.RunFuncAsync(checkIOReceiveNet, null);
            Async.RunFuncAsync(GetStatus, null);
            Async.RunFuncAsync(IORevAnalysis, null);
        }
        #region 网口监控
        public async void checkCtrlNet()
        {
            while (true)
            {
                
                if (!CtrlNet.tcpConnected)
                {
                    await Task.Delay(1000);
                    if (!CtrlNet.tcpConnected)
                    {
                        isLogined = false;
                        bool r1 = await CtrlNet.Connect(ip, 5000);
                        if (r1)
                        {
                            CtrlStatus = true;
                            ModelPrint("机械手CtrlNet连接");
                        }
                        else
                            CtrlStatus = false;
                    }
                }
                if (!isLogined && CtrlStatus)
                {
                    await CtrlNet.SendAsync("$login,123");
                    string s = await CtrlNet.ReceiveAsync();
                    if (s.Contains("#login,0"))
                        isLogined = true;
                    await Task.Delay(400);
                }
                else
                {
                    await Task.Delay(3000);
                }
            }
        }
        public async void checkIOReceiveNet()
        {
            while (true)
            {
                await Task.Delay(400);
                if (!IOReceiveNet.tcpConnected)
                {
                    await Task.Delay(1000);
                    if (!IOReceiveNet.tcpConnected)
                    {
                        bool r1 = await IOReceiveNet.Connect(ip, 2007);
                        if (r1)
                        {
                            IOReceiveStatus = true;
                            ModelPrint("机械手IOReceiveNet连接");

                        }
                        else
                            IOReceiveStatus = false;
                    }
                }
                else
                { await Task.Delay(15000); }
            }
        }
        #endregion
        #region EPSON通讯
        private async void GetStatus()
        {
            string status = "";
            while (true)
            {
                if (isLogined == true)
                {
                    try
                    {
                        status = await CtrlNet.SendAndReceive("$getstatus");
                        string[] statuss = status.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (statuss[0] == "#getstatus")
                        {
                            if (statuss[1].Length == 11)
                            {
                                EpsonStatusUpdate(statuss[1]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //Log.Default.Error("EpsonRC90.GetStatus", ex.Message);
                    }
                }
                await Task.Delay(1000);
            }
        }
        private async void IORevAnalysis()
        {
            while (true)
            {
                //await Task.Delay(100);
                if (IOReceiveStatus == true)
                {
                    string s = await IOReceiveNet.ReceiveAsync();

                    string[] ss = s.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        s = ss[0];

                    }
                    catch
                    {
                        s = "error";
                    }

                    if (s == "error")
                    {
                        IOReceiveNet.tcpConnected = false;
                        IOReceiveStatus = false;
                        ModelPrint("机械手IOReceiveNet断开");
                    }
                    else
                    {
                        string[] strs = s.Split(',');
                        if (strs[0] == "IOCMD" && strs[1].Length == 100)
                        {
                            for (int i = 0; i < 100; i++)
                            {
                                Rc90Out[i] = strs[1][i] == '1' ? true : false;
                            }
                            string RsedStr = "";
                            for (int i = 0; i < 100; i++)
                            {
                                RsedStr += Rc90In[i] ? "1" : "0";
                            }
                            await IOReceiveNet.SendAsync(RsedStr);
                        }
                        //ModelPrint("IORev: " + s);


                    }
                }
                else
                {
                    await Task.Delay(100);
                }
            }
        }
        #endregion
        #endregion
    }
}
