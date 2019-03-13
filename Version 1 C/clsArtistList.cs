using System;
using System.Collections.Generic;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtistList : SortedList<string, clsArtist>
    {
        private static clsMsgBoxViewController _ShowMsg = new clsMsgBoxViewController();
        private const string _FileName = "gallery1.xml";

        public void EditArtist(string prKey)
        {
            clsArtist lcArtist;
            lcArtist = this[prKey];
            if (lcArtist != null)
                lcArtist.EditDetails();
            else
                _ShowMsg.Notification("Sorry no artist by this name");
        }
       
        public void NewArtist()
        {
            clsArtist lcArtist = new clsArtist(this);
            try
            {
                if (lcArtist.Name != "")
                {
                    Add(lcArtist.Name, lcArtist);
                    _ShowMsg.Notification("Artist added!");
                }
            }
            catch (Exception)
            {
                _ShowMsg.Notification("Duplicate Key!");
            }
        }
        
        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsArtist lcArtist in Values)
            {
                lcTotal += lcArtist.TotalValue;
            }
            return lcTotal;
        }



        public void Save()
        {
            
            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Create);
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter lcFormatter =
                    new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                lcFormatter.Serialize(lcFileStream, this);
                lcFileStream.Close();
            }
            catch (Exception e)
            {
                _ShowMsg.Notification(e.Message, "File Save Error");
            }
        }

        public static clsArtistList Retrieve()
        {
            clsArtistList lcArtistList;
            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Open);
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter lcFormatter =
                    new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                lcArtistList = (clsArtistList)lcFormatter.Deserialize(lcFileStream);
                lcFileStream.Close();
            }

            catch (Exception e)
            {
                _ShowMsg.Notification(e.Message, "File Retrieve Error");
                lcArtistList = new clsArtistList();
            }

            return lcArtistList;
        }
    }
}
