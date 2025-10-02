namespace MovieApp
{
    partial class FilmDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmDetailForm));
            this.lblReleaseDate = new DevExpress.XtraEditors.LabelControl();
            this.lblAverageRating = new DevExpress.XtraEditors.LabelControl();
            this.picPoster = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnRecommend = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRecommendEmail = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblUserRating = new DevExpress.XtraEditors.LabelControl();
            this.txtUserNote = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecommendEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.Location = new System.Drawing.Point(209, 214);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(63, 13);
            this.lblReleaseDate.TabIndex = 2;
            this.lblReleaseDate.Text = "labelControl1";
            // 
            // lblAverageRating
            // 
            this.lblAverageRating.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAverageRating.Appearance.Options.UseFont = true;
            this.lblAverageRating.Location = new System.Drawing.Point(19, 308);
            this.lblAverageRating.Name = "lblAverageRating";
            this.lblAverageRating.Size = new System.Drawing.Size(75, 13);
            this.lblAverageRating.TabIndex = 3;
            this.lblAverageRating.Text = "labelControl1";
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(19, 70);
            this.picPoster.Name = "picPoster";
            this.picPoster.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picPoster.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picPoster.Size = new System.Drawing.Size(154, 217);
            this.picPoster.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtUserNote);
            this.groupControl1.Controls.Add(this.lblUserRating);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.richTextBox1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.lblAverageRating);
            this.groupControl1.Controls.Add(this.lblReleaseDate);
            this.groupControl1.Controls.Add(this.picPoster);
            this.groupControl1.Location = new System.Drawing.Point(11, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(688, 421);
            this.groupControl1.TabIndex = 6;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnRecommend);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtRecommendEmail);
            this.groupControl2.Location = new System.Drawing.Point(209, 257);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(397, 137);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Filmi Tavsiye Et";
            // 
            // btnRecommend
            // 
            this.btnRecommend.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRecommend.ImageOptions.Image")));
            this.btnRecommend.Location = new System.Drawing.Point(15, 97);
            this.btnRecommend.Name = "btnRecommend";
            this.btnRecommend.Size = new System.Drawing.Size(238, 23);
            this.btnRecommend.TabIndex = 2;
            this.btnRecommend.Text = "Mail Gönder";
            this.btnRecommend.Click += new System.EventHandler(this.btnRecommend_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Email :";
            // 
            // txtRecommendEmail
            // 
            this.txtRecommendEmail.Location = new System.Drawing.Point(15, 61);
            this.txtRecommendEmail.Name = "txtRecommendEmail";
            this.txtRecommendEmail.Size = new System.Drawing.Size(238, 20);
            this.txtRecommendEmail.TabIndex = 0;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(208, 67);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(398, 20);
            this.textEdit1.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(209, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Film Adı:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(208, 113);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(398, 95);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(209, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Film Açıklaması:";
            // 
            // lblUserRating
            // 
            this.lblUserRating.Location = new System.Drawing.Point(16, 339);
            this.lblUserRating.Name = "lblUserRating";
            this.lblUserRating.Size = new System.Drawing.Size(66, 13);
            this.lblUserRating.TabIndex = 9;
            this.lblUserRating.Text = "Kullanıcı Puanı";
            // 
            // txtUserNote
            // 
            this.txtUserNote.Location = new System.Drawing.Point(87, 340);
            this.txtUserNote.Name = "txtUserNote";
            this.txtUserNote.Size = new System.Drawing.Size(63, 13);
            this.txtUserNote.TabIndex = 10;
            this.txtUserNote.Text = "Kullanıcı Notu";
            // 
            // FilmDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 442);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FilmDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Detay Formu";
            this.Load += new System.EventHandler(this.FilmDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecommendEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblReleaseDate;
        private DevExpress.XtraEditors.LabelControl lblAverageRating;
        private DevExpress.XtraEditors.PictureEdit picPoster;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnRecommend;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtRecommendEmail;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblUserRating;
        private DevExpress.XtraEditors.LabelControl txtUserNote;
    }
}