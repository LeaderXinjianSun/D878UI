using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using System.IO;
using BingLibrary.hjb.Metro;

namespace HS9上料机UI.viewmodel
{
    public partial class mainData
    {
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
