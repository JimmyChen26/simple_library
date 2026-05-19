namespace 圖書管理程式
{
    partial class frmBooks
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            this.lvwBooks = new System.Windows.Forms.ListView();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.grpView = new System.Windows.Forms.GroupBox();
            this.grpBorrow = new System.Windows.Forms.GroupBox();
            this.lstBorrow = new System.Windows.Forms.ListBox();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.imgL = new System.Windows.Forms.ImageList(this.components);
            this.imgS = new System.Windows.Forms.ImageList(this.components);
            this.pnlTools.SuspendLayout();
            this.grpView.SuspendLayout();
            this.grpBorrow.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwBooks
            // 
            this.lvwBooks.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvwBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwBooks.HideSelection = false;
            this.lvwBooks.LargeImageList = this.imgL;
            this.lvwBooks.Location = new System.Drawing.Point(0, 0);
            this.lvwBooks.Name = "lvwBooks";
            this.lvwBooks.Size = new System.Drawing.Size(1555, 803);
            this.lvwBooks.SmallImageList = this.imgS;
            this.lvwBooks.TabIndex = 0;
            this.lvwBooks.UseCompatibleStateImageBehavior = false;
            this.lvwBooks.SelectedIndexChanged += new System.EventHandler(this.lvwBooks_SelectedIndexChanged);
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.grpView);
            this.pnlTools.Controls.Add(this.grpBorrow);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTools.Location = new System.Drawing.Point(1355, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(200, 803);
            this.pnlTools.TabIndex = 1;
            // 
            // grpView
            // 
            this.grpView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpView.Controls.Add(this.cmbView);
            this.grpView.Location = new System.Drawing.Point(3, 3);
            this.grpView.Name = "grpView";
            this.grpView.Size = new System.Drawing.Size(197, 100);
            this.grpView.TabIndex = 2;
            this.grpView.TabStop = false;
            this.grpView.Text = "檢視方式";
            // 
            // grpBorrow
            // 
            this.grpBorrow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBorrow.Controls.Add(this.lstBorrow);
            this.grpBorrow.Location = new System.Drawing.Point(0, 106);
            this.grpBorrow.Name = "grpBorrow";
            this.grpBorrow.Size = new System.Drawing.Size(200, 697);
            this.grpBorrow.TabIndex = 3;
            this.grpBorrow.TabStop = false;
            this.grpBorrow.Text = "借書清單";
            // 
            // lstBorrow
            // 
            this.lstBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBorrow.FormattingEnabled = true;
            this.lstBorrow.ItemHeight = 18;
            this.lstBorrow.Location = new System.Drawing.Point(3, 25);
            this.lstBorrow.Name = "lstBorrow";
            this.lstBorrow.Size = new System.Drawing.Size(194, 669);
            this.lstBorrow.TabIndex = 4;
            // 
            // cmbView
            // 
            this.cmbView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Location = new System.Drawing.Point(26, 38);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(118, 26);
            this.cmbView.TabIndex = 5;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // imgL
            // 
            this.imgL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgL.ImageStream")));
            this.imgL.TransparentColor = System.Drawing.Color.Transparent;
            this.imgL.Images.SetKeyName(0, "Book1.bmp");
            this.imgL.Images.SetKeyName(1, "Book2.bmp");
            this.imgL.Images.SetKeyName(2, "Book3.bmp");
            this.imgL.Images.SetKeyName(3, "Book4.bmp");
            this.imgL.Images.SetKeyName(4, "Book5.bmp");
            this.imgL.Images.SetKeyName(5, "Book6.bmp");
            this.imgL.Images.SetKeyName(6, "Book7.bmp");
            this.imgL.Images.SetKeyName(7, "Book8.bmp");
            // 
            // imgS
            // 
            this.imgS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgS.ImageStream")));
            this.imgS.TransparentColor = System.Drawing.Color.Transparent;
            this.imgS.Images.SetKeyName(0, "Book1.bmp");
            this.imgS.Images.SetKeyName(1, "Book2.bmp");
            this.imgS.Images.SetKeyName(2, "Book3.bmp");
            this.imgS.Images.SetKeyName(3, "Book4.bmp");
            this.imgS.Images.SetKeyName(4, "Book5.bmp");
            this.imgS.Images.SetKeyName(5, "Book6.bmp");
            this.imgS.Images.SetKeyName(6, "Book7.bmp");
            this.imgS.Images.SetKeyName(7, "Book8.bmp");
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 803);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.lvwBooks);
            this.Name = "frmBooks";
            this.Text = "圖書管理";
            this.pnlTools.ResumeLayout(false);
            this.grpView.ResumeLayout(false);
            this.grpBorrow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwBooks;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.GroupBox grpView;
        private System.Windows.Forms.GroupBox grpBorrow;
        private System.Windows.Forms.ListBox lstBorrow;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.ImageList imgL;
        private System.Windows.Forms.ImageList imgS;
    }
}

