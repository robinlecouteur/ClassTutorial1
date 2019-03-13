using System;

namespace Version_1_C
{
    [Serializable()] 
    public class clsSculpture : clsWork
    {
        public delegate void LoadSculptureFormDelegate(clsSculpture prSculpture);
        public static LoadSculptureFormDelegate LoadSculptureForm;

        private float _Weight;
        private string _Material;

        public float Weight { get => _Weight; set => _Weight = value; }
        public string Material { get => _Material; set => _Material = value; }

        public override void EditDetails()
        {
            LoadSculptureForm(this);
        }
    }
}
