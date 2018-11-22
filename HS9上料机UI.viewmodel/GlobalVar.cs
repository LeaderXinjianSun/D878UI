using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewROI;
using BingLibrary.hjb.Metro;
using OfficeOpenXml;
using System.Collections.ObjectModel;
using System.Data;

namespace HS9上料机UI.viewmodel
{
    public static class GlobalVar
    {
        public static HWndCtrl hWndCtrl;
        public static ROIController rOIController;
        public static Metro metro = new Metro();
        public static ExcelPackage Package;
        public static ExcelWorksheet Worksheet;
        public static DataTable Mdt = new DataTable(); 
    }
}
