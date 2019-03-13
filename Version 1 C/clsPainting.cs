using System;

namespace Version_1_C
{
    [Serializable()] 
    public class clsPainting : clsWork
    {
        public delegate void LoadPaintingFormDelegate(clsPainting prPainting);
        public static LoadPaintingFormDelegate LoadPaintingForm;

        private float _Width;
        private float _Height;
        private string _Type;

        public float Width { get => _Width; set => _Width = value; }
        public float Height { get => _Height; set => _Height = value; }
        public string Type { get => _Type; set => _Type = value; }

        public override void EditDetails()
        {
            LoadPaintingForm(this);
        }
    }
}
