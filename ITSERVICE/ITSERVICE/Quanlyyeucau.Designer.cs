namespace ITSERVICE
{
    partial class QUANLYYEUCAU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QUANLYYEUCAU));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.search = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.menu_dulieu = new DevExpress.XtraBars.BarSubItem();
            this.barLargeButtonItem5 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem3 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem4 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.menu_baocao = new DevExpress.XtraBars.BarSubItem();
            this.taikhoan = new DevExpress.XtraBars.BarSubItem();
            this.barLargeButtonItem6 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem7 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.menu_dulieu,
            this.menu_baocao,
            this.barLargeButtonItem1,
            this.barLargeButtonItem2,
            this.barEditItem1,
            this.barHeaderItem1,
            this.barLargeButtonItem3,
            this.barLargeButtonItem4,
            this.barLargeButtonItem5,
            this.barSubItem1,
            this.search,
            this.taikhoan,
            this.barLargeButtonItem6,
            this.barLargeButtonItem7});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 16;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemSearchControl1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(200, 200);
            this.bar1.FloatSize = new System.Drawing.Size(200, 29);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.Caption | DevExpress.XtraBars.BarLinkUserDefines.PaintStyle))), this.search, "Search", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Caption)});
            this.bar1.OptionsBar.AllowCollapse = true;
            this.bar1.OptionsBar.AllowDelete = true;
            this.bar1.OptionsBar.AllowRename = true;
            this.bar1.Text = "Tools";
            // 
            // search
            // 
            this.search.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.search.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.search.AutoFillWidth = true;
            this.search.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.True;
            this.search.Caption = "Search";
            this.search.Edit = this.repositoryItemSearchControl1;
            this.search.Id = 12;
            this.search.Name = "search";
            this.search.VisibleWhenVertical = true;
            this.search.EditValueChanged += new System.EventHandler(this.barEditItem2_EditValueChanged);
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemSearchControl1.Appearance.Options.UseFont = true;
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.menu_dulieu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.menu_baocao, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.taikhoan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Yêu Cầu";
            this.barSubItem1.Id = 11;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barSubItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // menu_dulieu
            // 
            this.menu_dulieu.Caption = "Dữ Liệu";
            this.menu_dulieu.Id = 1;
            this.menu_dulieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menu_dulieu.ImageOptions.Image")));
            this.menu_dulieu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menu_dulieu.ImageOptions.LargeImage")));
            this.menu_dulieu.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_dulieu.ItemAppearance.Normal.Options.UseFont = true;
            this.menu_dulieu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem4)});
            this.menu_dulieu.Name = "menu_dulieu";
            // 
            // barLargeButtonItem5
            // 
            this.barLargeButtonItem5.Caption = "Khách Hàng";
            this.barLargeButtonItem5.Id = 9;
            this.barLargeButtonItem5.Name = "barLargeButtonItem5";
            // 
            // barLargeButtonItem3
            // 
            this.barLargeButtonItem3.Caption = "Yêu Cầu";
            this.barLargeButtonItem3.Id = 7;
            this.barLargeButtonItem3.Name = "barLargeButtonItem3";
            // 
            // barLargeButtonItem4
            // 
            this.barLargeButtonItem4.Caption = "Kỹ Thuật Viên";
            this.barLargeButtonItem4.Id = 8;
            this.barLargeButtonItem4.Name = "barLargeButtonItem4";
            // 
            // menu_baocao
            // 
            this.menu_baocao.Caption = "Báo Cáo";
            this.menu_baocao.Id = 2;
            this.menu_baocao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menu_baocao.ImageOptions.Image")));
            this.menu_baocao.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menu_baocao.ImageOptions.LargeImage")));
            this.menu_baocao.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_baocao.ItemAppearance.Normal.Options.UseFont = true;
            this.menu_baocao.Name = "menu_baocao";
            // 
            // taikhoan
            // 
            this.taikhoan.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.taikhoan.Caption = "Tài Khoản";
            this.taikhoan.Id = 13;
            this.taikhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("taikhoan.ImageOptions.Image")));
            this.taikhoan.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taikhoan.ItemAppearance.Normal.Options.UseFont = true;
            this.taikhoan.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem7)});
            this.taikhoan.Name = "taikhoan";
            // 
            // barLargeButtonItem6
            // 
            this.barLargeButtonItem6.Caption = "Thông Tin Tài Khoản";
            this.barLargeButtonItem6.Id = 14;
            this.barLargeButtonItem6.Name = "barLargeButtonItem6";
            // 
            // barLargeButtonItem7
            // 
            this.barLargeButtonItem7.Caption = "Đăng Xuất";
            this.barLargeButtonItem7.Id = 15;
            this.barLargeButtonItem7.Name = "barLargeButtonItem7";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(881, 68);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 641);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(881, 19);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 68);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 573);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(881, 68);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 573);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Tạo Yêu Cầu Dịch Vụ";
            this.barLargeButtonItem1.Id = 3;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Caption = "Tạo Yêu Cầu Sự Cố";
            this.barLargeButtonItem2.Id = 4;
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Khách Hàng";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 5;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 6;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Sharp Plus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // QUANLYYEUCAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "QUANLYYEUCAU";
            this.Text = "Quản Lý Yêu Cầu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraBars.BarSubItem menu_dulieu;
        private DevExpress.XtraBars.BarSubItem menu_baocao;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem3;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem4;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem5;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        public DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarEditItem search;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarSubItem taikhoan;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem6;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem7;
    }
}