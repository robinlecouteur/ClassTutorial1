using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gallery3WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //clsPainting.LoadPaintingForm = new clsPainting.LoadPaintingFormDelegate(frmPainting.Run);
            //clsSculpture.LoadSculptureForm = new clsSculpture.LoadSculptureFormDelegate(frmSculpture.Run);
            //clsPhotograph.LoadPhotographForm = new clsPhotograph.LoadPhotographFormDelegate(frmPhotograph.Run);
            Application.Run(frmMain.Instance);
        }
    }
}