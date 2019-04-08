using System;
using System.Collections.Generic;
//using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gallery3WinForm
{
    public partial class frmArtist : Form
    {
        public frmArtist()
        {
            InitializeComponent();
            //cboAddWork.DataSource = clsWork.LstWorkType;
            //cboAddWork.SelectedIndex = 0;
        }

        //private clsWorksList _WorksList;
        //private byte _SortOrder; // 0 = Name, 1 = Date
        private clsArtist _Artist;
        private static Dictionary<string, frmArtist> _ArtistFormList = new Dictionary<string, frmArtist>();


        public static void Run(string prArtistName)
        {
            frmArtist lcArtistForm;
            if (string.IsNullOrEmpty(prArtistName) ||
            !_ArtistFormList.TryGetValue(prArtistName, out lcArtistForm))
            {
                lcArtistForm = new frmArtist();
                if (string.IsNullOrEmpty(prArtistName))
                    lcArtistForm.SetDetails(new clsArtist());
                else
                {
                    _ArtistFormList.Add(prArtistName, lcArtistForm);
                    lcArtistForm.refreshFormFromDB(prArtistName);

                }
            }
            else
            {
                lcArtistForm.Show();
                lcArtistForm.Activate();
            }
        }

        private async void refreshFormFromDB(string prArtistName)
        {
            SetDetails(await ServiceClient.GetArtistAsync(prArtistName));
        }


        private void updateDisplay()
        {
            txtName.Enabled = string.IsNullOrEmpty(_Artist.Name);
            //if (_WorksList.SortOrder == 0)
            //{
            //    _WorksList.SortByName();
            //    rbByName.Checked = true;
            //}
            //else
            //{
            //    _WorksList.SortByDate();
            //    rbByDate.Checked = true;
            //}

            //lstWorks.DataSource = null;
            //lstWorks.DataSource = _WorksList;
            //lblTotal.Text = Convert.ToString(_WorksList.GetTotalValue());

            frmMain.Instance.UpdateDisplay();
        }

        public void SetDetails(clsArtist prArtist)
        {
            _Artist = prArtist;

            updateForm();
            updateDisplay();

            //frmMain.Instance.GalleryNameChanged += new frmMain.Notify(updateTitle);
            //updateTitle(_Artist.ArtistList.GalleryName);
            Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //_WorksList.DeleteWork(lstWorks.SelectedIndex);
            //updateDisplay();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //_WorksList.AddWork(cboAddWork.SelectedIndex);
            //updateDisplay();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
                try
                {
                    pushData();
                    //if (txtName.Enabled)
                    //{
                    //    _Artist.NewArtist();

                    //    MessageBox.Show("Artist added!");
                    //    frmMain.Instance.UpdateDisplay();
                    //    txtName.Enabled = false;
                    //}
                    Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        public virtual Boolean isValid()
        {
            //if (txtName.Enabled && txtName.Text != "")
            //    if (_Artist.IsDuplicate(txtName.Text))
            //    {
            //        MessageBox.Show("Artist with that name already exists!");
            //        return false;
            //    }
            //    else
            //        return true;
            //else
                return true;
        }

        private void lstWorks_DoubleClick(object sender, EventArgs e)
        {
            //int lcIndex = lstWorks.SelectedIndex;
            //if (lcIndex >= 0)
            //{
            //    _WorksList.EditWork(lcIndex);
            //    updateDisplay();
            //}
        }

        private void rbByDate_CheckedChanged(object sender, EventArgs e)
        {
            //_WorksList.SortOrder = Convert.ToByte(rbByDate.Checked);
            //updateDisplay();
        }

        private void updateForm()
        {
            txtName.Text = _Artist.Name;
            txtPhone.Text = _Artist.Phone;
            txtSpeciality.Text = _Artist.Speciality;
            //lblTotal.Text = _Artist.TotalValue.ToString();
            //_WorksList = _Artist.WorksList;


        }

        private void pushData()
        {
            _Artist.Name = txtName.Text;
            _Artist.Phone = txtPhone.Text;
            _Artist.Speciality = txtSpeciality.Text;
        }


        //private void updateTitle(string prGalleryName)
        //{
        //    if (!string.IsNullOrEmpty(prGalleryName))

        //        Text = "ArtistDetails - " + prGalleryName;
        //}
    }
}