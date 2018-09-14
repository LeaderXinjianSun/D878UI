using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BingLibrary.hjb.mvvm;
using System.ComponentModel.Composition;

namespace HS9上料机UI.viewmodel
{
    [Export(MEF.Contracts.Data)]
    [ExportMetadata(MEF.Key, "md")]
    [BingNotify]
    public partial class mainData : DataSourceOriginal { }
}
