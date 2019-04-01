using System;

namespace Version_1_C
{
    [Serializable()] 
    public abstract class clsWork
    {
        private string _Name;
        private DateTime _Date = DateTime.Now;
        private decimal _Value;
        private static string[] _LstWorkType = { "Painting", "Photograph", "Sculpture" };


        public string Name { get => _Name; set => _Name = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public decimal Value { get => _Value; set => this._Value = value; }
        public static string[] LstWorkType { get => _LstWorkType; set => _LstWorkType = value; }

        public clsWork()
        {
            EditDetails();
        }

        public abstract void EditDetails();
        public static clsWork NewWork(int prChoice)
        {
            switch (prChoice)
            {
                case 0: return new clsPainting();
                case 1: return new clsPhotograph();
                case 2: return new clsSculpture();
                default: return null;
                
            }
        }

        public override string ToString()
        {
            return Name + "\t" + Date.ToShortDateString();  
        }
    }
}
