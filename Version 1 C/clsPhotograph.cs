using System;

namespace Version_1_C
{
    [Serializable()]
    public class clsPhotograph : clsWork
    {
        public delegate void LoadPhotographFormDelegate(clsPhotograph prPhotograph);
        public static LoadPhotographFormDelegate LoadPhotographForm;

        private float _Width;
        private float _Height;
        private string _Type;

        public float Width { get => _Width; set => _Width = value; }
        public float Height { get => _Height; set => _Height = value; }
        public string Type { get => _Type; set => _Type = value; }

        public override void EditDetails()
        {
            LoadPhotographForm(this);
        }
    }
}
