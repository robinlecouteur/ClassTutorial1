using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public sealed partial class frmSculpture : Version_1_C.frmWork
    {
        //private float _Weight;
        //private string _Material;

        private frmSculpture()
        {
            InitializeComponent();
        }
        private static readonly frmSculpture _Instance = new frmSculpture();

        public static frmSculpture Instance => _Instance;
        protected override void updateForm()
        {
            base.updateForm();
            clsSculpture lcWork = (clsSculpture)_Work;
            txtWeight.Text = lcWork.Weight.ToString();
            txtMaterial.Text = lcWork.Material;
        }

        protected override void pushData()
        {
            base.pushData();
            clsSculpture lcWork = (clsSculpture)_Work;
            lcWork.Weight = Single.Parse(txtWeight.Text);
            lcWork.Material = txtMaterial.Text;
        }
    }
}

