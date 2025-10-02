namespace MovieApp
{
    partial class FormMovies
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovies));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.dateRelease = new DevExpress.XtraEditors.DateEdit();
            this.btnImportMovies = new DevExpress.XtraEditors.SimpleButton();
            this.btnAllMovies = new DevExpress.XtraEditors.SimpleButton();
            this.txtPosterPath = new DevExpress.XtraEditors.TextEdit();
            this.btnSelectPoster = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddRating = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewDetails = new DevExpress.XtraEditors.SimpleButton();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.txtOverview = new DevExpress.XtraEditors.TextEdit();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblProgress = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRelease.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRelease.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosterPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOverview.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 294);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 150);
            this.gridControl1.Size = new System.Drawing.Size(755, 507);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(59, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(265, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Film Ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(390, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(265, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Film Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(59, 64);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Properties.NullText = "Başlık Alanı";
            this.txtTitle.Size = new System.Drawing.Size(265, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // dateRelease
            // 
            this.dateRelease.EditValue = null;
            this.dateRelease.Location = new System.Drawing.Point(59, 37);
            this.dateRelease.Name = "dateRelease";
            this.dateRelease.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRelease.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRelease.Properties.NullText = "Çıkış Tarihi ";
            this.dateRelease.Size = new System.Drawing.Size(265, 20);
            this.dateRelease.TabIndex = 5;
            // 
            // btnImportMovies
            // 
            this.btnImportMovies.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImportMovies.ImageOptions.Image")));
            this.btnImportMovies.Location = new System.Drawing.Point(390, 127);
            this.btnImportMovies.Name = "btnImportMovies";
            this.btnImportMovies.Size = new System.Drawing.Size(265, 23);
            this.btnImportMovies.TabIndex = 7;
            this.btnImportMovies.Text = "TMDb\'den Film Yükle";
            this.btnImportMovies.Click += new System.EventHandler(this.btnImportMovies_Click);
            // 
            // btnAllMovies
            // 
            this.btnAllMovies.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAllMovies.ImageOptions.Image")));
            this.btnAllMovies.Location = new System.Drawing.Point(390, 69);
            this.btnAllMovies.Name = "btnAllMovies";
            this.btnAllMovies.Size = new System.Drawing.Size(265, 23);
            this.btnAllMovies.TabIndex = 8;
            this.btnAllMovies.Text = "Tüm Filmlerin Listesine Git";
            this.btnAllMovies.Click += new System.EventHandler(this.btnAllMovies_Click);
            // 
            // txtPosterPath
            // 
            this.txtPosterPath.EditValue = "Görsel (URL) Alanı";
            this.txtPosterPath.Enabled = false;
            this.txtPosterPath.Location = new System.Drawing.Point(59, 196);
            this.txtPosterPath.Name = "txtPosterPath";
            this.txtPosterPath.Properties.NullText = "Film Açıklaması Giriniz";
            this.txtPosterPath.Properties.ReadOnly = true;
            this.txtPosterPath.Size = new System.Drawing.Size(265, 20);
            this.txtPosterPath.TabIndex = 9;
            // 
            // btnSelectPoster
            // 
            this.btnSelectPoster.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectPoster.ImageOptions.Image")));
            this.btnSelectPoster.Location = new System.Drawing.Point(59, 222);
            this.btnSelectPoster.Name = "btnSelectPoster";
            this.btnSelectPoster.Size = new System.Drawing.Size(265, 23);
            this.btnSelectPoster.TabIndex = 13;
            this.btnSelectPoster.Text = "Görsel Yükle";
            this.btnSelectPoster.Click += new System.EventHandler(this.btnSelectPoster_Click);
            // 
            // btnAddRating
            // 
            this.btnAddRating.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRating.ImageOptions.Image")));
            this.btnAddRating.Location = new System.Drawing.Point(390, 98);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(265, 23);
            this.btnAddRating.TabIndex = 11;
            this.btnAddRating.Text = "Film Puanla";
            this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDetails.ImageOptions.Image")));
            this.btnViewDetails.Location = new System.Drawing.Point(390, 40);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(265, 23);
            this.btnViewDetails.TabIndex = 12;
            this.btnViewDetails.Text = "Film Detaylarını Görüntüle";
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // txtOverview
            // 
            this.txtOverview.EditValue = "Açıklama Alanı";
            this.txtOverview.Location = new System.Drawing.Point(452, 209);
            this.txtOverview.Name = "txtOverview";
            this.txtOverview.Properties.NullText = "Film Afiş Görseli (URL)";
            this.txtOverview.Size = new System.Drawing.Size(100, 20);
            this.txtOverview.TabIndex = 4;
            this.txtOverview.Visible = false;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(452, 184);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Maximum = 1000;
            this.progressBarControl1.Size = new System.Drawing.Size(221, 18);
            this.progressBarControl1.TabIndex = 13;
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(452, 235);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(42, 13);
            this.lblProgress.TabIndex = 14;
            this.lblProgress.Text = "Progress";
            this.lblProgress.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(59, 112);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(265, 80);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(59, 92);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Açıklama Alanı : ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnViewDetails);
            this.groupControl1.Controls.Add(this.progressBarControl1);
            this.groupControl1.Controls.Add(this.richTextBox1);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnAddRating);
            this.groupControl1.Controls.Add(this.dateRelease);
            this.groupControl1.Controls.Add(this.btnAllMovies);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtOverview);
            this.groupControl1.Controls.Add(this.txtTitle);
            this.groupControl1.Controls.Add(this.lblProgress);
            this.groupControl1.Controls.Add(this.txtPosterPath);
            this.groupControl1.Controls.Add(this.btnImportMovies);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.btnSelectPoster);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(755, 295);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Film Ekleme ve İşlem Alanı";
            // 
            // FormMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 606);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film İşlem Formu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRelease.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRelease.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosterPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOverview.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.DateEdit dateRelease;
        private DevExpress.XtraEditors.SimpleButton btnImportMovies;
        private DevExpress.XtraEditors.SimpleButton btnAllMovies;
        private DevExpress.XtraEditors.TextEdit txtPosterPath;
        private DevExpress.XtraEditors.SimpleButton btnAddRating;
        private DevExpress.XtraEditors.SimpleButton btnViewDetails;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraEditors.SimpleButton btnSelectPoster;
        private DevExpress.XtraEditors.TextEdit txtOverview;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl lblProgress;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}