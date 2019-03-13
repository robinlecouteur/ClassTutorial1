using System;
using System.Collections.Generic;

namespace Version_1_C
{
    [Serializable()] 
    public class clsWorksList : List<clsWork>
    {
        private static clsMsgBoxViewController _ShowMsg = new clsMsgBoxViewController();

        private byte _SortOrder;

        public byte SortOrder { get => _SortOrder; set => _SortOrder = value; }

        public void AddWork(int prChoice)
        {
            clsWork lcWork = clsWork.NewWork(prChoice);
            if (lcWork != null)
            {
                Add(lcWork);
            }
        }
       
        public void DeleteWork(int prIndex)
        {
            if (prIndex >= 0 && prIndex < this.Count)
            {
                if (_ShowMsg.YesNo("Are you sure?", "Deleting work") == true)
                {
                    this.RemoveAt(prIndex);
                }
            }
        }
        
        public void EditWork(int prIndex)
        {
            if (prIndex >= 0 && prIndex < this.Count)
            {
                clsWork lcWork = (clsWork)this[prIndex];
                lcWork.EditDetails();
            }
            else
            {
                _ShowMsg.Notification("Sorry no work selected #" + Convert.ToString(prIndex));
            }
        }

        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsWork lcWork in this)
            {
                lcTotal += lcWork.Value;
            }
            return lcTotal;
        }

         public void SortByName()
         {
             Sort(clsNameComparer.Instance);
         }
    
        public void SortByDate()
        {
            Sort(clsDateComparer.Instance);
        }
    }
}
