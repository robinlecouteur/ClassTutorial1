using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gallery3WinForm
{
    public sealed partial class frmMain : Form
    {
        /// <summary>
        /// Matthias Otto, NMIT, 2010-2016
        /// </summary>
        private frmMain()
        {
            InitializeComponent();
        }
        private static readonly frmMain _Instance = new frmMain();

       // private clsArtistList _ArtistList;


        public delegate void Notify(string prGalleryName);
        public event Notify GalleryNameChanged;

        private void updateTitle(string prGalleryName)
        {
            if (!string.IsNullOrEmpty(prGalleryName))
                Text = "Gallery - " + prGalleryName;
        }

        internal static frmMain Instance => _Instance;

        public async void UpdateDisplay()
        {
            try
            {
                lstArtists.DataSource = null;
                lstArtists.DataSource = await clsServiceClient.GetArtistNamesAsync();
            }
            catch (Exception)
            {

                MessageBox.Show("Error Updating Display!", "Warning!");
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //frmArtist.Run(new clsArtist(_ArtistList));
            UpdateDisplay();
        }

        private void lstArtists_DoubleClick(object sender, EventArgs e)
        {
            //string lcKey;

            //lcKey = Convert.ToString(lstArtists.SelectedItem);
            //if (lcKey != null)
            //{
            //    frmArtist.Run(_ArtistList[lcKey]);
            //    UpdateDisplay();
            //}
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //string lcKey;

            //lcKey = Convert.ToString(lstArtists.SelectedItem);
            //if (lcKey != null)
            //{
            //    lstArtists.ClearSelected();
            //    _ArtistList.Remove(lcKey);
            //    UpdateDisplay();
            //}
        }

        

        private void frmMain_Load(object sender, EventArgs e)
        {
            //_ArtistList = clsArtistList.Retrieve();
            UpdateDisplay();
            //GalleryNameChanged += new Notify(updateTitle);
            //GalleryNameChanged(_ArtistList.GalleryName); // event raising!
        }

        private void btnChangeGalleryName_Click(object sender, EventArgs e)
        {
            //_ArtistList.GalleryName = txtNewGalleryName.Text;
            //GalleryNameChanged(_ArtistList.GalleryName);
        }
    }
}