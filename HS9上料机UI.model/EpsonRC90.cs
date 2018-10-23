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
        public bool CtrlStatus = false, IOReceiveStatus = false,TestSendStatus = false, TestSendFlexStatus = true, TestReceiveStatus = true, TestReceiveFlexStatus = true, MsgReceiveStatus = true;
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
        public event PrintEventHandler EPSONCommTwincat;
        #endregion
        #region 功能

        /// <summary>
        /// 构造函数
        /// </summary>
        public EpsonRC90()
        {
            ip = Inifile.INIGetStringValue(iniParameterPath, "Epson", "EpsonIp", "192.168.1.2");
            Async.RunFuncAsync(checkCtrlNet, null);
            Async.RunFuncAsync(checkTestSentNet, null);
            Async.RunFuncAsync(checkTestReceiveNet, null);
            //Async.RunFuncAsync(checkTestSentFlexNet, null);
            //Async.RunFuncAsync(checkTestReceiveFlexNet, null);
            Async.RunFuncAsync(checkMsgReceiveNet, null);
            Async.RunFuncAsync(checkIOReceiveNet, null);

            Async.RunFuncAsync(GetStatus, null);
            Async.RunFuncAsync(IORevAnalysis, null);
            Async.RunFuncAsync(MsgRevAnalysis, null);
            Async.RunFuncAsync(TestRevAnalysis, null);
            
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
        public async void checkTestSentNet()
        {
            while (true)
            {
                await Task.Delay(400);
                if (!TestSentNet.tcpConnected)
                {
                    await Task.Delay(1000);
                    if (!TestSentNet.tcpConnected)
                    {
                        bool r1 = await TestSentNet.Connect(ip, 2000);
                        if (r1)
                        {
                            TestSendStatus = true;
                            ModelPrint("机械手TestSentNet连接");

                        }
                        else
                            TestSendStatus = false;
                    }
                }
                else
                { await Task.Delay(15000); }
            }
        }
        public async void checkTestSentFlexNet()
        {
            while (true)
            {
                await Task.Delay(400);
                if (!TestSentFlexNet.tcpConnected)
                {
                    await Task.Delay(1000);
                    if (!TestSentFlexNet.tcpConnected)
                    {
                        bool r1 = await TestSentFlexNet.Connect(ip, 2004);
                        if (r1)
                        {
                            TestSendFlexStatus = true;
                            ModelPrint("机械手TestSentFlexNet连接");

                        }
                        else
                            TestSendFlexStatus = false;
                    }
                }
                else
                { await Task.Delay(15000); }
            }
        }
        public async void checkTestReceiveNet()
        {
            while (true)
            {
                await Task.Delay(400);
                if (!TestReceiveNet.tcpConnected)
                {
                    await Task.Delay(1000);
                    if (!TestReceiveNet.tcpConnected)
                    {
                        bool r1 = await TestReceiveNet.Connect(ip, 2001);
                        if (r1)
                        {
                            TestReceiveStatus = true;
                            ModelPrint("机械手TestReceiveNet连接");

                        }
                        else
                            TestReceiveStatus = false;
                    }
                }
                else
                { await Task.Delay(15000); }
            }
        }
        public async void checkTestReceiveFlexNet()
        {
            while (true)
            {
                await Task.Delay(400);
                if (!TestReceiveFlexNet.tcpConnected)
                {
                    await Task.Delay(1000);
                    if (!TestReceiveFlexNet.tcpConnected)
                    {
                        bool r1 = await TestReceiveFlexNet.Connect(ip, 2005);
                        if (r1)
                        {
                            TestReceiveFlexStatus = true;
                            ModelPrint("机械手TestReceiveFlexNet连接");

                        }
                        else
                            TestReceiveFlexStatus = false;
                    }
                }
                else
                { await Task.Delay(15000); }
            }
        }
        public async void checkMsgReceiveNet()
        {
            while (true)
            {
                await Task.Delay(400);
                if (!MsgReceiveNet.tcpConnected)
                {
                    await Task.Delay(1000);
                    if (!MsgReceiveNet.tcpConnected)
                    {
                        bool r1 = await MsgReceiveNet.Connect(ip, 2003);
                        if (r1)
                        {
                            MsgReceiveStatus = true;
                            ModelPrint("机械手MsgReceiveNet连接");

                        }
                        else
                            MsgReceiveStatus = false;
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
        private async void MsgRevAnalysis()
        {
            while (true)
            {
                //await Task.Delay(100);
                if (MsgReceiveStatus == true)
                {
                    string s = await MsgReceiveNet.ReceiveAsync();

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
                        MsgReceiveNet.tcpConnected = false;
                        MsgReceiveStatus = false;
                        ModelPrint("机械手MsgReceiveNet断开");
                    }
                    else
                    {
                        ModelPrint("MsgRev: " + s);
                    }
                }
                else
                {
                    await Task.Delay(100);
                }
            }
        }
        private async void TestRevAnalysis()
        {
            while (true)
            {
                if (TestReceiveStatus == true)
                {
                    string s = await TestReceiveNet.ReceiveAsync();

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
                        TestReceiveNet.tcpConnected = false;
                        TestReceiveStatus = false;
                        ModelPrint("机械手TestReceiveNet断开");
                    }
                    else
                    {
                        ModelPrint("TestRev: " + s);
                        try
                        {
                            string[] strs = s.Split(',');
                            switch (strs[0])
                            {
                                case "FMOVE":
                                    EPSONCommTwincat(s);
                                    break;
                                case "TMOVE":
                                    EPSONCommTwincat(s);
                                    break;
                                case "ULOAD":
                                    EPSONCommTwincat(s);
                                    break;
                                case "ResetCMD":
                                    EPSONCommTwincat(s);
                                    break;
                                case "StatusOfUpload":
                                    AnswerStatusOfUpload();
                                    break;
                                case "StatusOfYield":
                                    AnswerStatusOfYield();
                                    break;
                                case "StatusOfDiaoLiao":
                                    AnsverStatusOfDiaoLiao();
                                    break;
                                default:
                                    ModelPrint("无效指令： " + s);
                                    break;
                            }
                        }
                        catch(Exception ex)
                        {
                            ModelPrint("TestRevAnalysis " + ex.Message);
                        }
                    }
                }
                else
                {
                    await Task.Delay(100);
                }
            }
        }
        #endregion
        #region 功能函数
        private async void AnswerStatusOfUpload()
        {
            string str = "StatusOfUpload";
            //for (int i = 0; i < 4; i++)
            //{
            //    if (uploadSoftwareStatus[i].status || !isCheckUpload)
            //    {
            //        str += ";1";
            //    }
            //    else
            //    {
            //        str += ";0";
            //    }
            //}
            for (int i = 0; i < 4; i++)
            {
                str += ";1";
            }
            if (TestSendStatus)
            {
                await TestSentNet.SendAsync(str);
            }
        }
        private async void AnswerStatusOfYield()
        {
            string str = "StatusOfYield";

            //for (int i = 0; i < 4; i++)
            //{
            //    if (testerwith4item[i / 2].Yield_Nomal[i % 2] >= PassLowLimitStop || !IsPassLowLimitStop || testerwith4item[i / 2].TestCount_Nomal[i % 2] < PassLowLimitStopNum + AdminAddNum[i])
            //    {
            //        str += ";1";
            //    }
            //    else
            //    {
            //        str += ";0";
            //    }
            //}
            for (int i = 0; i < 4; i++)
            {
                str += ";1";
            }
            if (TestSendStatus)
            {
                await TestSentNet.SendAsync(str);
            }
        }
        private async void AnsverStatusOfDiaoLiao()
        {
            if (TestSendStatus)
            {
                //if (DiaoLiaoStatus)
                //{
                //    await TestSentNet.SendAsync("StatusOfDiaoLiao;1");
                //}
                //else
                //{
                //    await TestSentNet.SendAsync("StatusOfDiaoLiao;2");
                //}
                await TestSentNet.SendAsync("StatusOfDiaoLiao;1");
            }

        }
        #endregion
        #endregion
    }
}
