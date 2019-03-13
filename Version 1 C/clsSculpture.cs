using System;

namespace Version_1_C
{
    [Serializable()] 
    public class clsSculpture : clsWork
    {
        private float _Weight;
        private string _Material;

        [NonSerialized()]
        private static frmSculpture _SculptureDialog;

        public float Weight { get => _Weight; set => _Weight = value; }
        public string Material { get => _Material; set => _Material = value; }

        public override void EditDetails()
        {
            if (_SculptureDialog == null)
                _SculptureDialog = new frmSculpture();
            _SculptureDialog.SetDetails(this);
        }
    }
}
