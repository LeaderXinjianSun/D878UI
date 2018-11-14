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
        public bool CtrlStatus = false, IOReceiveStatus = false,TestSendStatus = false, TestSendFlexStatus = false, TestReceiveStatus = false, TestReceiveFlexStatus = false, MsgReceiveStatus = false;
        private bool isLogined = false;
        public bool[] Rc90In = new bool[100];
        public bool[] Rc90Out = new bool[100];
        public Tester[] YanmadeTester = new Tester[4];
        public int[] AdminAddNum = new int[4] { 0, 0, 0, 0 };
        public UploadSoftwareStatus[] uploadSoftwareStatus = new UploadSoftwareStatus[4];
        #endregion
        private string iniParameterPath = System.Environment.CurrentDirectory + "\\Parameter.ini";
        //private string iniFilepath = @"d:\test.ini";

        #endregion
        #region 事件
        public delegate void PrintEventHandler(string ModelMessageStr);
        public event PrintEventHandler ModelPrint;
        public event PrintEventHandler DiaoLiaoEvent;
        public event PrintEventHandler EpsonStatusUpdate;
        public event PrintEventHandler EPSONCommTwincat;
        public delegate void TestFinishedHandler(int index,string bar,string result,string cycle);
        public event TestFinishedHandler TestFinished;
        public delegate void SamMessageEventHandler(int rund,int level,int flex);
        public event SamMessageEventHandler SamMessage;
        #endregion
        #region 功能

        /// <summary>
        /// 构造函数
        /// </summary>
        public EpsonRC90()
        {
            for (int i = 0; i < 4; i++)
            {
                YanmadeTester[i] = new Tester(i + 1);
                uploadSoftwareStatus[i] = new UploadSoftwareStatus(i + 1);
                uploadSoftwareStatus[i].ModelPrint += uploadprint;
                uploadSoftwareStatus[i].RecordPrint += RecordPrintOperate;

            }
            ip = Inifile.INIGetStringValue(iniParameterPath, "Epson", "EpsonIp", "192.168.1.2");
            Async.RunFuncAsync(checkCtrlNet, null);
            Async.RunFuncAsync(checkTestSentNet, null);
            Async.RunFuncAsync(checkTestReceiveNet, null);
            //Async.RunFuncAsync(checkTestSentFlexNet, null);
            Async.RunFuncAsync(checkTestReceiveFlexNet, null);
            Async.RunFuncAsync(checkMsgReceiveNet, null);
            Async.RunFuncAsync(checkIOReceiveNet, null);

            Async.RunFuncAsync(GetStatus, null);
            Async.RunFuncAsync(IORevAnalysis, null);
            Async.RunFuncAsync(MsgRevAnalysis, null);
            Async.RunFuncAsync(TestRevAnalysis, null);
            Async.RunFuncAsync(TestRevFlexAnalysis, null);
            

        }
        private void uploadprint(string str)
        {
            ModelPrint(str);
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
                                case "DiaoLiao":
                                    DiaoLiaoEvent(strs[1]);
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
                                case "TestResultCount":
                                    TestResult tr = strs[1] == "OK" ? TestResult.Pass : TestResult.Ng;
                                    YanmadeTester[int.Parse(strs[2]) - 1].Update(tr);
                                    break;
                                case "SamLoop":
                                    SamMessage(int.Parse(strs[1]), int.Parse(strs[2]), int.Parse(strs[3]));
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
        private async void TestRevFlexAnalysis()
        {
            while (true)
            {
                //await Task.Delay(100);
                if (TestReceiveFlexStatus == true)
                {
                    string s = await TestReceiveFlexNet.ReceiveAsync();

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
                        TestReceiveFlexNet.tcpConnected = false;
                        TestReceiveFlexStatus = false;
                        ModelPrint("机械手TestReceiveFlexNet断开");
                    }
                    else
                    {
                        ModelPrint("TestRevFlex: " + s);
                        try
                        {
                            string[] strs = s.Split(',');
                            switch (strs[0])
                            {

                                case "Start":
                                    YanmadeTester[int.Parse(strs[1]) - 1].Start(TestFinishOperate);
                                    break;
                                case "Finish":
                                    YanmadeTester[int.Parse(strs[1]) - 1].TestResult = strs[2] == "1" ? TestResult.Pass : TestResult.Ng;
                                    YanmadeTester[int.Parse(strs[1]) - 1].TestStatus = TestStatus.Tested;
                                    break;
                                default:
                                    ModelPrint("无效指令： " + s);
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            ModelPrint(ex.Message);
                        }

                    }
                }
                else
                {
                    await Task.Delay(100);
                }
            }
        }
        private void TestFinishOperate(int index)
        {
            uploadSoftwareStatus[index - 1].testerCycle = YanmadeTester[index - 1].TestSpan.ToString();
            uploadSoftwareStatus[index - 1].result = YanmadeTester[index - 1].TestResult == TestResult.Pass ? "PASS" : "FAIL";
            if (YanmadeTester[index - 1].TestSpan > 11)
            {
                uploadSoftwareStatus[index - 1].StartCommand();
            }
            else
            {
                uploadSoftwareStatus[index - 1].StopCommand();
            }
            
        }
        private void RecordPrintOperate(int _index, string _bar, string _rst, string _cyc)
        {
            TestFinished(_index, _bar, _rst, _cyc);
        }
        #endregion
        #region 功能函数
        private async void AnswerStatusOfUpload()
        {
            string str = "StatusOfUpload";
            for (int i = 0; i < 4; i++)
            {
                if (uploadSoftwareStatus[i].status)
                {
                    str += ";1";
                }
                else
                {
                    str += ";0";
                }
            }
            if (TestSendStatus)
            {
                await TestSentNet.SendAsync(str);
            }
        }
        private async void AnswerStatusOfYield()
        {
            string str = "StatusOfYield";
            for (int i = 0; i < 4; i++)
            {
                if (YanmadeTester[i].Yield_Nomal >= 95 || YanmadeTester[i].TestCount_Nomal < 100 + AdminAddNum[i])
                {
                    str += ";1";
                }
                else
                {
                    str += ";0";
                }
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
