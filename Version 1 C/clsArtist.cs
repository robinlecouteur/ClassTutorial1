using System;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtist
    {
        private string _Name;
        private string _Speciality;
        private string _Phone;
       
        private clsWorksList _WorksList;
        private clsArtistList _ArtistList;
        private static clsMsgBoxViewController _ShowMsg = new clsMsgBoxViewController();



        public string Name { get => _Name; set => _Name = value; }
        public string Speciality { get => _Speciality; set => _Speciality = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public decimal TotalValue { get => _WorksList.GetTotalValue();/* set => _TotalValue = value; */}
        public clsWorksList WorksList { get => _WorksList;/* set => _WorksList = value;*/ }
        public clsArtistList ArtistList { get => _ArtistList;/* set => _ArtistList = value;*/ }
        public clsArtist(clsArtistList prArtistList)
        {
            _WorksList = new clsWorksList();
            _ArtistList = prArtistList;
        }
        public bool IsDuplicate(string prArtistName)
        {
            return _ArtistList.ContainsKey(prArtistName);
        }


        public void NewArtist()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                _ArtistList.Add(Name, this);
            }
            else
            {
                throw new Exception("No artist name entered");
            }

        }
    }
}
