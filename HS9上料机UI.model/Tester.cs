using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using BingLibrary.hjb.tools;
using BingLibrary.hjb.file;

namespace HS9上料机UI.model
{
    public enum TestStatus
    {
        Testing, PreTest, Tested, Err
    }
    public enum TestResult
    {
        Unknow, Pass, Ng, TimeOut

    }
    public class Tester
    {
        public int PassCount { set; get; } 
        public int FailCount { set; get; }
        public int TestCount { set; get; }
        public double Yield { set; get; }

        public int PassCount_Nomal { set; get; }
        public int FailCount_Nomal { set; get; }
        public int TestCount_Nomal { set; get; }
        public double Yield_Nomal { set; get; }

        public double TestSpan { set; get; } 
        public double TestIdle { set; get; }
        public double TestCycle { set; get; }
        public TestResult TestResult { set; get; }
        public TestStatus TestStatus { set; get; }

        public int Index { set; get; }
        Stopwatch idlesw;
        bool idleswflag;
        private string iniTesterResutPath = System.Environment.CurrentDirectory + "\\TesterResut.ini";
        public Tester(int index)
        {
            Index = index;
            idleswflag = false;
            idlesw = new Stopwatch();
            TestSpan = double.Parse(Inifile.INIGetStringValue(iniTesterResutPath, "Tester" + Index.ToString(), "TestSpan", "0"));
            TestIdle = double.Parse(Inifile.INIGetStringValue(iniTesterResutPath, "Tester" + Index.ToString(), "TestIdle", "0"));
            TestCycle = double.Parse(Inifile.INIGetStringValue(iniTesterResutPath, "Tester" + Index.ToString(), "TestCycle", "0"));
            PassCount = int.Parse(Inifile.INIGetStringValue(iniTesterResutPath, "Tester" + Index.ToString(), "PassCount", "0"));
            PassCount_Nomal = int.Parse(Inifile.INIGetStringValue(iniTesterResutPath, "Tester" + Index.ToString(), "PassCount_Nomal", "0"));
            FailCount = int.Parse(Inifile.INIGetStringValue(iniTesterResutPath, "Tester" + Index.ToString(), "FailCount", "0"));
            FailCount_Nomal = int.Parse(Inifile.INIGetStringValue(iniTesterResutPath, "Tester" + Index.ToString(), "FailCount_Nomal", "0"));
            TestCount = int.Parse(Inifile.INIGetStringValue(iniTesterResutPath, "Tester" + Index.ToString(), "TestCount", "0"));
            TestCount_Nomal = int.Parse(Inifile.INIGetStringValue(iniTesterResutPath, "Tester" + Index.ToString(), "TestCount_Nomal", "0"));
            Yield = double.Parse(Inifile.INIGetStringValue(iniTesterResutPath, "Tester" + Index.ToString(), "Yield", "0"));
            Yield_Nomal = double.Parse(Inifile.INIGetStringValue(iniTesterResutPath, "Tester" + Index.ToString(), "Yield_Nomal", "0"));
            Async.RunFuncAsync(RunLoop, null);
        }
        public delegate void StartProcessedDelegate(int i);
        public async void Start(StartProcessedDelegate callback)
        {
            Stopwatch sw = new Stopwatch();
            Func<Task> startTask = () =>
            {
                return Task.Run(() =>
                {
                    idleswflag = false;
                    idlesw.Stop();
                    Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "TestIdle", TestIdle.ToString());
                    TestCycle = TestSpan + TestIdle;
                    Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "TestCycle", TestCycle.ToString());
                    sw.Start();
                    TestStatus = TestStatus.Testing;
                    TestResult = TestResult.Unknow;
                    while (TestStatus == TestStatus.Testing)
                    {
                        TestSpan = Math.Round(sw.Elapsed.TotalSeconds, 2);
                        System.Threading.Thread.Sleep(100);
                    }
                });
            };
            await startTask();
            callback(Index);
            UpdateNormal();
            idleswflag = true;
            idlesw.Restart();
        }
        private void RunLoop()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(10);
                if (idleswflag)
                {
                    TestIdle= Math.Round(idlesw.Elapsed.TotalSeconds, 2);
                    if (TestIdle > 99.99)
                    {
                        idleswflag = false;
                        idlesw.Stop();
                    }
                }
            }
        }
        public void UpdateNormal()
        {
            TestCount_Nomal++;
            if (TestResult == TestResult.Pass)
            {
                PassCount_Nomal++;
            }
            else
            {
                FailCount_Nomal++;
            }
            if (PassCount_Nomal + FailCount_Nomal != 0)
            {
                Yield_Nomal = Math.Round((double)PassCount_Nomal / (PassCount_Nomal + FailCount_Nomal) * 100, 2);
            }
            else
            {
                Yield_Nomal= 0;
            }
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "TestSpan", TestSpan.ToString());
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "PassCount_Nomal", PassCount_Nomal.ToString());
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "FailCount_Nomal", FailCount_Nomal.ToString());
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "TestCount_Nomal", TestCount_Nomal.ToString());
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "Yield_Nomal", Yield_Nomal.ToString());
        }
        public void Update(TestResult tr)
        {
            TestCount++;
            if (tr == TestResult.Pass)
            {
                PassCount++;
            }
            else
            {
                FailCount++;
            }
            if (PassCount + FailCount != 0)
            {
                Yield = Math.Round((double)PassCount / (PassCount_Nomal + FailCount) * 100, 2);
            }
            else
            {
                Yield = 0;
            }
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "PassCount", PassCount.ToString());
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "FailCount", FailCount.ToString());
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "TestCount", TestCount.ToString());
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "Yield", Yield.ToString());
        }
        public void Clean()
        {
            TestCount = 0;
            PassCount = 0;
            FailCount = 0;
            Yield = 0;
            TestCount_Nomal = 0;
            PassCount_Nomal = 0;
            FailCount_Nomal = 0;
            Yield_Nomal = 0;
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "PassCount_Nomal", PassCount_Nomal.ToString());
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "FailCount_Nomal", FailCount_Nomal.ToString());
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "TestCount_Nomal", TestCount_Nomal.ToString());
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "Yield_Nomal", Yield_Nomal.ToString());
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "PassCount", PassCount.ToString());
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "FailCount", FailCount.ToString());
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "TestCount", TestCount.ToString());
            Inifile.INIWriteValue(iniTesterResutPath, "Tester" + Index.ToString(), "Yield", Yield.ToString());
        }
    }
}
