namespace MovieApp
{
    partial class FilmRatingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmRatingForm));
            this.txtNote = new DevExpress.XtraEditors.TextEdit();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblMovieTitle = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.EditValue = "Not Alanı";
            this.txtNote.Location = new System.Drawing.Point(56, 272);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(285, 20);
            this.txtNote.TabIndex = 0;
            this.txtNote.Visible = false;
            // 
            // nudRating
            // 
            this.nudRating.Location = new System.Drawing.Point(56, 228);
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(130, 20);
            this.nudRating.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(189, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Film Puanını Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.Location = new System.Drawing.Point(56, 42);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(63, 13);
            this.lblMovieTitle.TabIndex = 3;
            this.lblMovieTitle.Text = "labelControl1";
            this.lblMovieTitle.Click += new System.EventHandler(this.lblMovieTitle_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(56, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(285, 139);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Not Alanı";
            // 
            // FilmRatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 306);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudRating);
            this.Controls.Add(this.txtNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilmRatingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Puan Formu";
            this.Load += new System.EventHandler(this.FilmRatingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNote;
        private System.Windows.Forms.NumericUpDown nudRating;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblMovieTitle;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}