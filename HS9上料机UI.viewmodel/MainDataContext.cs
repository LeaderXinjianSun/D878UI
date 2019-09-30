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
using System.Data;
using 臻鼎科技OraDB;
using OfficeOpenXml;
using System.Diagnostics;

namespace HS9上料机UI.viewmodel
{
    public partial class mainData
    {
        #region 属性
        #region Twincat
        public TwinCATCoil1 Light_Alarm { set; get; }
        public TwinCATCoil1 Light_Cmd { set; get; }
        public TwinCATCoil1 NeedUpdateTray { set; get; }
        public TwinCATCoil1 InputSafedoorFlag { set; get; }
        public TwinCATCoil1 OutputSafedoorFlag { set; get; }
        public TwinCATCoil1 ShangLiao { set; get; }
        public TwinCATCoil1 LouLiaoCount { set; get; }
        public TwinCATCoil1 ShangLiaoFlag { set; get; }
        public TwinCATCoil1 ProductLostAlarmFlag { set; get; }
        public TwinCATCoil1 PhotoTimeoutFlag { set; get; }
        public TwinCATCoil1 CloseCMD { set; get; }
        public TwinCATCoil1 WaitCmd1 { set; get; }
        public TwinCATCoil1 M1202 { set; get; }
        public TwinCATCoil1 SuckAlarmRst { set; get; }
        public TwinCATCoil1 M1202_1 { set; get; }
        public TwinCATCoil1 SuckFailedFlag { set; get; }
        public TwinCATCoil1 PLCPreSuck { set; get; }
        public TwinCATCoil1 UnloadTrayCMD { set; get; }
        public TwinCATCoil1 UnloadTrayFinish { set; get; }
        public TwinCATCoil1 EmptyCMD { set; get; }
        public TwinCATCoil1 XYStared { set; get; }
        public TwinCATCoil1 SuckCMD { set; get; }
        public TwinCATCoil1 TRAYEmpty { set; get; }
        public TwinCATCoil1 RollSet { set; get; }
        public TwinCATCoil1 RollReset { set; get; }
        public TwinCATCoil1 FCmdIndex { set; get; }
        public TwinCATCoil1 FMoveCMD { set; get; }
        public TwinCATCoil1 FMoveCompleted { set; get; }
        public TwinCATCoil1 TCmdIndex { set; get; }
        public TwinCATCoil1 XYIndex { set; get; }
        public TwinCATCoil1 TMoveCMD { set; get; }
        public TwinCATCoil1 TMoveCompleted { set; get; }
        public TwinCATCoil1 TUnloadCMD { set; get; }
        public TwinCATCoil1 TUnloadCompleted { set; get; }
        public TwinCATCoil1 ResetCMDComplete { set; get; }
        public TwinCATCoil1 ResetCMD { set; get; }
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
        public TwinCATCoil1 PanTopFlag { set; get; }
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
        public TwinCATCoil1 MachineNum_1 { set; get; }
        #endregion
        #region 界面
        public string SamStart_ { set; get; }
        public string SamStart_H { set; get; }
        public string SamStart_Begin { set; get; }
        public int DaySampleStartMin { set; get; }
        public int NightSampleStartMin { set; get; }
        public int DaySampleStartHour { set; get; }
        public int NightSampleStartHour { set; get; }
        public int DaySampleStartMin1 { set; get; }
        public int NightSampleStartMin1 { set; get; }
        public int DaySampleStartHour1 { set; get; }
        public int NightSampleStartHour1 { set; get; }
        public int MaterialSelectedIndex { set; get; }
        public ObservableCollection<string> MaterialChangeItemsSource { set; get; } = new ObservableCollection<string>();
        public string HomePageVisibility { set; get; } = "Visible";
        public string CameraPageVisibility { set; get; } = "Collapsed";
        public string ParameterPageVisibility { set; get; } = "Collapsed";
        public string TwinCATPageVisibility { set; get; } = "Collapsed";
        public string AlarmPageVisibility { set; get; } = "Collapsed";
        public string TestRecordPageVisibility { set; get; } = "Collapsed";
        public string MaterialPageVisibility { set; get; } = "Collapsed";
        public bool IsSamTest { set; get; } = false;
        public string LoginString { set; get; } = "登录";
        public bool Isloagin { set; get; } = false;
        public string MsgText { set; get; }
        public bool IsPLCConnect { set; get; }
        public bool IsTCPConnect { set; get; }
        public bool IsDBConnect { set; get; }
        public string AlarmTextString { set; get; }
        public string AlarmTextGridShow { set; get; } = "Collapsed";
        public ObservableCollection<AlarmRecord> alarmRecord { set; get; } = new ObservableCollection<AlarmRecord>();
        public ObservableCollection<TestRecord> testRecord { set; get; } = new ObservableCollection<TestRecord>();
        public string LastBanci { set; get; }
        public string M20027 { set; get; } = "Collapsed";
        public string M20028 { set; get; } = "Collapsed";
        public string M20029 { set; get; } = "Collapsed";
        public string M20030 { set; get; } = "Collapsed";
        public string AdminButtonVisibility { set; get; } = "Collapsed";
        public string PLCMessageVisibility { set; get; } = "Collapsed";
        public string SampleTextGridVisibility { set; get; } = "Collapsed";
        public string PLCMessage { set; get; }
        public uint UPH { set; get; }
        public string MNO { set; get; }
        public string TestCount_1 { set; get; }
        public string Yield_1 { set; get; }
        public string PassCount_1 { set; get; }
        public string TestCount_2 { set; get; }
        public string Yield_2 { set; get; }
        public string PassCount_2 { set; get; }
        public string TestCount_3 { set; get; }
        public string Yield_3 { set; get; }
        public string PassCount_3 { set; get; }
        public string TestCount_4 { set; get; }
        public string Yield_4 { set; get; }
        public string PassCount_4 { set; get; }
        public string Downtime { set; get; }
        public string Jigdowntime { set; get; }
        public string Waitforinput { set; get; }
        public string Waitfortray { set; get; }
        public string Waitfortake { set; get; }
        public string TestCount_Total { set; get; }
        public string TestCount_Total1 { set; get; }
        public string LouxiliaoCount { set; get; }
        public string Yield_Total { set; get; }
        public string AchievingRate_ { set; get; }
        public string ProperRate_ { set; get; }
        public string ProperRate_AutoMation_ { set; get; }
        public string ProperRate_Jig_ { set; get; }
        public string 点3 { set; get; }
        public int YieldAddNum1 { set; get; }
        public int YieldAddNum2 { set; get; }
        public int YieldAddNum3 { set; get; }
        public int YieldAddNum4 { set; get; }
        public bool YieldAddNum1Enable { set; get; }
        public bool YieldAddNum2Enable { set; get; }
        public bool YieldAddNum3Enable { set; get; }
        public bool YieldAddNum4Enable { set; get; }
        public int YieldNowNum1 { set; get; }
        public int YieldNowNum2 { set; get; }
        public int YieldNowNum3 { set; get; }
        public int YieldNowNum4 { set; get; }
        public bool ShowYieldAdminControlWindow { set; get; }
        public bool QuitYieldAdminControl { set; get; }
        public bool ShowSampleTestWindow { set; get; }
        public bool QuitSampleTest { set; get; }
        public string LastQingjieStr { set; get; }
        public string SamMessage { set; get; }
        public int PcsGrrNeedNum { set; get; }
        public int PcsGrrNeedCount { set; get; }
        public string MatetialMessage { set; get; }
        public string MatetialTextGridBackground { set; get; }
        public string MatetialTextGridVisibility { set; get; }
        #region 样本
        public string LasSamStr { set; get; }
        public double SampleTimeElapse { set; get; }
        public ObservableCollection<string> SampleNgitem { set; get; } = new ObservableCollection<string>();
        public ObservableCollection<string> SampleItemsStatus { set; get; } = new ObservableCollection<string>();
        public int SampleNgitemsNum { set; get; }
        public int SamTimesLimit { set; get; }
        #endregion
        #endregion
        #region 统计
        public string PassStatusDisplay1 { set; get; }
        public string PassStatusDisplay2 { set; get; }
        public string PassStatusDisplay3 { set; get; }
        public string PassStatusDisplay4 { set; get; }
        public string PassStatusColor1 { set; get; }
        public string PassStatusColor2 { set; get; }
        public string PassStatusColor3 { set; get; }
        public string PassStatusColor4 { set; get; }

        public double TestTime0 { set; get; }
        public double TestTime1 { set; get; }
        public double TestTime2 { set; get; }
        public double TestTime3 { set; get; }

        public double TestIdle0 { set; get; }
        public double TestIdle1 { set; get; }
        public double TestIdle2 { set; get; }
        public double TestIdle3 { set; get; }

        public double TestCycle0 { set; get; } 
        public double TestCycle1 { set; get; }
        public double TestCycle2 { set; get; }
        public double TestCycle3 { set; get; }

        public double TestCycleAve { set; get; }

        public string TesterResult0 { set; get; } = "Unknow";
        public string TesterResult1 { set; get; } = "Unknow";
        public string TesterResult2 { set; get; } = "Unknow";
        public string TesterResult3 { set; get; } = "Unknow";

        public string TesterStatusForeground0 { set; get; } = "Yellow";
        public string TesterStatusForeground1 { set; get; } = "Yellow";
        public string TesterStatusForeground2 { set; get; } = "Yellow";
        public string TesterStatusForeground3 { set; get; } = "Yellow";

        public string TesterStatusBackGround0 { set; get; } = "Gray";
        public string TesterStatusBackGround1 { set; get; } = "Gray";
        public string TesterStatusBackGround2 { set; get; } = "Gray";
        public string TesterStatusBackGround3 { set; get; } = "Gray";
        #endregion
        #region 及时雨
        public int TotalAlarmNum { set; get; } = 0;
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
        public bool TestCheckedAL { set; get; } = true;
        public bool TestCheckedBL { set; get; } = true;
        #endregion
        #region 参数
        public string SerialPortCom { set; get; }
        public string MachineNum { set; get; }
        public string UITitle { set; get; }
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
        private string iniTimeCalcPath = System.Environment.CurrentDirectory + "\\TimeCalc.ini";
        private string iniAlarmPath = System.Environment.CurrentDirectory + "\\AlarmRecord.ini";
        private string initestPath = @"D:\test.ini";
        private string iniFClient = @"C:\FClient.ini";
        public static DispatcherTimer dispatcherTimer = new DispatcherTimer();
        bool autoClean = false;
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
        bool EStop = false;
        bool isUpdateImage = false;
        Queue<AlarmRecord> myAlarmRecordQueue = new Queue<AlarmRecord>();
        Queue<TestRecord> myTestRecordQueue = new Queue<TestRecord>();
        string barstr = "";
        DateTime lastEpsonAlarm;
        short MinTick = 0,DecTick = 0;
        double down_min = 0, jigdown_min = 0, waitinput_min = 0, waittray_min = 0, waittake_min = 0, run_min = 0,  work_min = 0;
        bool down_flag = false, jigdown_flag = false, waitinput_flag = false, waittray_flag = false, waittake_flag = false, work_flag = false;
        bool PLCAlarmStatus = false;
        double AchievingRate, ProperRate, ProperRate_AutoMation, ProperRate_Jig;
        string DangbanFirstProduct = "";
        uint liaoinput = 0, liaooutput = 0,louliao = 0;
        bool _PLCAlarmStatus = false;
        bool shangLiaoFlag = false, loadsuckFlag = false, unloadsuckFlag = false, _bfo2 = false;
        string[] FlexId = new string[4];
        string VersionMsg = "2019093001";
        DateTime LastQingjie = System.DateTime.Now;
        DateTime LasSam = System.DateTime.Now;
        bool AllowCleanActionCommand = true;
        List<int[]> SamOrderList = new List<int[]>();
        string[,] SamArray = new string[8, 4];
        DateTime SamStart = DateTime.Now;
        bool haocaiinit = true;int haocaisavetimes = 0;
        int MaterialStatus = 0;
        string index_ini, index_ini_old = "";
        bool unloadreadindexflag = false;
        bool red_normal = false, green_flicker = false, green_normal = false, yellow_flicker = false, yellow_normal = false;
        int signal_lamp = 0;
        bool isSendSamCMD = false;
        Stopwatch Unloadsw = new Stopwatch();
        bool lockuiflag = false;
        #endregion
        #region 功能
        #region 初始化
        #region 构造函数
        public mainData()
        {
            TwincatVarInit();
            Init();
            cameraHcInit();
            Async.RunFuncAsync(ConnectDBTest, null);
            Async.RunFuncAsync(PLCWork, null);
            Async.RunFuncAsync(Run, null);
        }
        #endregion
        #region Twincat实例化
        private void TwincatVarInit()
        {
            Light_Alarm = new TwinCATCoil1(new TwinCATCoil("MAIN.Light_Alarm", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            Light_Cmd = new TwinCATCoil1(new TwinCATCoil("MAIN.Light_Cmd", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            NeedUpdateTray = new TwinCATCoil1(new TwinCATCoil("MAIN.NeedUpdateTray", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            InputSafedoorFlag = new TwinCATCoil1(new TwinCATCoil("MAIN.InputSafedoorFlag", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            OutputSafedoorFlag = new TwinCATCoil1(new TwinCATCoil("MAIN.OutputSafedoorFlag", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            ShangLiao = new TwinCATCoil1(new TwinCATCoil("MAIN.ShangLiao", typeof(uint), TwinCATCoil.Mode.Notice), _TwinCATAds);
            LouLiaoCount = new TwinCATCoil1(new TwinCATCoil("MAIN.LouLiaoCount", typeof(uint), TwinCATCoil.Mode.Notice), _TwinCATAds);

            ShangLiaoFlag = new TwinCATCoil1(new TwinCATCoil("MAIN.ShangLiaoFlag", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

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

            PanTopFlag = new TwinCATCoil1(new TwinCATCoil("MAIN.PanTopFlag", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

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

            FMoveCMD = new TwinCATCoil1(new TwinCATCoil("MAIN.FMoveCMD", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            FMoveCompleted = new TwinCATCoil1(new TwinCATCoil("MAIN.FMoveCompleted", typeof(bool), TwinCATCoil.Mode.Notice, 1), _TwinCATAds);
            FCmdIndex = new TwinCATCoil1(new TwinCATCoil("MAIN.FCmdIndex", typeof(ushort), TwinCATCoil.Mode.Notice, 1), _TwinCATAds);

            TMoveCMD = new TwinCATCoil1(new TwinCATCoil("MAIN.TMoveCMD", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TMoveCompleted = new TwinCATCoil1(new TwinCATCoil("MAIN.TMoveCompleted", typeof(bool), TwinCATCoil.Mode.Notice, 1), _TwinCATAds);
            TCmdIndex = new TwinCATCoil1(new TwinCATCoil("MAIN.TCmdIndex", typeof(ushort), TwinCATCoil.Mode.Notice, 1), _TwinCATAds);

            XYIndex = new TwinCATCoil1(new TwinCATCoil("MAIN.XYIndex", typeof(ushort), TwinCATCoil.Mode.Notice, 1), _TwinCATAds);


            TUnloadCMD = new TwinCATCoil1(new TwinCATCoil("MAIN.TUnloadCMD", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TUnloadCompleted = new TwinCATCoil1(new TwinCATCoil("MAIN.TUnloadCompleted", typeof(bool), TwinCATCoil.Mode.Notice, 1), _TwinCATAds);

            ResetCMDComplete = new TwinCATCoil1(new TwinCATCoil("MAIN.ResetCMDComplete", typeof(bool), TwinCATCoil.Mode.Notice, 1), _TwinCATAds);
            ResetCMD = new TwinCATCoil1(new TwinCATCoil("MAIN.ResetCMD", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            SuckCMD = new TwinCATCoil1(new TwinCATCoil("MAIN.SuckCMD", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            TRAYEmpty = new TwinCATCoil1(new TwinCATCoil("MAIN.TRAYEmpty", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            RollSet = new TwinCATCoil1(new TwinCATCoil("MAIN.RollSet", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            RollReset = new TwinCATCoil1(new TwinCATCoil("MAIN.RollReset", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            XYStared = new TwinCATCoil1(new TwinCATCoil("MAIN.XYStared", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            EmptyCMD = new TwinCATCoil1(new TwinCATCoil("MAIN.EmptyCMD", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            UnloadTrayCMD = new TwinCATCoil1(new TwinCATCoil("MAIN.UnloadTrayCMD", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            UnloadTrayFinish = new TwinCATCoil1(new TwinCATCoil("MAIN.UnloadTrayFinish", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PLCPreSuck = new TwinCATCoil1(new TwinCATCoil("MAIN.PLCPreSuck", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            SuckFailedFlag = new TwinCATCoil1(new TwinCATCoil("MAIN.SuckFailedFlag", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            M1202_1 = new TwinCATCoil1(new TwinCATCoil("MAIN.M1202_1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            SuckAlarmRst = new TwinCATCoil1(new TwinCATCoil("MAIN.SuckAlarmRst", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            M1202 = new TwinCATCoil1(new TwinCATCoil("MAIN.M1202", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            WaitCmd1 = new TwinCATCoil1(new TwinCATCoil("MAIN.WaitCmd1", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            CloseCMD = new TwinCATCoil1(new TwinCATCoil("MAIN.CloseCMD", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);

            ProductLostAlarmFlag = new TwinCATCoil1(new TwinCATCoil("MAIN.ProductLostAlarmFlag", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            PhotoTimeoutFlag = new TwinCATCoil1(new TwinCATCoil("MAIN.PhotoTimeoutFlag", typeof(bool), TwinCATCoil.Mode.Notice), _TwinCATAds);
            MachineNum_1 = new TwinCATCoil1(new TwinCATCoil("MAIN.MachineNum_1", typeof(ushort), TwinCATCoil.Mode.Notice, 1), _TwinCATAds);

            _TwinCATAds.StartNotice();
        }
        #endregion
        #region 硬件实例化
        private void Init()
        {
            SamOrderList.Add(new int[4] { 0, 1, 2, 3 });
            SamOrderList.Add(new int[4] { 3, 0, 1, 2 });
            SamOrderList.Add(new int[4] { 2, 3, 0, 1 });
            SamOrderList.Add(new int[4] { 1, 2, 3, 0 });
            for (int i = 0; i < 32; i++)
            {
                SampleItemsStatus.Add("");
                SamArray[i / 4, i % 4] = "";
            }
            ReadParameter();
            ReadAlarmRecordfromCSV();
            ReadRecordfromCSV();
            Xinjie = new ThingetPLC();           
            epsonRC90 = new EpsonRC90();
            epsonRC90.ModelPrint += ModelPrintEventProcess;
            epsonRC90.EpsonStatusUpdate += EpsonStatusUpdateProcess;
            epsonRC90.EPSONCommTwincat += EPSONCommTwincatEventProcess;
            epsonRC90.DiaoLiaoEvent += DiaoLiaoEventProcess;
            epsonRC90.MaterialEvent += MaterialEventProcess;
            epsonRC90.TestFinished += StartUpdateProcess;
            epsonRC90.SamMessage += SamMessageProcess;
            epsonRC90.SamReMessage += SamReMessageProcess;
            dispatcherTimer.Tick += new EventHandler(DispatcherTimerTickUpdateUi);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
            lastEpsonAlarm = System.DateTime.Now;
        }
        #endregion
        #endregion
        #region 界面
        #region 测试
        public void TestFunc()
        {
            ////SampleNgitem[0] = System.DateTime.Now.ToString();
            //FileInfo existingFile = new FileInfo("C:\\life  control of consumables.xlsx");
            //try
            //{
            //    ExcelPackage package = new ExcelPackage(existingFile);
            //    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}
            LockUI();
        }
        #endregion
        public async void ChangeMaterialOperate()
        {
            string rr = await GlobalVar.metro.ShowLoginOnlyPassword("确认将 "+ MaterialChangeItemsSource[MaterialSelectedIndex] + " 更换？");
            string ss = GetPassWord();
            if (rr == ss)
            {
                try
                {
                    GlobalVar.Worksheet.Cells[MaterialSelectedIndex + 3, 9].Value = Convert.ToInt32(GlobalVar.Worksheet.Cells[MaterialSelectedIndex + 3, 9].Value) + 1;
                    GlobalVar.Worksheet.Cells[MaterialSelectedIndex + 3, 7].Value = GlobalVar.Worksheet.Cells[MaterialSelectedIndex + 3, 8].Value;
                    GlobalVar.Worksheet.Cells[MaterialSelectedIndex + 3, 8].Value = System.DateTime.Now.ToString();
                    GlobalVar.Worksheet.Cells[MaterialSelectedIndex + 3, 6].Value = 0;

                }
                catch (Exception ex)
                {
                    MsgText = AddMessage(ex.Message);
                }
            }
        }
        public async void ChoosePage(object p)
        {
            switch (p.ToString())
            {
                case "0":
                    HomePageVisibility = "Visible";
                    CameraPageVisibility = "Collapsed";
                    ParameterPageVisibility = "Collapsed";
                    TwinCATPageVisibility = "Collapsed";
                    AlarmPageVisibility = "Collapsed";
                    TestRecordPageVisibility = "Collapsed";
                    MaterialPageVisibility = "Collapsed";
                    LoginString = "登录";
                    Isloagin = false;
                    break;
                case "1":
                    HomePageVisibility = "Collapsed";
                    CameraPageVisibility = "Visible";
                    ParameterPageVisibility = "Collapsed";
                    TwinCATPageVisibility = "Collapsed";
                    AlarmPageVisibility = "Collapsed";
                    TestRecordPageVisibility = "Collapsed";
                    MaterialPageVisibility = "Collapsed";
                    LoginString = "登录";
                    Isloagin = false;
                    break;
                case "2":
                    HomePageVisibility = "Collapsed";
                    CameraPageVisibility = "Collapsed";
                    ParameterPageVisibility = "Collapsed";
                    TwinCATPageVisibility = "Visible";
                    AlarmPageVisibility = "Collapsed";
                    TestRecordPageVisibility = "Collapsed";
                    MaterialPageVisibility = "Collapsed";
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
                    AlarmPageVisibility = "Collapsed";
                    TestRecordPageVisibility = "Collapsed";
                    MaterialPageVisibility = "Collapsed";
                    break;
                case "7":
                    HomePageVisibility = "Collapsed";
                    CameraPageVisibility = "Collapsed";
                    ParameterPageVisibility = "Collapsed";
                    TwinCATPageVisibility = "Collapsed";
                    AlarmPageVisibility = "Visible";
                    TestRecordPageVisibility = "Collapsed";
                    MaterialPageVisibility = "Collapsed";
                    break;
                case "8":
                    HomePageVisibility = "Collapsed";
                    CameraPageVisibility = "Collapsed";
                    ParameterPageVisibility = "Collapsed";
                    TwinCATPageVisibility = "Collapsed";
                    AlarmPageVisibility = "Collapsed";
                    TestRecordPageVisibility = "Visible";
                    MaterialPageVisibility = "Collapsed";
                    break;
                case "9":
                    HomePageVisibility = "Collapsed";
                    CameraPageVisibility = "Collapsed";
                    ParameterPageVisibility = "Collapsed";
                    TwinCATPageVisibility = "Collapsed";
                    AlarmPageVisibility = "Collapsed";
                    TestRecordPageVisibility = "Collapsed";
                    MaterialPageVisibility = "Visible";
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
                    AlarmTextGridShow = "Collapsed";
                    string maopaostr = MaopaoPaixu();
                    if (epsonRC90.CtrlStatus && EpsonStatusReady && !EpsonStatusEStop)
                    {
                        await epsonRC90.CtrlNet.SendAsync("$start,2");
                    }
                    if (epsonRC90.TestSendStatus)
                    {
                        await epsonRC90.TestSentNet.SendAsync("IndexArray_i;" + maopaostr);
                        await Task.Delay(100);
                        if (!IsSamTest)
                        {
                            await epsonRC90.TestSentNet.SendAsync("GONOGOCancel");
                        }
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
                    if (AlarmTextGridShow == "Visible" && AlarmTextString.Contains("上传软体异常"))
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (!epsonRC90.uploadSoftwareStatus[i].status)
                            {
                                epsonRC90.uploadSoftwareStatus[i].ResetCommand();
                                
                            }
                        }

                    }
                    AlarmTextGridShow = "Collapsed";
                    if (epsonRC90.CtrlStatus)
                    {
                        await epsonRC90.CtrlNet.SendAsync("$continue");            
                    }

                    break;
                case "4":
                    AlarmTextGridShow = "Collapsed";
                    GlobalVar.metro.ChangeAccent("Red");
                    var r = await GlobalVar.metro.ShowConfirm("确认","确定进行停止机械手重启操作吗？");
                    if (r && epsonRC90.CtrlStatus)
                    {
                        await epsonRC90.CtrlNet.SendAsync("$stop");
                        await Task.Delay(300);
                        await epsonRC90.CtrlNet.SendAsync("$SetMotorOff,1");
                        await Task.Delay(400);
                        await epsonRC90.CtrlNet.SendAsync("$reset");
                        Tester.IsInGRRMode = false;
                    }
                    GlobalVar.metro.ChangeAccent("Blue");
                    break;
                case "5":
                    GlobalVar.metro.ChangeAccent("Red");
                    r = await GlobalVar.metro.ShowConfirm("确认", "确定进行排料操作吗？");
                    if (r && epsonRC90.TestSendStatus && (EpsonStatusRunning || EpsonStatusPaused))
                    {
                        await epsonRC90.TestSentNet.SendAsync("Discharge");
                    }
                    GlobalVar.metro.ChangeAccent("Blue");
                    break;
                case "9":
                    ShowYieldAdminControlWindow = !ShowYieldAdminControlWindow;
                    YieldAddNum4 = YieldAddNum3 = YieldAddNum2 = YieldAddNum1 = 0;
                    YieldAddNum1Enable = epsonRC90.YanmadeTester[0].Yield_Nomal < 95 && epsonRC90.YanmadeTester[0].TestCount_Nomal >= 100 + epsonRC90.AdminAddNum[0];
                    if (YieldAddNum1Enable)
                    {       
                        YieldAddNum1 = 200;
                    }
                    YieldAddNum2Enable = epsonRC90.YanmadeTester[1].Yield_Nomal < 95 && epsonRC90.YanmadeTester[1].TestCount_Nomal >= 100 + epsonRC90.AdminAddNum[1];
                    if (YieldAddNum2Enable)
                    {                       
                        YieldAddNum2 = 200;
                    }
                    YieldAddNum3Enable = epsonRC90.YanmadeTester[2].Yield_Nomal < 95 && epsonRC90.YanmadeTester[2].TestCount_Nomal >= 100 + epsonRC90.AdminAddNum[2];
                    if (YieldAddNum3Enable)
                    {                        
                        YieldAddNum3 = 200;
                    }
                    YieldAddNum4Enable = epsonRC90.YanmadeTester[3].Yield_Nomal < 95 && epsonRC90.YanmadeTester[3].TestCount_Nomal >= 100 + epsonRC90.AdminAddNum[3];
                    if (YieldAddNum4Enable)
                    {                        
                        YieldAddNum4 = 200;
                    }
                    break;
                case "11":
                    if (YieldAddNum1Enable)
                    {                        
                        epsonRC90.AdminAddNum[0] = epsonRC90.YanmadeTester[0].TestCount_Nomal - 100 + YieldAddNum1;
                    }
                    if (YieldAddNum2Enable)
                    {
                        epsonRC90.AdminAddNum[1] = epsonRC90.YanmadeTester[1].TestCount_Nomal - 100 + YieldAddNum2;
                    }
                    if (YieldAddNum3Enable)
                    {
                        epsonRC90.AdminAddNum[2] = epsonRC90.YanmadeTester[2].TestCount_Nomal - 100 + YieldAddNum3;
                    }
                    if (YieldAddNum4Enable)
                    {
                        epsonRC90.AdminAddNum[3] = epsonRC90.YanmadeTester[3].TestCount_Nomal - 100 + YieldAddNum4;
                    }
                    QuitYieldAdminControl = !QuitYieldAdminControl;
                    AdminButtonVisibility = "Collapsed";
                    break;
                case "12":
                    ShowSampleTestWindow = !ShowSampleTestWindow;
                    break;
                case "13":
                    if (epsonRC90.TestSendStatus && IsSamTest)
                    {
                        await epsonRC90.TestSentNet.SendAsync("GONOGOAction;" + SampleNgitemsNum.ToString());
                    }
                    break;
                case "14":
                    string ls = await GlobalVar.metro.ShowLoginOnlyPassword("进入GRR模式确认");
                    if (ls == "GRR" + GetPassWord() && epsonRC90.TestSendStatus && (EpsonStatusRunning || EpsonStatusPaused))
                    {
                        await epsonRC90.TestSentNet.SendAsync("GRRTimesAsk;" + PcsGrrNeedNum.ToString() + ";" + PcsGrrNeedCount.ToString());
                    }
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
        public async void UpdateSelectFlexer()
        {
            if (!TestCheckedAL && !TestCheckedBL)
            {
                TestCheckedAL = true;
            }
            string str = "Select;";
            if (TestCheckedAL)
            {
                str += "1;1;";
            }
            else
            {
                str += "0;0;";

            }
            if (TestCheckedBL)
            {
                str += "1;1";
            }
            else
            {
                str += "0;0";         

            }
            if (epsonRC90.TestSendStatus)
            {
                await epsonRC90.TestSentNet.SendAsync(str);
            }
            Inifile.INIWriteValue(iniParameterPath, "Tester", "TestCheckedAL", TestCheckedAL.ToString());
            Inifile.INIWriteValue(iniParameterPath, "Tester", "TestCheckedBL", TestCheckedBL.ToString());
            await Task.Delay(100);
            str = "MachineNum;";
            switch (MachineNum)
            {
                case "1372":
                    str += "1";
                    MachineNum_1.Value = 1;
                    break;
                case "1373":
                    str += "2";
                    MachineNum_1.Value = 2;
                    break;
                case "1374":
                    str += "3";
                    MachineNum_1.Value = 3;
                    break;
                default:
                    str += "3";
                    MachineNum_1.Value = 3;
                    break;
            }
            if (epsonRC90.TestSendStatus)
                await epsonRC90.TestSentNet.SendAsync(str);
            Inifile.INIWriteValue(iniParameterPath, "System", "MachineNum", MachineNum);
            UITitle = MachineNum + "UI " + VersionMsg;
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
        private void ShowAlarmTextGrid(string str)
        {
            AlarmTextString = str;

            AlarmTextGridShow = "Visible";
            string ss = str.Replace("\n", "");
            Inifile.INIWriteValue(iniFClient, "Alarm", "Name", ss);
        }
        private void SaveAlarm(string str)
        {
            TimeSpan ts = System.DateTime.Now - lastEpsonAlarm;
            if (barstr != str || ts.TotalMinutes > 2)
            {
                RecordAlarmString(str);
                barstr = str;
                lastEpsonAlarm = System.DateTime.Now;
            }
        }
        private void RecordAlarmString(string str)
        {
            AlarmRecord ar = new AlarmRecord(System.DateTime.Now.ToString(), str);
            TotalAlarmNum++;
            Inifile.INIWriteValue(iniTimeCalcPath, "Alarm", "TotalAlarmNum", TotalAlarmNum.ToString());
            lock (this)
            {
                myAlarmRecordQueue.Enqueue(ar);
                SaveCSVfileAlarm(str);
            }

        }
        private void SaveCSVfileAlarm(string alrstr)
        {
            string filepath = "D:\\报警记录\\报警记录" + GetBanci() + ".csv";
            if (!Directory.Exists("D:\\报警记录"))
            {
                Directory.CreateDirectory("D:\\报警记录");
            }
            try
            {
                if (!File.Exists(filepath))
                {
                    string[] heads = { "Time", "Content" };
                    Csvfile.AddNewLine(filepath, heads);
                }
                string[] conte = { System.DateTime.Now.ToString(), alrstr };
                Csvfile.AddNewLine(filepath, conte);
            }
            catch (Exception ex)
            {
                MsgText = AddMessage(ex.Message);
            }
        }
        private string GetBanci()
        {
            string rs = "";
            if (DateTime.Now.Hour >= 8 && DateTime.Now.Hour < 20)
            {
                rs += DateTime.Now.ToString("yyyyMMdd") + "Day";
            }
            else
            {
                if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 8)
                {
                    rs += DateTime.Now.AddDays(-1).ToString("yyyyMMdd") + "Night";
                }
                else
                {
                    rs += DateTime.Now.ToString("yyyyMMdd") + "Night";
                }
            }
            return rs;
        }
        private string[] PassStatusProcess(double f)
        {
            string[] strs = new string[2];
            if (f > 98)
            {
                strs[0] = "良率" + f.ToString() + "% 优秀";
                strs[1] = "Blue";
            }
            else
            {
                if (f > 95)
                {
                    strs[0] = "良率" + f.ToString() + "% 正常";
                    strs[1] = "Green";
                }
                else
                {
                    if (f == 0)
                    {
                        strs[0] = "良率" + f.ToString() + "% 未知";
                        strs[1] = "Black";
                    }
                    else
                    {
                        strs[0] = "良率" + f.ToString() + "% 异常";
                        strs[1] = "Red";
                    }

                }
            }
            return strs;
        }
        #region TwinCATOperate
        public void TwinCATAlarmOperate(object p)
        {
            try
            {
                switch (p.ToString())
                {
                    case "0":
                        if ((bool)SuckFailedFlag.Value)
                        {
                            SuckAlarmRst.Value = true;
                        }
                        break;
                    case "1":
                        M1202_1.Value = !(bool)M1202_1.Value;
                        break;
                    case "2":
                        if ((bool)ProductLostAlarmFlag.Value)
                        {
                            ProductLostAlarmFlag.Value = false;
                        }
                        break;
                    case "3":
                        Light_Cmd.Value = !(bool)Light_Cmd.Value;
                        break;
                    default:
                        break;
                }
            }
            catch
            {

               
            }
        }
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
                    //BFO4.Value = !(bool)BFO4.Value;
                    break;
                case "5":
                    BFO5.Value = !(bool)BFO5.Value;
                    break;
                case "6":
                    //BFO6.Value = !(bool)BFO6.Value;
                    break;
                case "7":
                    //BFO7.Value = !(bool)BFO7.Value;
                    break;
                case "8":
                    //BFO8.Value = !(bool)BFO8.Value;
                    break;
                case "9":
                    //BFO9.Value = !(bool)BFO9.Value;
                    break;
                case "10":
                    //BFO10.Value = !(bool)BFO10.Value;
                    break;
                case "11":
                    //BFO11.Value = !(bool)BFO11.Value;
                    break;
                case "12":
                    //BFO12.Value = !(bool)BFO12.Value;
                    break;
                case "13":
                    //BFO13.Value = !(bool)BFO13.Value;
                    break;
                case "14":
                    BFO14.Value = !(bool)BFO14.Value;
                    break;
                case "15":
                    BFO15.Value = !(bool)BFO15.Value;
                    break;
                case "16":
                    //BFO16.Value = !(bool)BFO16.Value;
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

                switch (MachineNum)
                {
                    case "1372":
      
                        MachineNum_1.Value = 1;
                        break;
                    case "1373":
                    
                        MachineNum_1.Value = 2;
                        break;
                    case "1374":
                    
                        MachineNum_1.Value = 3;
                        break;
                    default:
                      
                        MachineNum_1.Value = 3;
                        break;
                }
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
            if (DangbanFirstProduct != GetBanci())
            {
                if (str.Contains("Start"))
                {
                    DangbanFirstProduct = GetBanci();
                    Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "DangbanFirstProduct", DangbanFirstProduct);
                    MsgText = AddMessage(DangbanFirstProduct + " 开班第1片");
                }
            }
            switch (str)
            {
                case "MsgRev: PickAction0":
                    try
                    {
                        GlobalVar.Worksheet.Cells[11, 6].Value = Convert.ToInt32(GlobalVar.Worksheet.Cells[11, 6].Value) + 1;
                    }
                    catch (Exception ex)
                    {
                        MsgText = AddMessage(ex.Message);
                    }
                    break;
                case "MsgRev: PickAction1":
                    try
                    {
                        GlobalVar.Worksheet.Cells[12, 6].Value = Convert.ToInt32(GlobalVar.Worksheet.Cells[12, 6].Value) + 1;
                    }
                    catch (Exception ex)
                    {
                        MsgText = AddMessage(ex.Message);
                    }
                    break;
                case "MsgRev: 请确认，不得取走上料盘产品":
                    ShowAlarmTextGrid("请确认，\n不得取走上料盘产品！");
                    break;
                case "MsgRev: 样本或GRR料留在治具内":
                    ShowAlarmTextGrid("样本或GRR料留在治具内，\n请将产品取出，防止混料");
                    break;
                case "MsgRev: 测试机1，吸取失败":
                    ShowAlarmTextGrid("测试机1，吸取失败\n请将产品取走，防止叠料！");
                    SaveAlarm("测试机1，吸取失败");
                    break;
                case "MsgRev: 测试机2，吸取失败":
                    ShowAlarmTextGrid("测试机2，吸取失败\n请将产品取走，防止叠料！");
                    SaveAlarm("测试机2，吸取失败");
                    break;
                case "MsgRev: 测试机3，吸取失败":
                    ShowAlarmTextGrid("测试机3，吸取失败\n请将产品取走，防止叠料！");
                    SaveAlarm("测试机3，吸取失败");
                    break;
                case "MsgRev: 测试机4，吸取失败":
                    ShowAlarmTextGrid("测试机4，吸取失败\n请将产品取走，防止叠料！");
                    SaveAlarm("测试机4，吸取失败");
                    break;
                case "MsgRev: 测试机1，吸取失败1":
                    ShowAlarmTextGrid("放料，测试机1，吸取失败\n请将产品取走，防止叠料！");
                    SaveAlarm("放料，测试机1，吸取失败");
                    break;
                case "MsgRev: 测试机2，吸取失败1":
                    ShowAlarmTextGrid("放料，测试机2，吸取失败\n请将产品取走，防止叠料！");
                    SaveAlarm("放料，测试机2，吸取失败");
                    break;
                case "MsgRev: 测试机3，吸取失败1":
                    ShowAlarmTextGrid("放料，测试机3，吸取失败\n请将产品取走，防止叠料！");
                    SaveAlarm("放料，测试机3，吸取失败");
                    break;
                case "MsgRev: 测试机4，吸取失败1":
                    ShowAlarmTextGrid("放料，测试机4，吸取失败\n请将产品取走，防止叠料！");
                    SaveAlarm("放料，测试机4，吸取失败");
                    break;
                case "MsgRev: 测试工位1，产品没放好":                    
                    //SaveAlarm("测试工位1，产品没放好");
                    //if (liaoinput > 0)
                    //{
                    //    liaoinput -= 1;
                    //    Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "liaoinput", liaoinput.ToString());
                    //}
                    break;
                case "MsgRev: 测试工位2，产品没放好":
                    //SaveAlarm("测试工位2，产品没放好");
                    //if (liaoinput > 0)
                    //{
                    //    liaoinput -= 1;
                    //    Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "liaoinput", liaoinput.ToString());
                    //}
                    break;
                case "MsgRev: 测试工位3，产品没放好":
                    //SaveAlarm("测试工位3，产品没放好");
                    //if (liaoinput > 0)
                    //{
                    //    liaoinput -= 1;
                    //    Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "liaoinput", liaoinput.ToString());
                    //}
                    break;
                case "MsgRev: 测试工位4，产品没放好":
                    //SaveAlarm("测试工位4，产品没放好");
                    //if (liaoinput > 0)
                    //{
                    //    liaoinput -= 1;
                    //    Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "liaoinput", liaoinput.ToString());
                    //}
                    break;
                case "MsgRev: 测试工位1，产品没放好，样本":
                    ShowAlarmTextGrid("测试工位1，产品没放好，样本\n请将样本扶好");
                    //SaveAlarm("测试工位1，产品没放好，样本");
                    break;
                case "MsgRev: 测试工位2，产品没放好，样本":
                    ShowAlarmTextGrid("测试工位2，产品没放好，样本\n请将样本扶好");
                    //SaveAlarm("测试工位2，产品没放好，样本");
                    break;
                case "MsgRev: 测试工位3，产品没放好，样本":
                    ShowAlarmTextGrid("测试工位3，产品没放好，样本\n请将样本扶好");
                    //SaveAlarm("测试工位3，产品没放好，样本");
                    break;
                case "MsgRev: 测试工位4，产品没放好，样本":
                    ShowAlarmTextGrid("测试工位4，产品没放好，样本\n请将样本扶好");
                    //SaveAlarm("测试工位4，产品没放好，样本");
                    break;

                case "MsgRev: 测试工位1，产品没放好，GRR":
                    ShowAlarmTextGrid("测试工位1，产品没放好，GRR\n请将GRR扶好");
                    SaveAlarm("测试工位1，产品没放好，GRR");
                    break;
                case "MsgRev: 测试工位2，产品没放好，GRR":
                    ShowAlarmTextGrid("测试工位2，产品没放好，GRR\n请将GRR扶好");
                    SaveAlarm("测试工位2，产品没放好，GRR");
                    break;
                case "MsgRev: 测试工位3，产品没放好，GRR":
                    ShowAlarmTextGrid("测试工位3，产品没放好，GRR\n请将GRR扶好");
                    SaveAlarm("测试工位3，产品没放好，GRR");
                    break;
                case "MsgRev: 测试工位4，产品没放好，GRR":
                    ShowAlarmTextGrid("测试工位4，产品没放好，GRR\n请将GRR扶好");
                    SaveAlarm("测试工位4，产品没放好，GRR");
                    break;

                case "MsgRev: 样本盘，吸取失败":
                    ShowAlarmTextGrid("样本盘，吸取失败\n请将样本放回原位");
                    //ShowAlarmTextGrid("样本盘，吸取失败");
                    break;
                case "MsgRev: 上料盘1，吸取失败":
                    ShowAlarmTextGrid("上料盘1，吸取失败\n请将产品放回原位");
                    SaveAlarm("上料盘1，吸取失败");
                    break;
                case "MsgRev: 上料盘2，吸取失败":
                    ShowAlarmTextGrid("上料盘2，吸取失败\n请将产品放回原位");
                    SaveAlarm("上料盘2，吸取失败");
                    break;
                case "MsgRev: 上料盘3，吸取失败":
                    ShowAlarmTextGrid("上料盘3，吸取失败\n请将产品放回原位");
                    SaveAlarm("上料盘3，吸取失败");
                    break;
                case "MsgRev: 上料盘4，吸取失败":
                    ShowAlarmTextGrid("上料盘4，吸取失败\n请将产品放回原位");
                    SaveAlarm("上料盘4，吸取失败");
                    break;
                case "MsgRev: 上料盘5，吸取失败":
                    ShowAlarmTextGrid("上料盘5，吸取失败\n请将产品放回原位");
                    SaveAlarm("上料盘5，吸取失败");
                    break;
                case "MsgRev: 上料盘6，吸取失败":
                    ShowAlarmTextGrid("上料盘6，吸取失败\n请将产品放回原位");
                    SaveAlarm("上料盘6，吸取失败");
                    break;
                case "MsgRev: 上料盘7，吸取失败":
                    ShowAlarmTextGrid("上料盘7，吸取失败\n请将产品放回原位");
                    SaveAlarm("上料盘7，吸取失败");
                    break;
                case "MsgRev: 上料盘8，吸取失败":
                    ShowAlarmTextGrid("上料盘8，吸取失败\n请将产品放回原位");
                    SaveAlarm("上料盘8，吸取失败");
                    break;
                case "MsgRev: 上料盘9，吸取失败":
                    ShowAlarmTextGrid("上料盘9，吸取失败\n请将产品放回原位");
                    SaveAlarm("上料盘9，吸取失败");
                    break;
                case "MsgRev: 上料盘10，吸取失败":
                    ShowAlarmTextGrid("上料盘10，吸取失败\n请将产品放回原位");
                    SaveAlarm("上料盘10，吸取失败");
                    break;
                case "MsgRev: 测试机1，连续NG":
                    ShowAlarmTextGrid("测试机1，连续三次NG，请进行清洁");
                    //RecordAlarmString("测试机1，连续NG");
                    break;
                case "MsgRev: 测试机2，连续NG":
                    ShowAlarmTextGrid("测试机2，连续三次NG，请进行清洁");
                    //RecordAlarmString("测试机2，连续NG");
                    break;
                case "MsgRev: 测试机3，连续NG":
                    ShowAlarmTextGrid("测试机3，连续三次NG，请进行清洁");
                    //RecordAlarmString("测试机3，连续NG");
                    break;
                case "MsgRev: 测试机4，连续NG":
                    ShowAlarmTextGrid("测试机4，连续三次NG，请进行清洁");
                    //RecordAlarmString("测试机4，连续NG");
                    break;
                case "MsgRev: 测试机1，上传软体异常":
                    ShowAlarmTextGrid("测试机1，上传软体异常");
                    //RecordAlarmString("测试机1，上传软体异常");
                    break;
                case "MsgRev: 测试机2，上传软体异常":
                    ShowAlarmTextGrid("测试机2，上传软体异常");
                    //RecordAlarmString("测试机2，上传软体异常");
                    break;
                case "MsgRev: 测试机3，上传软体异常":
                    ShowAlarmTextGrid("测试机3，上传软体异常");
                    //RecordAlarmString("测试机3，上传软体异常");
                    break;
                case "MsgRev: 测试机4，上传软体异常":
                    ShowAlarmTextGrid("测试机4，上传软体异常");
                    //RecordAlarmString("测试机4，上传软体异常");
                    break;
                case "MsgRev: 耗材异常":
                    ShowAlarmTextGrid("耗材异常");
                    break;
                case "MsgRev: 黑色盘满，换盘":
                    ShowAlarmTextGrid("黑色盘满，换盘");
                    //RecordAlarmString("黑色盘满，换盘");
                    break;
                case "MsgRev: 红色盘满，换盘":
                    ShowAlarmTextGrid("红色盘满，换盘");
                    //RecordAlarmString("红色盘满，换盘");
                    break;
                case "MsgRev: A爪手掉料":
                    ShowAlarmTextGrid("A爪手掉料");
                    SaveAlarm("A爪手掉料");
                    break;
                case "MsgRev: B爪手掉料":
                    ShowAlarmTextGrid("B爪手掉料");
                    SaveAlarm("B爪手掉料");
                    break;
                case "MsgRev: 测试机1，良率异常":
                    ShowAlarmTextGrid("测试机1，良率异常");
                    //RecordAlarmString("测试机1，良率异常");
                    AdminButtonVisibility = "Visible";
                    break;
                case "MsgRev: 测试机2，良率异常":
                    ShowAlarmTextGrid("测试机2，良率异常");
                    //RecordAlarmString("测试机2，良率异常");
                    AdminButtonVisibility = "Visible";
                    break;
                case "MsgRev: 测试机3，良率异常":
                    ShowAlarmTextGrid("测试机3，良率异常");
                    //RecordAlarmString("测试机3，良率异常");
                    AdminButtonVisibility = "Visible";
                    break;
                case "MsgRev: 测试机4，良率异常":
                    ShowAlarmTextGrid("测试机4，良率异常");
                    //RecordAlarmString("测试机4，良率异常");
                    AdminButtonVisibility = "Visible";
                    break;
                case "MsgRev: 清洁操作，结束":
                    LastQingjie = System.DateTime.Now;
                    Inifile.INIWriteValue(iniParameterPath, "System", "LastQingjie", LastQingjie.ToString());
                    LastQingjieStr = LastQingjie.ToString();
                    AllowCleanActionCommand = true;
                    break;
                case "MsgRev: 测试机1，吸取失败，样本":
                    ShowAlarmTextGrid("放料，测试机1，样本吸取失败\n请将样本放回原位！");
                    //SaveAlarm("放料，测试机1，样本吸取失败");
                    break;
                case "MsgRev: 测试机2，吸取失败，样本":
                    ShowAlarmTextGrid("放料，测试机2，样本吸取失败\n请将样本放回原位！");
                    //SaveAlarm("放料，测试机2，样本吸取失败");
                    break;
                case "MsgRev: 测试机3，吸取失败，样本":
                    ShowAlarmTextGrid("放料，测试机3，样本吸取失败\n请将样本放回原位！");
                    //SaveAlarm("放料，测试机3，样本吸取失败");
                    break;
                case "MsgRev: 测试机4，吸取失败，样本":
                    ShowAlarmTextGrid("放料，测试机4，样本吸取失败\n请将样本放回原位！");
                    //SaveAlarm("放料，测试机4，样本吸取失败");
                    break;
                case "MsgRev: 测试机1，产品没放好，样本":
                    ShowAlarmTextGrid("放料，测试机1，样本没放好\n请将样本放好！");
                    //SaveAlarm("放料，测试机1，样本没放好");
                    break;
                case "MsgRev: 测试机2，产品没放好，样本":
                    ShowAlarmTextGrid("放料，测试机2，样本没放好\n请将样本放好！");
                    //SaveAlarm("放料，测试机2，样本没放好");
                    break;
                case "MsgRev: 测试机3，产品没放好，样本":
                    ShowAlarmTextGrid("放料，测试机3，样本没放好\n请将样本放好！");
                    //SaveAlarm("放料，测试机3，样本没放好");
                    break;
                case "MsgRev: 测试机4，产品没放好，样本":
                    ShowAlarmTextGrid("放料，测试机4，样本没放好\n请将样本放好！");
                    //SaveAlarm("放料，测试机4，样本没放好");
                    break;

                case "MsgRev: 测试机1，吸取失败，GRR":
                    ShowAlarmTextGrid("放料，测试机1，GRR吸取失败\n请将GRR放回原位！");
                    SaveAlarm("放料，测试机1，GRR吸取失败");
                    break;
                case "MsgRev: 测试机2，吸取失败，GRR":
                    ShowAlarmTextGrid("放料，测试机2，GRR吸取失败\n请将GRR放回原位！");
                    SaveAlarm("放料，测试机2，GRR吸取失败");
                    break;
                case "MsgRev: 测试机3，吸取失败，GRR":
                    ShowAlarmTextGrid("放料，测试机3，GRR吸取失败\n请将GRR放回原位！");
                    SaveAlarm("放料，测试机3，GRR吸取失败");
                    break;
                case "MsgRev: 测试机4，吸取失败，GRR":
                    ShowAlarmTextGrid("放料，测试机4，GRR吸取失败\n请将GRR放回原位！");
                    SaveAlarm("放料，测试机4，GRR吸取失败");
                    break;
                case "MsgRev: 测试机1，产品没放好，GRR":
                    ShowAlarmTextGrid("放料，测试机1，GRR没放好\n请将GRR放好！");
                    SaveAlarm("放料，测试机1，GRR没放好");
                    break;
                case "MsgRev: 测试机2，产品没放好，GRR":
                    ShowAlarmTextGrid("放料，测试机2，GRR没放好\n请将GRR放好！");
                    SaveAlarm("放料，测试机2，GRR没放好");
                    break;
                case "MsgRev: 测试机3，产品没放好，GRR":
                    ShowAlarmTextGrid("放料，测试机3，GRR没放好\n请将GRR放好！");
                    SaveAlarm("放料，测试机3，GRR没放好");
                    break;
                case "MsgRev: 测试机4，产品没放好，GRR":
                    ShowAlarmTextGrid("放料，测试机4，GRR没放好\n请将GRR放好！");
                    SaveAlarm("放料，测试机4，GRR没放好");
                    break;

                case "MsgRev: 测试机1，脏污报警":
                    ShowAlarmTextGrid("测试机1，脏污报警");
                    break;
                case "MsgRev: 测试机2，脏污报警":
                    ShowAlarmTextGrid("测试机2，脏污报警");
                    break;
                case "MsgRev: 测试机3，脏污报警":
                    ShowAlarmTextGrid("测试机3，脏污报警");
                    break;
                case "MsgRev: 测试机4，脏污报警":
                    ShowAlarmTextGrid("测试机4，脏污报警");
                    break;

                case "MsgRev: GRR测试，开始":
                    Tester.IsInGRRMode = true;
                    break;
                case "MsgRev: GRR测试，结束":
                    Tester.IsInGRRMode = false;
                    break;



                case "MsgRev: 样本测试，开始":
                    Tester.IsInSampleMode = true;
                    for (int i = 0; i < 32; i++)
                    {
                        SamArray[i / 4, i % 4] = "";
                    }
                    SamStart = DateTime.Now;

                    break;
                case "MsgRev: 样本测试，查询":
                    CheckSam();
                    break;
                case "MsgRev: 样本测试，结束":
                    Tester.IsInSampleMode = false;
          
                    LasSam = DateTime.Now;
                    LasSamStr = LasSam.ToString();
                    Inifile.INIWriteValue(iniParameterPath, "Sam", "LasSam", LasSam.ToString());
                    isSendSamCMD = false;
                    break;
                default:
                    break;
            }
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
        private void EPSONCommTwincatEventProcess(string str)
        {
            string[] strs = str.Split(',');
            switch (strs[0])
            {
                case "FMOVE":
                    FMoveProcessStart(TwinCatProcessStartCallback, strs[1]);
                    break;
                case "TMOVE":
                    TMoveProcessStart(TwinCatProcessStartCallback, strs[1]);
                    break;
                case "ULOAD":
                    Unloadsw.Restart();
                    ULoadProcessStart(TwinCatProcessStartCallback, strs[1]);
                    break;
                case "ResetCMD":
                    ResetCMDProcessStart(TwinCatProcessStartCallback);
                    break;
                default:
                    break;
            }
        }
        private async void MaterialEventProcess(string ss)
        {
            if (epsonRC90.TestSendStatus)
            {
                await epsonRC90.TestSentNet.SendAsync("StatusOfMaterial;" + MaterialStatus.ToString());
            }
        }
        private void DiaoLiaoEventProcess(string xitou)
        {
            liaooutput++;
            Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "liaooutput", liaooutput.ToString());
        }
        public delegate void TwinCatProcessedDelegate(string s);
        public async void FMoveProcessStart(TwinCatProcessedDelegate callback, string s)
        {
            Func<Task> startTask = () =>
            {
                return Task.Run(async () =>
                {
                    FCmdIndex.Value = ushort.Parse(s);
                    await Task.Delay(100);
                    FMoveCMD.Value = true;
                    FMoveCompleted.Value = false;

                    while (!(bool)FMoveCompleted.Value)
                    {
                        await Task.Delay(100);
                        if (EStop)
                        {
                            break;
                        }
                    }
                    if (!EStop)
                    {
                        callback("FMOVE;" + s);
                    }

                }
                );
            };
            await startTask();
        }
        public async void TMoveProcessStart(TwinCatProcessedDelegate callback, string s)
        {
            Func<Task> startTask = () =>
            {
                return Task.Run(async () =>
                {
                    TCmdIndex.Value = ushort.Parse(s);
                    await Task.Delay(100);
                    TMoveCMD.Value = true;
                    TMoveCompleted.Value = false;

                    while (!(bool)TMoveCompleted.Value)
                    {
                        await Task.Delay(100);
                        if (EStop)
                        {
                            break;
                        }
                    }
                    if (!EStop)
                    {
                        callback("TMOVE;" + s);
                    }

                }
                );
            };
            await startTask();
        }
        public async void ULoadProcessStart(TwinCatProcessedDelegate callback,string s)
        {
            ushort endnum;
            switch (MachineNum)
            {
                case "1372":
                    endnum = 14;
                    break;
                case "1373":
                    endnum = 14;
                    break;
                case "1374":
                    endnum = 24;
                    break;
                default:
                    endnum = 24;
                    break;
            }
            Func<Task> startTask = () =>
            {
                return Task.Run(() =>
                {
                    //try
                    //{
                    //    unloadreadindexflag = true;
                    //    ushort nextindex = ushort.Parse(s);
                    //    //Inifile.INIWriteValue(initestPath, "Other", "index", "-1");
                    //    string ReadIndex1 = Inifile.INIGetStringValue(initestPath, "Other", "index", "-1");
                    //    Inifile.INIWriteValue(initestPath, "Other", "trayrequest", "ask" + FlexId[nextindex]);
                    //    System.Threading.Thread.Sleep(200);
                    //    string ReadIndex = Inifile.INIGetStringValue(initestPath, "Other", "index" , "-1");
                    //    while (ReadIndex == ReadIndex1)
                    //    {
                    //        if (EStop)
                    //        {
                    //            unloadreadindexflag = false;
                    //            return;
                    //        }
                    //        System.Threading.Thread.Sleep(200);
                    //        ReadIndex = Inifile.INIGetStringValue(initestPath, "Other", "index", "-1");
                    //    }
                    //    unloadreadindexflag = false;
                    //    XYIndex.Value = ushort.Parse(ReadIndex) - 1;
                    //    if (ushort.Parse(ReadIndex) >= endnum)
                    //    {
                    //        Inifile.INIWriteValue(initestPath, "Other", "traychange", "Y");
                    //    }
                    //    System.Threading.Thread.Sleep(100);
                    //}
                    //catch (Exception ex)
                    //{
                    //    MsgText = AddMessage(ex.Message);
                    //}

                    TUnloadCMD.Value = true;
                    TUnloadCompleted.Value = false;

                    while (!(bool)TUnloadCompleted.Value)
                    {
                        System.Threading.Thread.Sleep(100);
                        if (EStop)
                        {
                            break;
                        }
                    }
                    if (!EStop)
                    {
                        callback("ULOAD");
                    }

                }
                );
            };
            await startTask();
        }
        public async void ResetCMDProcessStart(TwinCatProcessedDelegate callback)
        {
            Func<Task> startTask = () =>
            {
                return Task.Run(async () =>
                {
                    ResetCMD.Value = true;
                    ReadTwinCatDatafromIni();

                    while (!(bool)ResetCMDComplete.Value)
                    {
                        await Task.Delay(100);
                        if (EStop)
                        {
                            break;
                        }
                    }
                    if (!EStop)
                    {
                        callback("ResetCMD");
                    }

                }
                );
            };
            await startTask();
        }
        public async void TwinCatProcessStartCallback(string str)
        {
            if (epsonRC90.TestSendStatus)
            {
                await epsonRC90.TestSentNet.SendAsync(str);
            }
        }
        private async void DispatcherTimerTickUpdateUi(Object sender, EventArgs e)
        {
            #region PLC报警显示
            
            PLCMessageVisibility = "Collapsed";
            PLCMessage = "";
            string plsmsgstr = "";
            if (XinJieOut != null)
            {
                for (int i = 0; i < 50; i++)
                {
                    if (XinJieOut[50 + i])
                    {
                        switch (i)
                        {
                            case 0:
                                PLCMessage = "上料满盘缺料";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 1:
                                PLCMessage = "上料空盘满";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 2:
                                PLCMessage = "下料满盘满";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 3:
                                PLCMessage = "下料空盘缺";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 4:
                                PLCMessage = "上料吸空盘失败";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 5:
                                PLCMessage = "下料吸空盘失败";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 6:
                                PLCMessage = "上料空盘轴未准备好";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 7:
                                PLCMessage = "下料蓝盘轴未准备好";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 8:
                                PLCMessage = "上料无杆气缸置位超时";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 9:
                                PLCMessage = "上料无杆气缸复位超时";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 10:
                                PLCMessage = "上料上下气缸复位超时";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 11:
                                PLCMessage = "下料无杆气缸置位超时";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 12:
                                PLCMessage = "下料无杆气缸复位超时";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 13:
                                PLCMessage = "下料上下气缸复位超时";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 14:
                                PLCMessage = "上料满盘电机上升超时";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 15:
                                PLCMessage = "上料满盘电机下降超时";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 16:
                                PLCMessage = "上料空盘电机上升超时";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 17:
                                PLCMessage = "上料空盘电机下降超时";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 18:
                                PLCMessage = "下料满盘电机上升超时";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 19:
                                PLCMessage = "下料空盘电机下降超时";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 20:
                                PLCMessage = "下料满盘电机上升超时";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 21:
                                PLCMessage = "下料空盘电机下降超时";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 22:
                                PLCMessage = "下料XY吸取失败报警";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 23:
                                PLCMessage = "下料XY未准备好报警";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 33:
                                PLCMessage = "测试机良率超下限";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 24:
                                PLCMessage = "机械手暂停报警";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 34:
                                PLCMessage = "上料满盘未准备好";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 35:
                                PLCMessage = "上料盘漏吸料报警";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 36:
                                PLCMessage = "相机拍照超时";
                                PLCMessageVisibility = "Visible";
                                break;
                            case 32:
                                PLCMessage = "测试机被屏蔽";
                                PLCMessageVisibility = "Visible";
                                break;
                            default:
                                break;
                        }

                        break;
                    }

                }



            }


            PLCAlarmStatus = PLCMessageVisibility == "Visible" && (PLCMessage == "上料吸空盘失败" || PLCMessage == "下料吸空盘失败" || PLCMessage == "下料XY吸取失败报警");
            if (_PLCAlarmStatus != PLCAlarmStatus)
            {
                _PLCAlarmStatus = PLCAlarmStatus;
                if (plsmsgstr != PLCMessage && _PLCAlarmStatus && (PLCMessage == "上料吸空盘失败" || PLCMessage == "下料吸空盘失败" || PLCMessage == "下料XY吸取失败报警"))
                {
                    plsmsgstr = PLCMessage;
                    Inifile.INIWriteValue(iniFClient, "Alarm", "Name", PLCMessage);
                    //TotalAlarmNum++;
                    //Inifile.INIWriteValue(iniTimeCalcPath, "Alarm", "TotalAlarmNum", TotalAlarmNum.ToString());
                    //RecordAlarmString(PLCMessage);
                }

            }
            #endregion
            #region 及时雨
            if (++DecTick >= 6)
            {
                DecTick = 0;
                work_flag = DangbanFirstProduct == GetBanci();
                if (work_flag && !EpsonStatusPaused && !waitinput_flag)
                {
                    run_min += 0.1;
                    Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "run_min", run_min.ToString("F2"));
                }
                if (work_flag)
                {
                    work_min += 0.1;
                    Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "work_min", work_min.ToString("F2"));
                }
                if (down_flag)
                {
                    down_min += 0.1;
                    Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "down_min", down_min.ToString("F2"));
                }
                if (jigdown_flag)
                {
                    jigdown_min += 0.1;
                    Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "jigdown_min", jigdown_min.ToString("F2"));
                }
                if (waitinput_flag)
                {
                    waitinput_min += 0.1;
                    Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "waitinput_min", waitinput_min.ToString("F2"));
                }
                if (waittray_flag)
                {
                    waittray_min += 0.1;
                    Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "waittray_min", waittray_min.ToString("F2"));
                }
                if (waittake_flag)
                {
                    waittake_min += 0.1;
                    Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "waittake_min", waittake_min.ToString("F2"));
                }
                if (run_min == 0 || UPH == 0)
                    AchievingRate = 100;
                else
                    AchievingRate = Math.Round(liaooutput / ((double)UPH / 60 * run_min) * 100, 2);
                if (work_min == 0)
                {
                    ProperRate = 0;
                    ProperRate_AutoMation = 0;
                    ProperRate_Jig = 0;
                }
                else
                {
                    ProperRate = Math.Round((1 - (down_min + jigdown_min) / work_min) * 100, 2);
                    ProperRate_AutoMation = Math.Round((1 - down_min / work_min) * 100, 2);
                    ProperRate_Jig = Math.Round((1 - jigdown_min / work_min) * 100, 2);
                }

                if (AlarmTextGridShow != "Visible" && PLCMessageVisibility != "Visible")
                {
                    Inifile.INIWriteValue(iniFClient, "Alarm", "Name", "NULL");
                }
                Write及时雨();
            }
            #endregion
            #region 其他
            if (lockuiflag)
            {
                lockuiflag = false;
                LockUI();
            }
            if (++MinTick > 60)
            {
                MinTick = 0;
                ConnectDBTest();
            }
            if (Isloagin || !(LoginString != "登出"))
            {
                if (++loadintimes > 30)
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

            if (myAlarmRecordQueue.Count > 0)
            {
                lock (this)
                {
                    foreach (AlarmRecord item in myAlarmRecordQueue)
                    {
                        alarmRecord.Add(item);
                    }
                    myAlarmRecordQueue.Clear();
                }
            }
            if (myTestRecordQueue.Count > 0)
            {
                lock (this)
                {
                    foreach (TestRecord item in myTestRecordQueue)
                    {
                        testRecord.Add(item);
                    }
                    myTestRecordQueue.Clear();
                }
            }
            if (autoClean)
            {
                MsgText = AddMessage("换班，数据清零");
                alarmRecord.Clear();
                testRecord.Clear();
                for (int i = 0; i < 4; i++)
                {
                    epsonRC90.YanmadeTester[i].Clean();
                }

                run_min = 0;
                work_min = 0;
                down_min = 0;
                jigdown_min = 0;
                waitinput_min = 0;
                waittray_min = 0;
                waittake_min = 0;
                liaooutput = 0;
                liaoinput = 0;
                louliao = 0;
                TotalAlarmNum = 0;

                Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "run_min", run_min.ToString("F2"));
                Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "work_min", work_min.ToString("F2"));
                Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "down_min", down_min.ToString("F2"));
                Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "jigdown_min", jigdown_min.ToString("F2"));
                Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "waitinput_min", waitinput_min.ToString("F2"));
                Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "waittray_min", waittray_min.ToString("F2"));
                Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "waittake_min", waittake_min.ToString("F2"));
                Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "liaoinput", liaoinput.ToString());
                Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "louliao", louliao.ToString());
                Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "liaooutput", liaooutput.ToString());
                Inifile.INIWriteValue(iniTimeCalcPath, "Alarm", "TotalAlarmNum", TotalAlarmNum.ToString());











                //liaoinput = 0;

                autoClean = false;

            }
            TimeSpan ts = System.DateTime.Now - LastQingjie;
            if (AllowCleanActionCommand && ts.TotalHours > 2)
            {
                if (epsonRC90.TestSendStatus)
                {
                    await epsonRC90.TestSentNet.SendAsync("TestersCleanAction");
                    AllowCleanActionCommand = false;
                }
            }
            for (int i = 0; i < 32; i++)
            {
                SampleItemsStatus[i / 4 + i % 4 * 8] = SamArray[i / 4, i % 4];
            }

            DateTime SamStartDatetime,SamDate,SamDateBigin;
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                //上午
                SamStartDatetime = Convert.ToDateTime(DaySampleStartHour.ToString() + ":" + DaySampleStartMin.ToString() + ":00");
                SamDate = Convert.ToDateTime(DaySampleStartHour.ToString() + ":00:00");
                SamDateBigin = Convert.ToDateTime("06:00:00");
            }
            else
            {
                if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
                {
                    //下午
                    SamStartDatetime = Convert.ToDateTime(DaySampleStartHour1.ToString() + ":" + DaySampleStartMin1.ToString() + ":00");
                    SamDate = Convert.ToDateTime(DaySampleStartHour1.ToString() + ":00:00");
                    SamDateBigin = Convert.ToDateTime("12:00:00");
                }
                else
                {
                    if (DateTime.Now.Hour >= 18)
                    {
                        //前夜
                        SamStartDatetime = Convert.ToDateTime(NightSampleStartHour.ToString() + ":" + NightSampleStartMin.ToString() + ":00");
                        SamDate = Convert.ToDateTime(NightSampleStartHour.ToString() + ":00:00");
                        SamDateBigin = Convert.ToDateTime("18:00:00");
                    }
                    else
                    {
                        //后夜
                        SamStartDatetime = Convert.ToDateTime(NightSampleStartHour1.ToString() + ":" + NightSampleStartMin1.ToString() + ":00");
                        SamDate = Convert.ToDateTime(NightSampleStartHour1.ToString() + ":00:00");
                        SamDateBigin = Convert.ToDateTime("00:00:00");
                    }
                }
                ////夜班
                //if (DateTime.Now.Hour >= 20)
                //{
                //    SamStartDatetime = Convert.ToDateTime(NightSampleStartHour.ToString() + ":" + NightSampleStartMin.ToString() + ":00");
                //    SamDate = Convert.ToDateTime(NightSampleStartHour.ToString() + ":00:00");
                //}
                //else
                //{

                //    SamStartDatetime = Convert.ToDateTime(DateTime.Now.Date.AddDays(-1).ToString("yyyy/MM/dd") + " " + NightSampleStartHour.ToString() + ":" + NightSampleStartMin.ToString() + ":00");
                //    SamDate = Convert.ToDateTime(DateTime.Now.Date.AddDays(-1).ToString("yyyy/MM/dd") + " " + NightSampleStartHour.ToString() + ":00:00");
                //}
            }
            SamStart_ = SamStartDatetime.ToString();
            SamStart_H = SamDate.ToString();
            SamStart_Begin = SamDateBigin.ToString();
            //Console.WriteLine(SamStartDatetime);
            SampleTextGridVisibility = (DateTime.Now - SamDate).TotalSeconds > 0 && (SamDateBigin - LasSam).TotalSeconds > 0 && IsSamTest || Tester.IsInSampleMode || Tester.IsInGRRMode ? "Visible" : "Collapsed";
            if ((DateTime.Now - SamDate).TotalSeconds > 0 && (SamDateBigin - LasSam).TotalSeconds > 0)
            {
                SamMessage = "请测样本";
            }
            if (Tester.IsInSampleMode)
            {
                SamMessage = "样本测试中...";
            }
            else
            {
                if ((DateTime.Now - SamStartDatetime).TotalSeconds > 0 && SamMessage == "请测样本" && (SamDateBigin - LasSam).TotalSeconds > 0 && IsSamTest && !isSendSamCMD && epsonRC90.TestSendStatus && EpsonStatusRunning)
                {
                    isSendSamCMD = true;
                    ShowSampleTestWindow = !ShowSampleTestWindow;
                    if (epsonRC90.TestSendStatus)
                    {
                        await epsonRC90.TestSentNet.SendAsync("GONOGOAction;" + SampleNgitemsNum.ToString());
                    }

                }
                else
                {
                    if (Tester.IsInGRRMode)
                    {
                        SamMessage = "GRR测试中...";
                    }
                }
              
                
            }
            if (haocaiinit && GlobalVar.Worksheet != null)
            {
                for (int i = 0; i < 4; i++)
                {
                    GlobalVar.Worksheet.Cells[i * 2 + 3, 3].Value = FlexId[i];
                    GlobalVar.Worksheet.Cells[i * 2 + 1 + 3, 3].Value = FlexId[i];
                    GlobalVar.Worksheet.Cells[i * 2 + 3, 2].Value = MNO;
                    GlobalVar.Worksheet.Cells[i * 2 + 1 + 3, 2].Value = MNO;
                    MaterialChangeItemsSource.Add((string)GlobalVar.Worksheet.Cells[i * 2 + 3, 1].Value + "," + FlexId[i]);
                    MaterialChangeItemsSource.Add((string)GlobalVar.Worksheet.Cells[i * 2 + 3 + 1, 1].Value + "," + FlexId[i]);
                }
                for (int i = 0; i < 6; i++)
                {
                    GlobalVar.Worksheet.Cells[i + 11, 3].Value = "NA";
                    GlobalVar.Worksheet.Cells[i + 11, 2].Value = MNO;
                    MaterialChangeItemsSource.Add((string)GlobalVar.Worksheet.Cells[i + 11, 1].Value + "," + "NA");
                }
                for (int i = 1; i <= GlobalVar.Worksheet.Dimension.End.Column; i++)
                {
                    GlobalVar.Mdt.Columns.Add((string)GlobalVar.Worksheet.Cells[2, i].Value);
                }
                MaterialSelectedIndex = 0;
                haocaiinit = false;
                try
                {
                    GlobalVar.Package.Save();
                }
                catch (Exception ex)
                {

                    MsgText = AddMessage(ex.Message);
                }
            }
            if (GlobalVar.Worksheet != null)
            {
                GlobalVar.Mdt.Clear();
                for (int i = 3; i <= GlobalVar.Worksheet.Dimension.End.Row; i++)
                {
                    DataRow dr = GlobalVar.Mdt.NewRow();
                    for (int j = 1; j <= GlobalVar.Worksheet.Dimension.End.Column; j++)
                    {
                        dr[j - 1] = GlobalVar.Worksheet.Cells[i, j].Value;
                    }
                    GlobalVar.Mdt.Rows.Add(dr);
                }
                MaterialStatus = 0;
                for (int i = 3; i <= GlobalVar.Worksheet.Dimension.End.Row; i++)
                {
                    try
                    {
                        if (Convert.ToInt32(GlobalVar.Worksheet.Cells[i, 6].Value) > Convert.ToInt32(GlobalVar.Worksheet.Cells[i, 4].Value))
                        {
                            MatetialMessage = (string)GlobalVar.Worksheet.Cells[i, 1].Value + "," + (string)GlobalVar.Worksheet.Cells[i, 3].Value + " 使用寿命到达上限";
                            MaterialStatus = 2;
                            break;
                        }
                        else
                        {
                            if (Convert.ToInt32(GlobalVar.Worksheet.Cells[i, 6].Value) > Convert.ToInt32(GlobalVar.Worksheet.Cells[i, 5].Value))
                            {
                                MatetialMessage = (string)GlobalVar.Worksheet.Cells[i, 1].Value + "," + (string)GlobalVar.Worksheet.Cells[i, 3].Value + " 使用寿命预警";
                                MaterialStatus = 1;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MatetialMessage = ex.Message;
                        MaterialStatus = 2;
                        MsgText = AddMessage(ex.Message);
                    }

                }
                if (haocaisavetimes++ > 10)
                {
                    haocaisavetimes = 0;
                    try
                    {
                        GlobalVar.Package.Save();
                    }
                    catch (Exception ex)
                    {
                        MsgText = AddMessage(ex.Message);

                    }
                }
            }

            switch (MaterialStatus)
            {
                case 0:

                    MatetialTextGridVisibility = "Collapsed";
                    break;
                case 1:
                    MatetialTextGridBackground = "Violet";
                    MatetialTextGridVisibility = "Visible";
                    break;
                case 2:
                    MatetialTextGridBackground = "Red";
                    MatetialTextGridVisibility = "Visible";
                    break;
                default:
                    break;
            }
            if (!unloadreadindexflag)
            {
                ushort endnum;
                switch (MachineNum)
                {
                    case "1372":
                        endnum = 14;
                        break;
                    case "1373":
                        endnum = 14;
                        break;
                    case "1374":
                        endnum = 24;
                        break;
                    default:
                        endnum = 24;
                        break;
                }
                index_ini = Inifile.INIGetStringValue(initestPath, "Other", "index", "0");
                if (index_ini != index_ini_old)
                {
                    try
                    {
                        if (ushort.Parse(index_ini_old) < endnum - 1 && index_ini == "0")
                        {
                            NeedUpdateTray.Value = true;
                        }
                    }
                    catch 
                    {

                        
                    }

                    index_ini_old = index_ini;
                }
            }

            #endregion

        }
        private void StartUpdateProcess(int index,string bar,string rst,string cyc,bool isRecord)
        {            
            TestRecord tr = new TestRecord(DateTime.Now.ToString(), bar, rst, cyc + " s", index.ToString());
            lock (this)
            {
                myTestRecordQueue.Enqueue(tr);
            }
            SaveCSVfileRecord(tr);
            if (isRecord && !Tester.IsInSampleMode && !Tester.IsInGRRMode)
            {
                if (epsonRC90.YanmadeTester[index - 1].TestSpan > 5)
                {
                    epsonRC90.YanmadeTester[index - 1].UpdateNormalWithTestTimes(rst);
                }
                else
                {
                    MsgText = AddMessage(bar + " 测试时间小于5秒，不纳入良率统计");
                }    
            }
            else
            {
                if (!isRecord && !Tester.IsInSampleMode && !Tester.IsInGRRMode)
                {
                    MsgText = AddMessage(bar + " 测试次数大于3次，不纳入良率统计");
                }
            }
            try
            {
                GlobalVar.Worksheet.Cells[(index - 1) * 2 + 3, 6].Value = Convert.ToInt32(GlobalVar.Worksheet.Cells[(index - 1) * 2 + 3, 6].Value) + 1;
                GlobalVar.Worksheet.Cells[(index - 1) * 2 + 1 + 3, 6].Value = Convert.ToInt32(GlobalVar.Worksheet.Cells[(index - 1) * 2 + 1 + 3, 6].Value) + 1;
            }
            catch (Exception ex)
            {
                MsgText = AddMessage(ex.Message);
            }

        }
        private void SamMessageProcess(int rund,int level,int flex)
        {
            //SamOrderList.Add(new int[4] { 0, 1, 2, 3 });
            //SamOrderList.Add(new int[4] { 3, 0, 1, 2 });
            //SamOrderList.Add(new int[4] { 2, 3, 0, 1 });
            //SamOrderList.Add(new int[4] { 1, 2, 3, 0 });
            SamArray[rund * 4 + SamOrderList[level][flex], flex] = "ok";
        }
        private void SamReMessageProcess(int ngitem, int flex)
        {
            SamArray[ngitem, flex] = "ok";
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
            bool restarfirstinit = true, _UnloadTrayFinish = true;
            
            Unloadsw.Start();
            while (true)
            {
                System.Threading.Thread.Sleep(10);
                if (IsPLCConnect)
                {
                    try
                    {
                        #region 初始化赋值


                        if (restarfirstinit)
                        {
                            System.Threading.Thread.Sleep(100);
                            _UnloadTrayFinish = XinJieOut[9];
                            restarfirstinit = false;
                        }
                        #endregion
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

                        PanTopFlag.Value = XinJieOut[20];

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

                        BFO11.Value = epsonRC90.Rc90Out[34];
                        BFO12.Value = epsonRC90.Rc90Out[35];
                        BFO13.Value = epsonRC90.Rc90Out[36];
                        BFO16.Value = epsonRC90.Rc90Out[37];
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

                        IsTCPConnect = epsonRC90.TestSendStatus & epsonRC90.TestReceiveStatus & epsonRC90.MsgReceiveStatus & epsonRC90.IOReceiveStatus & epsonRC90.CtrlStatus;

                        EStop = XinJieOut[25];//急停信号
                        SuckCMD.Value = XinJieOut[8];//上料准备好
                        TRAYEmpty.Value = XinJieOut[11];//上料盘空
                        RollReset.Value = epsonRC90.Rc90Out[1];
                        RollSet.Value = epsonRC90.Rc90Out[0];

                        double ps = (double)WaitPositionY.Value < (double)PickPositionY.Value ? (double)WaitPositionY.Value : (double)PickPositionY.Value;
                        XinJieIn[18] = (double)YPos.Value > ps - 1 && (bool)XYStared.Value;

                        XinJieIn[16] = (bool)EmptyCMD.Value;
                        XinJieIn[17] = (bool)UnloadTrayCMD.Value;
                        XinJieIn[19] = (bool)PLCPreSuck.Value;
                        XinJieIn[21] = (bool)SuckFailedFlag.Value;
                        XinJieIn[22] = (bool)M1202_1.Value;

                        XinJieIn[38] = EpsonStatusPaused;

                        XinJieIn[39] = epsonRC90.Rc90Out[8];
                        XinJieIn[40] = epsonRC90.Rc90Out[22];
                        XinJieIn[41] = epsonRC90.Rc90Out[23];
                        XinJieIn[42] = epsonRC90.Rc90Out[24];
                        XinJieIn[43] = epsonRC90.Rc90Out[25];
                        XinJieIn[44] = epsonRC90.Rc90Out[26];
                        XinJieIn[45] = epsonRC90.Rc90Out[27];

                        XinJieIn[47] = AdminButtonVisibility == "Visible";
                        XinJieIn[46] = !TestCheckedAL || !TestCheckedBL;

                        XinJieIn[48] = (bool)ProductLostAlarmFlag.Value;
                        XinJieIn[49] = (bool)PhotoTimeoutFlag.Value;

                        InputSafedoorFlag.Value = XinJieOut[31];
                        OutputSafedoorFlag.Value = XinJieOut[32];
                        epsonRC90.Rc90In[15] = XinJieOut[31];

                        green_flicker = XinJieOut[33];
                        yellow_normal = XinJieOut[34];
                        yellow_flicker = XinJieOut[35];
                        red_normal = XinJieOut[36];
                        green_normal = XinJieOut[37];


                        if (XinJieOut[37] && !Tester.IsInSampleMode && !Tester.IsInGRRMode)
                        {
                            if (Unloadsw.Elapsed.TotalMinutes >= 3)
                            {
                                EpsonOpetate(2);
                                ShowAlarmTextGrid("3分钟未产出");
                                Unloadsw.Restart();
                            }                        
                        }
                        else
                        {
                            Unloadsw.Restart();
                        }


                        if (green_normal)
                        {
                            signal_lamp = 1;
                        }
                        if (green_flicker)
                        {
                            signal_lamp = 2;
                        }
                        if (yellow_normal)
                        {
                            signal_lamp = 3;
                        }
                        if (yellow_flicker)
                        {
                            signal_lamp = 4;
                        }
                        if (red_normal)
                        {
                            signal_lamp = 5;
                        }

                        XinJieIn[50] = !TestCheckedAL; XinJieIn[51] = !TestCheckedBL;

                        UnloadTrayFinish.Value = XinJieOut[9];
                        if (_UnloadTrayFinish != XinJieOut[9])
                        {
                            _UnloadTrayFinish = XinJieOut[9];
                            if (!_UnloadTrayFinish && (ushort)XYIndex.Value != 0)
                            {
                                //Inifile.INIWriteValue(initestPath, "Other", "traychange", "Y");
                                MsgText = AddMessage("下料，换盘");
                            }

                        }

                        M1202.Value = XinJieOut[10];

                        epsonRC90.Rc90In[3] = XinJieOut[14] && (bool)WaitCmd1.Value;//自动排料
                        epsonRC90.Rc90In[2] = (bool)CloseCMD.Value;

                        if (IsPLCConnect)
                        {
                            M20027 = XinJieOut[27] ? "Visible" : "Collapsed";
                            M20028 = XinJieOut[28] ? "Visible" : "Collapsed";
                            M20029 = XinJieOut[29] ? "Visible" : "Collapsed";
                            M20030 = XinJieOut[30] ? "Visible" : "Collapsed";
                        }
                        down_flag = XinJieOut[21] || EpsonStatusEStop;
                        waitinput_flag = XinJieOut[15] || (!EpsonStatusSafeGuard && EpsonStatusPaused);
                        jigdown_flag = !TestCheckedAL || !TestCheckedBL || XinJieOut[22];
                        waittray_flag = XinJieOut[16];
                        waittake_flag = XinJieOut[17];
                        #endregion
                        #region 任务
                        if ((bool)PhotoCMD.Value)
                        {
                            PhotoCMD.Value = false;
                            MsgText = AddMessage("开始拍照 自动");
                            Async.RunFuncAsync(cameraHcInspect, TakePhoteCallback);

                        }
                        if (CameraPageVisibility == "Visible")
                        {
                            isUpdateImage = true;
                        }
                        string banci = GetBanci();
                        if (banci != LastBanci)
                        {
                            LastBanci = banci;
                            Inifile.INIWriteValue(iniParameterPath, "System", "Banci", LastBanci);
                            autoClean = true;
                        }
                        if (XinJieOut[26])
                        {
                            BFO5.Value = !EpsonStatusPaused;
                        }
                        if (shangLiaoFlag != (bool)ShangLiaoFlag.Value)
                        {
                            shangLiaoFlag = (bool)ShangLiaoFlag.Value;
                            if (shangLiaoFlag)
                            {
                                liaoinput += uint.Parse(ShangLiao.Value.ToString());
                                Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "liaoinput", liaoinput.ToString());
                                //LouLiaoCount
                                louliao += uint.Parse(LouLiaoCount.Value.ToString());
                                Inifile.INIWriteValue(iniTimeCalcPath, "Summary", "louliao", louliao.ToString());
                                try
                                {
                                    GlobalVar.Worksheet.Cells[13, 6].Value = Convert.ToInt32(GlobalVar.Worksheet.Cells[13, 6].Value) + 1;
                                }
                                catch (Exception ex)
                                {

                                    MsgText = AddMessage(ex.Message);
                                }


                            }
                        }
                        if (loadsuckFlag != XinJieOut[18])
                        {
                            loadsuckFlag = XinJieOut[18];
                            if (loadsuckFlag)
                            {
                                try
                                {
                                    GlobalVar.Worksheet.Cells[14, 6].Value = Convert.ToInt32(GlobalVar.Worksheet.Cells[14, 6].Value) + 1;
                                }
                                catch (Exception ex)
                                {

                                    MsgText = AddMessage(ex.Message);
                                }
                            }
                        }
                        if (unloadsuckFlag != XinJieOut[19])
                        {
                            unloadsuckFlag = XinJieOut[19];
                            if (unloadsuckFlag)
                            {
                                try
                                {
                                    GlobalVar.Worksheet.Cells[16, 6].Value = Convert.ToInt32(GlobalVar.Worksheet.Cells[16, 6].Value) + 1;
                                }
                                catch (Exception ex)
                                {

                                    MsgText = AddMessage(ex.Message);
                                }
                            }
                        }
                        if (_bfo2 != (bool)BFO2.Value)
                        {
                            _bfo2 = (bool)BFO2.Value;
                            if (_bfo2)
                            {
                                try
                                {
                                    GlobalVar.Worksheet.Cells[15, 6].Value = Convert.ToInt32(GlobalVar.Worksheet.Cells[15, 6].Value) + 1;
                                }
                                catch (Exception ex)
                                {

                                    MsgText = AddMessage(ex.Message);
                                }
                            }
                        }
                        Light_Alarm.Value = AlarmTextGridShow == "Visible" && EpsonStatusPaused;
                        #endregion
                        #region 界面数据显示
                        //良率界面显示
                        string[] Yieldstrs1 = PassStatusProcess(epsonRC90.YanmadeTester[0].Yield_Nomal);
                        PassStatusDisplay1 = "测试机1" + Yieldstrs1[0];
                        PassStatusColor1 = Yieldstrs1[1];
                        string[] Yieldstrs2 = PassStatusProcess(epsonRC90.YanmadeTester[1].Yield_Nomal);
                        PassStatusDisplay2 = "测试机2" + Yieldstrs2[0];
                        PassStatusColor2 = Yieldstrs2[1];
                        string[] Yieldstrs3 = PassStatusProcess(epsonRC90.YanmadeTester[2].Yield_Nomal);
                        PassStatusDisplay3 = "测试机3" + Yieldstrs3[0];
                        PassStatusColor3 = Yieldstrs3[1];
                        string[] Yieldstrs4 = PassStatusProcess(epsonRC90.YanmadeTester[3].Yield_Nomal);
                        PassStatusDisplay4 = "测试机4" + Yieldstrs4[0];
                        PassStatusColor4 = Yieldstrs4[1];

                        TesterResult0 = epsonRC90.YanmadeTester[0].TestResult.ToString();
                        switch (TesterResult0)
                        {
                            case "Ng":
                                TesterStatusBackGround0 = "Red";
                                TesterStatusForeground0 = "White";
                                break;
                            case "Pass":
                                TesterStatusBackGround0 = "Green";
                                TesterStatusForeground0 = "White";
                                break;
                            case "Unknow":
                                TesterStatusBackGround0 = "Wheat";
                                TesterStatusForeground0 = "Yellow";
                                break;
                            case "TimeOut":
                                TesterStatusBackGround0 = "Wheat";
                                TesterStatusForeground0 = "Maroon";
                                break;
                            default:
                                break;
                        }
                        TesterResult1 = epsonRC90.YanmadeTester[1].TestResult.ToString();
                        switch (TesterResult1)
                        {
                            case "Ng":
                                TesterStatusBackGround1 = "Red";
                                TesterStatusForeground1 = "White";
                                break;
                            case "Pass":
                                TesterStatusBackGround1 = "Green";
                                TesterStatusForeground1 = "White";
                                break;
                            case "Unknow":
                                TesterStatusBackGround1 = "Wheat";
                                TesterStatusForeground1 = "Yellow";
                                break;
                            case "TimeOut":
                                TesterStatusBackGround1 = "Wheat";
                                TesterStatusForeground1 = "Maroon";
                                break;
                            default:
                                break;
                        }
                        TesterResult2 = epsonRC90.YanmadeTester[2].TestResult.ToString();
                        switch (TesterResult2)
                        {
                            case "Ng":
                                TesterStatusBackGround2 = "Red";
                                TesterStatusForeground2 = "White";
                                break;
                            case "Pass":
                                TesterStatusBackGround2 = "Green";
                                TesterStatusForeground2 = "White";
                                break;
                            case "Unknow":
                                TesterStatusBackGround2 = "Wheat";
                                TesterStatusForeground2 = "Yellow";
                                break;
                            case "TimeOut":
                                TesterStatusBackGround2 = "Wheat";
                                TesterStatusForeground2 = "Maroon";
                                break;
                            default:
                                break;
                        }
                        TesterResult3 = epsonRC90.YanmadeTester[3].TestResult.ToString();
                        switch (TesterResult3)
                        {
                            case "Ng":
                                TesterStatusBackGround3 = "Red";
                                TesterStatusForeground3 = "White";
                                break;
                            case "Pass":
                                TesterStatusBackGround3 = "Green";
                                TesterStatusForeground3 = "White";
                                break;
                            case "Unknow":
                                TesterStatusBackGround3 = "Wheat";
                                TesterStatusForeground3 = "Yellow";
                                break;
                            case "TimeOut":
                                TesterStatusBackGround3 = "Wheat";
                                TesterStatusForeground3 = "Maroon";
                                break;
                            default:
                                break;
                        }
                        //时间统计
                        TestTime0 = epsonRC90.YanmadeTester[0].TestSpan;
                        TestTime1 = epsonRC90.YanmadeTester[1].TestSpan;
                        TestTime2 = epsonRC90.YanmadeTester[2].TestSpan;
                        TestTime3 = epsonRC90.YanmadeTester[3].TestSpan;
                        TestIdle0 = epsonRC90.YanmadeTester[0].TestIdle;
                        TestIdle1 = epsonRC90.YanmadeTester[1].TestIdle;
                        TestIdle2 = epsonRC90.YanmadeTester[2].TestIdle;
                        TestIdle3 = epsonRC90.YanmadeTester[3].TestIdle;
                        TestCycle0 = epsonRC90.YanmadeTester[0].TestCycle;
                        TestCycle1 = epsonRC90.YanmadeTester[1].TestCycle;
                        TestCycle2 = epsonRC90.YanmadeTester[2].TestCycle;
                        TestCycle3 = epsonRC90.YanmadeTester[3].TestCycle;

                        TestCycleAve = Math.Round((TestCycle0 + TestCycle1 + TestCycle2 + TestCycle3) / 4, 2);
                        #endregion

                    }
                    catch (Exception ex)
                    {


                    }
                }


            }
        }
        void Write及时雨()
        {
            TestCount_1 = epsonRC90.YanmadeTester[0].TestCount_Nomal.ToString();
            Yield_1 = epsonRC90.YanmadeTester[0].Yield_Nomal.ToString();
            PassCount_1 = epsonRC90.YanmadeTester[0].PassCount_Nomal.ToString();
            TestCount_2 = epsonRC90.YanmadeTester[1].TestCount_Nomal.ToString();
            Yield_2 = epsonRC90.YanmadeTester[1].Yield_Nomal.ToString();
            PassCount_2 = epsonRC90.YanmadeTester[1].PassCount_Nomal.ToString();
            TestCount_3 = epsonRC90.YanmadeTester[2].TestCount_Nomal.ToString();
            Yield_3 = epsonRC90.YanmadeTester[2].Yield_Nomal.ToString();
            PassCount_3 = epsonRC90.YanmadeTester[2].PassCount_Nomal.ToString();
            TestCount_4 = epsonRC90.YanmadeTester[3].TestCount_Nomal.ToString();
            Yield_4 = epsonRC90.YanmadeTester[3].Yield_Nomal.ToString();
            PassCount_4 = epsonRC90.YanmadeTester[3].PassCount_Nomal.ToString();
            //TestCount_Total = (epsonRC90.YanmadeTester[0].TestCount_Nomal + epsonRC90.YanmadeTester[1].TestCount_Nomal + epsonRC90.YanmadeTester[2].TestCount_Nomal + epsonRC90.YanmadeTester[3].TestCount_Nomal).ToString();
            TestCount_Total = liaoinput.ToString();
            TestCount_Total1 = (epsonRC90.YanmadeTester[0].PassCount + epsonRC90.YanmadeTester[1].PassCount + epsonRC90.YanmadeTester[2].PassCount + epsonRC90.YanmadeTester[3].PassCount).ToString();
            LouxiliaoCount = louliao.ToString();

            Inifile.INIWriteValue(iniFClient, "DataList", "TestCount_1", epsonRC90.YanmadeTester[0].TestCount_Nomal.ToString());
            Inifile.INIWriteValue(iniFClient, "DataList", "Yield_1", epsonRC90.YanmadeTester[0].Yield_Nomal.ToString());
            Inifile.INIWriteValue(iniFClient, "DataList", "TestCount_2", epsonRC90.YanmadeTester[1].TestCount_Nomal.ToString());
            Inifile.INIWriteValue(iniFClient, "DataList", "Yield_2", epsonRC90.YanmadeTester[1].Yield_Nomal.ToString());
            Inifile.INIWriteValue(iniFClient, "DataList", "TestCount_3", epsonRC90.YanmadeTester[2].TestCount_Nomal.ToString());
            Inifile.INIWriteValue(iniFClient, "DataList", "Yield_3", epsonRC90.YanmadeTester[2].Yield_Nomal.ToString());
            Inifile.INIWriteValue(iniFClient, "DataList", "TestCount_4", epsonRC90.YanmadeTester[3].TestCount_Nomal.ToString());
            Inifile.INIWriteValue(iniFClient, "DataList", "Yield_4", epsonRC90.YanmadeTester[3].Yield_Nomal.ToString());

            Downtime = down_min.ToString("F1");
            Jigdowntime = jigdown_min.ToString("F1");
            Waitforinput = waitinput_min.ToString("F1");
            Waitfortray = waittray_min.ToString("F1");
            Waitfortake = waittake_min.ToString("F1");

            Inifile.INIWriteValue(iniFClient, "DataList", "Downtime ", down_min.ToString("F2"));
            Inifile.INIWriteValue(iniFClient, "DataList", "Jigdowntime ", jigdown_min.ToString("F2"));
            Inifile.INIWriteValue(iniFClient, "DataList", "Waitforinput", waitinput_min.ToString("F2"));
            Inifile.INIWriteValue(iniFClient, "DataList", "Waitfortray", waittray_min.ToString("F2"));
            Inifile.INIWriteValue(iniFClient, "DataList", "Waitfortake", waittake_min.ToString("F2"));
            Inifile.INIWriteValue(iniFClient, "DataList", "TestCount_Total", (epsonRC90.YanmadeTester[0].TestCount_Nomal + epsonRC90.YanmadeTester[1].TestCount_Nomal + epsonRC90.YanmadeTester[2].TestCount_Nomal + epsonRC90.YanmadeTester[3].TestCount_Nomal).ToString());
            Inifile.INIWriteValue(iniFClient, "DataList", "input", liaoinput.ToString());
            Inifile.INIWriteValue(iniFClient, "DataList", "output", liaooutput.ToString());
            //if (epsonRC90.YanmadeTester[0].TestCount_Nomal + epsonRC90.YanmadeTester[1].TestCount_Nomal + epsonRC90.YanmadeTester[2].TestCount_Nomal + epsonRC90.YanmadeTester[3].TestCount_Nomal > 0)
            //{
            //    Yield_Total = ((double)(epsonRC90.YanmadeTester[0].PassCount_Nomal + epsonRC90.YanmadeTester[1].PassCount_Nomal + epsonRC90.YanmadeTester[2].PassCount_Nomal + epsonRC90.YanmadeTester[3].PassCount_Nomal) / (epsonRC90.YanmadeTester[0].TestCount_Nomal + epsonRC90.YanmadeTester[1].TestCount_Nomal + epsonRC90.YanmadeTester[2].TestCount_Nomal + epsonRC90.YanmadeTester[3].TestCount_Nomal) * 100).ToString("F2");
            //    Inifile.INIWriteValue(iniFClient, "DataList", "Yield_Total", ((double)(epsonRC90.YanmadeTester[0].PassCount_Nomal + epsonRC90.YanmadeTester[1].PassCount_Nomal + epsonRC90.YanmadeTester[2].PassCount_Nomal + epsonRC90.YanmadeTester[3].PassCount_Nomal) / (epsonRC90.YanmadeTester[0].TestCount_Nomal + epsonRC90.YanmadeTester[1].TestCount_Nomal + epsonRC90.YanmadeTester[2].TestCount_Nomal + epsonRC90.YanmadeTester[3].TestCount_Nomal) * 100).ToString("F2"));
            //}
            //else
            //{
            //    Yield_Total = "0";
            //    Inifile.INIWriteValue(iniFClient, "DataList", "Yield_Total", "0");
            //}
            if (liaoinput > 0)
            {
                if ((double)(epsonRC90.YanmadeTester[0].PassCount + epsonRC90.YanmadeTester[1].PassCount + epsonRC90.YanmadeTester[2].PassCount + epsonRC90.YanmadeTester[3].PassCount) < liaoinput)
                {
                    Yield_Total = ((double)(epsonRC90.YanmadeTester[0].PassCount + epsonRC90.YanmadeTester[1].PassCount + epsonRC90.YanmadeTester[2].PassCount + epsonRC90.YanmadeTester[3].PassCount) / liaoinput * 100).ToString("F2");
                }
                else
                {
                    Yield_Total = "100";
                }
                Inifile.INIWriteValue(iniFClient, "DataList", "Yield_Total", Yield_Total);
            }
            else
            {
                Yield_Total = "0";
                Inifile.INIWriteValue(iniFClient, "DataList", "Yield_Total", "0");
            }

            AchievingRate_ = AchievingRate.ToString("F2");
            ProperRate_ = ProperRate.ToString("F2");
            ProperRate_AutoMation_ = ProperRate_AutoMation.ToString("F2");
            ProperRate_Jig_ = ProperRate_Jig.ToString("F2");
            Inifile.INIWriteValue(iniFClient, "Alarm", "count", TotalAlarmNum.ToString());
            Inifile.INIWriteValue(iniFClient, "DataList", "AchievingRate", AchievingRate.ToString("F2"));
            Inifile.INIWriteValue(iniFClient, "DataList", "ProperRate", ProperRate.ToString("F2"));
            Inifile.INIWriteValue(iniFClient, "DataList", "ProperRate_AutoMation", ProperRate_AutoMation.ToString("F2"));
            Inifile.INIWriteValue(iniFClient, "DataList", "ProperRate_Jig", ProperRate_Jig.ToString("F2"));
            Inifile.INIWriteValue(iniAlarmPath, "Alarm", "TotalAlarmNum", TotalAlarmNum.ToString());
            //string line = Inifile.INIGetStringValue(initestPath, "Other", "line", "L1");
            Inifile.INIWriteValue(iniParameterPath, "Sample", "MNO", MNO);


            Inifile.INIWriteValue(iniFClient, "state", "state", signal_lamp.ToString());

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
        async void LockUI()
        {
            GlobalVar.metro.ChangeAccent("Red");
            while (true)
            {
                string rr = await GlobalVar.metro.ShowLoginOnlyPassword("样本测试错误，锁机！");
                string ss = GetPassWord();
                if (rr == ss)
                {
                    break;
                }
            }
            GlobalVar.metro.ChangeAccent("Blue");
        }
        #endregion
        #region 数据库
        private void ConnectDBTest()
        {
            try
            {
                OraDB oraDB = new OraDB("zdtdb", "ictdata", "ictdata*168");
                if (oraDB.isConnect())
                {
                    string dbtime = oraDB.sfc_getServerDateTime();
                    setLocalTime(dbtime);

                    IsDBConnect = true;
                }
                else
                {
                    MsgText = AddMessage("数据库未连接");

                    IsDBConnect = false;
                }
                oraDB.disconnect();
            }
            catch (Exception ex)
            {
                MsgText = AddMessage(ex.Message);
                IsDBConnect = false;
            }
        }
        private void setLocalTime(string strDateTime)
        {
            DateTimeUtility.SYSTEMTIME st = new DateTimeUtility.SYSTEMTIME();
            DateTime dt = Convert.ToDateTime(strDateTime);
            st.FromDateTime(dt);
            DateTimeUtility.SetLocalTime(ref st);
        }
        private async void CheckSam()
        {
            bool flag = true;
            for (int i = 0; i < SampleNgitemsNum; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    string flex = Inifile.INIGetStringValue(initestPath, "A", "id" + (j + 1).ToString(), "0");
                    SamArray[i, j] = CheckfromDt(flex, SampleNgitem[i], DateTime.Now.ToString("yyyyMMdd"));
                    if (SamArray[i, j] == "Limit")
                    {
                        if (flag)
                        {
                            flag = false;
                            lockuiflag = true;
                            EpsonOpetate(2);
                        }

                    }
                    if (SamArray[i, j] != "ok" && SamArray[i, j] != "")
                    {
                        if (epsonRC90.TestSendStatus)
                        {
                            await epsonRC90.TestSentNet.SendAsync("SamReFlag;" + (j + 1).ToString() + ";" + (i + 1).ToString());
                        }
                        await Task.Delay(100);
                    }
                }
            }
            if (epsonRC90.TestSendStatus)
            {
                await epsonRC90.TestSentNet.SendAsync("SamCheckFinish");
            }

        }
        private string CheckfromDt(string flexnum,string ngitem,string date)
        {
            try
            {
                OraDB oraDB = new OraDB("zdtdb", "ictdata", "ictdata*168");
                if (oraDB.isConnect())
                {
                    DataSet s = oraDB.selectSQLwithOrder("fluke_data".ToUpper(), new string[] { "FL04", "FL01", "ITSDATE" }, new string[] { flexnum, ngitem, date });
                    DataTable dt = s.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        string datestr = (string)dt.Rows[0]["ITSDATE"];
                        string timestr = (string)dt.Rows[0]["ITSTIME"];
                        if (datestr.Length == 8 && (timestr.Length == 5 || timestr.Length == 6))
                        {
                            if (timestr.Length == 5)
                            {
                                timestr = "0" + timestr;
                            }
                            string datetimestr = string.Empty;
                            datetimestr = string.Format("{0}/{1}/{2} {3}:{4}:{5}", datestr.Substring(0, 4), datestr.Substring(4, 2), datestr.Substring(6, 2), timestr.Substring(0, 2), timestr.Substring(2, 2), timestr.Substring(4, 2));
                            DateTime updatetime = Convert.ToDateTime(datetimestr);
                            TimeSpan sp = updatetime - SamStart;
                            if (sp.TotalSeconds > 0)
                            {
                                DataSet s1 = oraDB.selectSQL("barsaminfo".ToUpper(), new string[] { "BARCODE" }, new string[] { (string)dt.Rows[0]["BARCODE"] });
                                DataTable dt1 = s1.Tables[0];
                                if (dt1.Rows.Count > 0)
                                {
                                    try
                                    {
                                        //插入样本记录
                                        string parnum = Inifile.INIGetStringValue(initestPath, "Other", "pn", "FHAPHS9");
                                        string tres = ngitem.Length > 20 ? ngitem.Substring(0, 20) : ngitem;
                                        string[] arrFieldAndNewValue = { "PARTNUM", "SITEM", "BARCODE", "NGITEM", "TRES", "MNO", "CDATE", "CTIME", "SR01" };
                                        string[] arrFieldAndOldValue = { parnum.ToUpper(), "FLUKE", (string)dt.Rows[0]["BARCODE"], (string)dt1.Rows[0]["NGITEM"], tres, MNO, DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("HHmmss"), flexnum };
                                        oraDB.insertSQL1("BARSAMREC".ToUpper(), arrFieldAndNewValue, arrFieldAndOldValue);
             
                                        SaveCSVfileSample(arrFieldAndOldValue);
                                        DataSet samtimesds = oraDB.selectSQL("BARSAMREC", new string[] { "BARCODE" }, new string[] { (string)dt.Rows[0]["BARCODE"] });
                                        MsgText = AddMessage("插入样本记录 " + (string)dt.Rows[0]["BARCODE"] + " " + samtimesds.Tables[0].Rows.Count.ToString());
                                        if (samtimesds.Tables[0].Rows.Count > SamTimesLimit)
                                        {
                                            ShowAlarmTextGrid((string)dt.Rows[0]["BARCODE"] + "样本记录" + samtimesds.Tables[0].Rows.Count.ToString() +" > " + SamTimesLimit.ToString());
                                            return "Limit";
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MsgText = AddMessage(ex.Message);
                                    }


                                    if (((string)dt1.Rows[0]["NGITEM"]).ToUpper() == ngitem.ToUpper())
                                    {
                                        oraDB.disconnect();
                                        return "ok";
                                    }
                                    else
                                    {
                                        oraDB.disconnect();
                                        return (string)dt1.Rows[0]["NGITEM"];
                                    }

                                }
                                else
                                {
                                    oraDB.disconnect();
                                    return "NoSam";
                                    //return "ok";
                                }
                            }
                            else
                            {
                                oraDB.disconnect();
                                return "NotNew";
                            }
                        }
                        else
                        {
                            MsgText = AddMessage("时间格式错误");
                            oraDB.disconnect();
                            return "Error";
                        }

                    }
                    else
                    {
                        oraDB.disconnect();
                        return "NoRecord";
                    }
                }
                else
                {

                    MsgText = AddMessage("数据库未连接");
                    return "Error";
                }

            }
            catch (Exception ex)
            {
                MsgText = AddMessage(ex.Message);
                return "Error";
            }
        }
        #endregion
        #region 应用函数
        private string MaopaoPaixu()
        {
            string str = "";
            double[] Array_A = new double[4];
            ushort[] Array_B = new ushort[4];

            for (ushort k = 0; k < 4; k++)
            {
                Array_A[k] = epsonRC90.YanmadeTester[k].Yield_Nomal;
                Array_B[k] = k;
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3 - i; j++)
                {
                    if (Array_A[j] < Array_A[j + 1])
                    {
                        var temp1 = Array_A[j];
                        var temp2 = Array_B[j];
                        Array_A[j] = Array_A[j + 1];
                        Array_B[j] = Array_B[j + 1];
                        Array_A[j + 1] = temp1;
                        Array_B[j + 1] = temp2;
                    }
                }
            }
            int i_index = 0;
            for (int m = 0; m < 4; m++)
            {
                if (Array_B[m] == 0)
                {
                    i_index = m;
                    break;
                }
            }
            if (i_index == 3)
            {
                var temp5 = Array_B[i_index];
                Array_B[i_index] = Array_B[2];
                Array_B[2] = temp5;
            }
            for (int l = 0; l < 4; l++)
            {
                str += Array_B[l].ToString() + ";";
            }
            return str;
        }
        private void ReadAlarmRecordfromCSV()
        {
            string filepath = "D:\\报警记录\\报警记录" + GetBanci() + ".csv";
            DataTable dt = new DataTable();
            DataTable dt1;
            dt.Columns.Add("Time", typeof(string));
            dt.Columns.Add("Content", typeof(string));
            try
            {
                if (File.Exists(filepath))
                {
                    dt1 = Csvfile.GetFromCsv(filepath, 1, dt);
                    if (dt1.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt1.Rows)
                        {
                            AlarmRecord tr = new AlarmRecord(item[0].ToString(), item[1].ToString());
                            lock (this)
                            {
                                myAlarmRecordQueue.Enqueue(tr);
                            }
                        }
                        MsgText = AddMessage("读取报警记录完成");
                    }
                }
                else
                {
                    MsgText = AddMessage("报警记录不存在");
                }
            }
            catch (Exception ex)
            {
                MsgText = AddMessage(ex.Message);
            }
        }
        private void SaveCSVfileRecord(TestRecord tr)
        {
            string filepath = "D:\\生产记录\\生产记录" + GetBanci() + ".csv";
            if (!Directory.Exists("D:\\生产记录"))
            {
                Directory.CreateDirectory("D:\\生产记录");
            }
            try
            {

                if (!File.Exists(filepath))
                {
                    string[] heads = { "Time", "Barcode", "Result", "Cycle", "Index" };
                    Csvfile.AddNewLine(filepath, heads);
                }
                string[] conte = { tr.TestTime, tr.Barcode, tr.TestResult, tr.TestCycleTime, tr.Index };
                Csvfile.AddNewLine(filepath, conte);
            }
            catch (Exception ex)
            {
                MsgText = AddMessage(ex.Message);
            }
        }
        private void SaveCSVfileSample(string[] arrFieldAndOldValue)
        {
            string filepath = "D:\\样本记录\\样本记录" + GetBanci() + ".csv";
            if (!Directory.Exists("D:\\样本记录"))
            {
                Directory.CreateDirectory("D:\\样本记录");
            }
            try
            {

                if (!File.Exists(filepath))
                {
                    string[] heads = {"DateTime", "PARTNUM", "SITEM", "BARCODE", "NGITEM", "TRES", "MNO", "CDATE", "CTIME", "SR01" };
                    Csvfile.AddNewLine(filepath, heads);
                }
                string[] conte = { System.DateTime.Now.ToString(), arrFieldAndOldValue[0], arrFieldAndOldValue[1], arrFieldAndOldValue[2], arrFieldAndOldValue[3], arrFieldAndOldValue[4], arrFieldAndOldValue[5], arrFieldAndOldValue[6], arrFieldAndOldValue[7], arrFieldAndOldValue[8] };
                Csvfile.AddNewLine(filepath, conte);
            }
            catch (Exception ex)
            {
                MsgText = AddMessage(ex.Message);
            }
        }
        private void ReadRecordfromCSV()
        {
            string filepath = "D:\\生产记录\\生产记录" + GetBanci() + ".csv";
            DataTable dt = new DataTable();
            DataTable dt1;
            dt.Columns.Add("Time", typeof(string));
            dt.Columns.Add("Barcode", typeof(string));
            dt.Columns.Add("Result", typeof(string));
            dt.Columns.Add("Cycle", typeof(string));
            dt.Columns.Add("Index", typeof(string));
            try
            {
                if (File.Exists(filepath))
                {
                    dt1 = Csvfile.GetFromCsv(filepath, 1, dt);
                    if (dt1.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt1.Rows)
                        {
                            TestRecord tr = new TestRecord(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString());
                            lock (this)
                            {
                                myTestRecordQueue.Enqueue(tr);
                            }
                        }
                        MsgText = AddMessage("读取测试记录完成");
                    }
                }
                else
                {
                    MsgText = AddMessage("测试记录不存在");
                }
            }
            catch (Exception ex)
            {
                MsgText = AddMessage(ex.Message);
            }
        }
        private void ReadParameter()
        {
            try
            {


                for (int i = 0; i < 4; i++)
                {
                    FlexId[i] = Inifile.INIGetStringValue(initestPath, "A", "id" + (i + 1).ToString(), "950951");
                }

                LastBanci = Inifile.INIGetStringValue(iniParameterPath, "System", "Banci", "0");
                SerialPortCom = Inifile.INIGetStringValue(iniParameterPath, "System", "PLCCOM", "COM7");
                MachineNum = Inifile.INIGetStringValue(iniParameterPath, "System", "MachineNum", "1374");
                UITitle = MachineNum + "UI " + VersionMsg;
                switch (MachineNum)
                {
                    case "1374":
                        点3 = "点21： ";
                        break;
                    default:
                        点3 = "点13： ";
                        break;
                }
                TestCheckedAL = bool.Parse(Inifile.INIGetStringValue(iniParameterPath, "Tester", "TestCheckedAL", "True"));
                TestCheckedBL = bool.Parse(Inifile.INIGetStringValue(iniParameterPath, "Tester", "TestCheckedBL", "True"));

                run_min = double.Parse(Inifile.INIGetStringValue(iniTimeCalcPath, "Summary", "run_min", "0"));
                work_min = double.Parse(Inifile.INIGetStringValue(iniTimeCalcPath, "Summary", "work_min", "0"));
                waittake_min = double.Parse(Inifile.INIGetStringValue(iniTimeCalcPath, "Summary", "waittake_min", "0"));
                waittray_min = double.Parse(Inifile.INIGetStringValue(iniTimeCalcPath, "Summary", "waittray_min", "0"));
                waitinput_min = double.Parse(Inifile.INIGetStringValue(iniTimeCalcPath, "Summary", "waitinput_min", "0"));
                jigdown_min = double.Parse(Inifile.INIGetStringValue(iniTimeCalcPath, "Summary", "jigdown_min", "0"));
                down_min = double.Parse(Inifile.INIGetStringValue(iniTimeCalcPath, "Summary", "down_min", "0"));
                DangbanFirstProduct = Inifile.INIGetStringValue(iniTimeCalcPath, "Summary", "DangbanFirstProduct", "null");

                liaoinput = uint.Parse(Inifile.INIGetStringValue(iniTimeCalcPath, "Summary", "liaoinput", "0"));
                liaooutput = uint.Parse(Inifile.INIGetStringValue(iniTimeCalcPath, "Summary", "liaooutput", "0"));
                louliao = uint.Parse(Inifile.INIGetStringValue(iniTimeCalcPath, "Summary", "louliao", "0"));

                TotalAlarmNum = int.Parse(Inifile.INIGetStringValue(iniTimeCalcPath, "Alarm", "TotalAlarmNum", "0"));

                UPH = uint.Parse(Inifile.INIGetStringValue(iniParameterPath, "System", "UPH", "250"));
                MNO = Inifile.INIGetStringValue(iniParameterPath, "System", "MNO", "X1374-1");
                LastQingjie = Convert.ToDateTime(Inifile.INIGetStringValue(iniParameterPath, "System", "LastQingjie", "2018/10/31 8:00:00"));
                LastQingjieStr = LastQingjie.ToString();
                //IsSamTest = bool.Parse(Inifile.INIGetStringValue(iniParameterPath, "System", "IsSamTest", "False"));
                IsSamTest = true;
                LasSam = Convert.ToDateTime(Inifile.INIGetStringValue(iniParameterPath, "Sam", "LasSam", "2018/10/31 8:00:00"));
                LasSamStr = LasSam.ToString();
                for (int i = 0; i < 8; i++)
                {
                    SampleNgitem.Add(Inifile.INIGetStringValue(iniParameterPath, "Sam", "SampleNgitem" + (i + 1).ToString(), "NA"));
                }
                try
                {
                    SampleTimeElapse = double.Parse(Inifile.INIGetStringValue(iniParameterPath, "Sam", "SampleTimeElapse", "2"));
                    SampleNgitemsNum = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "Sam", "SampleNgitemsNum", "8"));
                    SamTimesLimit = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "Sam", "SamTimesLimit", "100"));
                    DaySampleStartMin = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "Sam", "DaySampleStartMin", "0"));
                    NightSampleStartMin = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "Sam", "NightSampleStartMin", "0"));
                    DaySampleStartHour = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "Sam", "DaySampleStartHour", "8"));
                    NightSampleStartHour = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "Sam", "NightSampleStartHour", "20"));

                    DaySampleStartMin1 = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "Sam", "DaySampleStartMin1", "0"));
                    NightSampleStartMin1 = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "Sam", "NightSampleStartMin1", "0"));
                    DaySampleStartHour1 = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "Sam", "DaySampleStartHour1", "14"));
                    NightSampleStartHour1 = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "Sam", "NightSampleStartHour1", "2"));

                }
                catch (Exception ex)
                {
                    DaySampleStartHour = 8;
                    NightSampleStartHour = 20;
                    DaySampleStartMin = 0;
                    NightSampleStartMin = 0;
                    DaySampleStartHour1 = 14;
                    NightSampleStartHour1 = 2;
                    DaySampleStartMin1 = 0;
                    NightSampleStartMin1 = 0;
                    SampleTimeElapse = 2;
                    SampleNgitemsNum = 8;
                    SamTimesLimit = 100;
                    MsgText = AddMessage(ex.Message);
                }
                PcsGrrNeedNum = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "System", "PcsGrrNeedNum", "4"));
                PcsGrrNeedCount = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "System", "PcsGrrNeedCount", "10"));
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
                Inifile.INIWriteValue(iniParameterPath, "System", "PcsGrrNeedNum", PcsGrrNeedNum.ToString());

                Inifile.INIWriteValue(iniParameterPath, "System", "PcsGrrNeedCount", PcsGrrNeedCount.ToString());

                Inifile.INIWriteValue(iniParameterPath, "System", "IsSamTest", IsSamTest.ToString());
                Inifile.INIWriteValue(iniParameterPath, "System", "MachineNum", MachineNum);
                Inifile.INIWriteValue(iniParameterPath, "System", "UPH", UPH.ToString());
                Inifile.INIWriteValue(iniParameterPath, "System", "MNO", MNO);
                for (int i = 0; i < 8; i++)
                {
                    Inifile.INIWriteValue(iniParameterPath, "Sam", "SampleNgitem" + (i + 1).ToString(), SampleNgitem[i]);
                }
                //if (DaySampleStartMin < 0)
                //{
                //    DaySampleStartMin = 0;
                //}
                //if (DaySampleStartMin > 59)
                //{
                //    DaySampleStartMin = 59;
                //}
                //if (NightSampleStartMin < 0)
                //{
                //    NightSampleStartMin = 0;
                //}
                //if (NightSampleStartMin > 59)
                //{
                //    NightSampleStartMin = 59;
                //}
                //if (DaySampleStartHour < 8)
                //{
                //    DaySampleStartHour = 8;
                //}
                //if (DaySampleStartHour >= 14)
                //{
                //    DaySampleStartHour = 14;
                //}
                //if (NightSampleStartHour < 0)
                //{
                //    NightSampleStartHour = 0;
                //}
                //if (NightSampleStartHour >= 8 && NightSampleStartHour < 20)
                //{
                //    NightSampleStartHour = 7;
                //}
                //if (NightSampleStartHour > 23)
                //{
                //    NightSampleStartHour = 23;
                //}
                //if (NightSampleStartHour < 8 && NightSampleStartHour >= 2)
                //{
                //    NightSampleStartHour = 2;
                //}
                Inifile.INIWriteValue(iniParameterPath, "Sam", "DaySampleStartMin", DaySampleStartMin.ToString());
                Inifile.INIWriteValue(iniParameterPath, "Sam", "NightSampleStartMin", NightSampleStartMin.ToString());
                Inifile.INIWriteValue(iniParameterPath, "Sam", "DaySampleStartHour", DaySampleStartHour.ToString());
                Inifile.INIWriteValue(iniParameterPath, "Sam", "NightSampleStartHour", NightSampleStartHour.ToString());

                Inifile.INIWriteValue(iniParameterPath, "Sam", "DaySampleStartMin1", DaySampleStartMin1.ToString());
                Inifile.INIWriteValue(iniParameterPath, "Sam", "NightSampleStartMin1", NightSampleStartMin1.ToString());
                Inifile.INIWriteValue(iniParameterPath, "Sam", "DaySampleStartHour1", DaySampleStartHour1.ToString());
                Inifile.INIWriteValue(iniParameterPath, "Sam", "NightSampleStartHour1", NightSampleStartHour1.ToString());

                Inifile.INIWriteValue(iniParameterPath, "Sam", "SampleTimeElapse", SampleTimeElapse.ToString());
                Inifile.INIWriteValue(iniParameterPath, "Sam", "SampleNgitemsNum", SampleNgitemsNum.ToString());
 
                Inifile.INIWriteValue(iniParameterPath, "Sam", "SamTimesLimit", SamTimesLimit.ToString());
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


                string rst = "";
                switch (MachineNum)
                {
                    //case "1372":
                    //    break;
                    //case "1373":
                    //    break;
                    case "1374":
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
                        if (isUpdateImage)
                        {
                            GlobalVar.hWndCtrl.addIconicVar(hdevEngine.getImage("Image"));
                            GlobalVar.hWndCtrl.repaint();
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
                        }
                        break;
                    default:
                        for (int i = 0; i < 10; i++)
                        {
                            FindFill[i] = hdevEngine.getmeasurements("fill" + (i + 1).ToString()).ToString() == "1" && i < 6;
                            if (i < 6)
                            {
                                if (FindFill[i])
                                {
                                    rst += "1";
                                }
                                else
                                {
                                    rst += "0";
                                }
                            }

                        }
                        if (isUpdateImage)
                        {
                            GlobalVar.hWndCtrl.addIconicVar(hdevEngine.getImage("Image"));
                            GlobalVar.hWndCtrl.repaint();
                            for (int i = 0; i < 6; i++)
                            {
                                if (FindFill[i])
                                {
                                    GlobalVar.hWndCtrl.addIconicVar(hdevEngine.getRegion("Rectangle" + (i + 1).ToString()));
                                }
                            }

                            GlobalVar.hWndCtrl.repaint();
                        }
                        break;
                }
                

                MsgText = AddMessage("拍照完成: " + rst);
            }
            catch(Exception ex)
            {
                MsgText = AddMessage(ex.Message);
            }

        }
        #endregion
        #endregion
    }
    public class AlarmRecord
    {
        public string AlarmTime { set; get; }
        public string Content { set; get; }
        public AlarmRecord(string alarmTime, string content)
        {
            AlarmTime = alarmTime;
            Content = content;
        }
    }
    public class TestRecord
    {
        public string TestTime { set; get; }
        public string Barcode { set; get; }
        public string TestResult { set; get; }
        public string TestCycleTime { set; get; }
        public string Index { set; get; }
        public TestRecord(string testTime, string barcode, string testResult, string testCycleTime, string index)
        {
            TestTime = testTime;
            Barcode = barcode;
            TestResult = testResult;
            TestCycleTime = testCycleTime;
            Index = index;
        }
    }
}
