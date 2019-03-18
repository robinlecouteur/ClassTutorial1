namespace Version_1_C
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValue = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.lstArtists = new System.Windows.Forms.ListBox();
            this.btnChangeGalleryName = new System.Windows.Forms.Button();
            this.txtNewGalleryName = new CueTextBox();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.Location = new System.Drawing.Point(82, 257);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(68, 16);
            this.lblValue.TabIndex = 13;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(12, 257);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Total Value";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(156, 249);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(80, 32);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(156, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 32);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(156, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(12, 49);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(136, 16);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Artists";
            // 
            // lstArtists
            // 
            this.lstArtists.Location = new System.Drawing.Point(12, 65);
            this.lstArtists.Name = "lstArtists";
            this.lstArtists.Size = new System.Drawing.Size(136, 173);
            this.lstArtists.TabIndex = 7;
            this.lstArtists.DoubleClick += new System.EventHandler(this.lstArtists_DoubleClick);
            // 
            // btnChangeGalleryName
            // 
            this.btnChangeGalleryName.Location = new System.Drawing.Point(9, 6);
            this.btnChangeGalleryName.Name = "btnChangeGalleryName";
            this.btnChangeGalleryName.Size = new System.Drawing.Size(120, 22);
            this.btnChangeGalleryName.TabIndex = 14;
            this.btnChangeGalleryName.Text = "Change Gallery Name";
            this.btnChangeGalleryName.UseVisualStyleBackColor = true;
            this.btnChangeGalleryName.Click += new System.EventHandler(this.btnChangeGalleryName_Click);
            // 
            // txtNewGalleryName
            // 
            this.txtNewGalleryName.Cue = "New Gallery Name...";
            this.txtNewGalleryName.Location = new System.Drawing.Point(134, 7);
            this.txtNewGalleryName.Name = "txtNewGalleryName";
            this.txtNewGalleryName.Size = new System.Drawing.Size(119, 20);
            this.txtNewGalleryName.TabIndex = 16;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 289);
            this.Controls.Add(this.txtNewGalleryName);
            this.Controls.Add(this.btnChangeGalleryName);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lstArtists);
            this.Name = "frmMain";
            this.Text = "Gallery (v1 C)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblValue;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnQuit;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox lstArtists;
        private System.Windows.Forms.Button btnChangeGalleryName;
        private CueTextBox txtNewGalleryName;
    }
}

