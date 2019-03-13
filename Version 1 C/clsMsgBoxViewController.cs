using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version_1_C
{
    public class clsMsgBoxViewController
    {
        public bool YesNo(string prText, string prCaption)
        {

            if (MessageBox.Show(prText, prCaption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else return false;
        }

        public void Notification(string prText)
        {
            MessageBox.Show(prText);
        }

        public void Notification(string prText, string prCaption)
        {
            MessageBox.Show(prText, prCaption);  
        }
    }
}
