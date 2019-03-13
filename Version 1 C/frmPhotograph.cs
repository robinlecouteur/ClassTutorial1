using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public sealed partial class frmPhotograph : Version_1_C.frmWork
    {

        private frmPhotograph()
        {
            InitializeComponent();
        }
        private static readonly frmPhotograph _Instance = new frmPhotograph();

        public static frmPhotograph Instance => _Instance;
        protected override void updateForm()
        {
            base.updateForm();
            clsPhotograph lcWork = (clsPhotograph)_Work;
            txtWidth.Text = lcWork.Width.ToString();
            txtHeight.Text = lcWork.Height.ToString();
            txtType.Text = lcWork.Type;
        }

        protected override void pushData()
        {
            base.pushData();
            clsPhotograph lcWork = (clsPhotograph)_Work;
            lcWork.Width = Single.Parse(txtWidth.Text);
            lcWork.Height = Single.Parse(txtHeight.Text);
            lcWork.Type = txtType.Text;
        }

        public static void Run(clsPhotograph prPhotograph)
        {
            Instance.SetDetails(prPhotograph);
        }
    }
}

