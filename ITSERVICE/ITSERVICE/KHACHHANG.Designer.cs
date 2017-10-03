namespace ITSERVICE
{
    partial class FORM_KHACHHANG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_KHACHHANG));
            this.searchkh = new DevExpress.XtraEditors.SearchControl();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_reload = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_acction = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gctr_khachhang = new DevExpress.XtraGrid.GridControl();
            this.gv_khachhang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbb_chucvu = new System.Windows.Forms.ComboBox();
            this.txt_sodthKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.bt_apply = new DevExpress.XtraEditors.SimpleButton();
            this.bt_reset = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_emailkh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_hotenkh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_makh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.searchkh.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctr_khachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_khachhang)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sodthKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_emailkh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hotenkh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // searchkh
            // 
            this.searchkh.EditValue = "Nhập Mã hoặc Tên Khách Hàng";
            this.searchkh.Location = new System.Drawing.Point(3, 95);
            this.searchkh.Name = "searchkh";
            this.searchkh.Properties.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.searchkh.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.searchkh.Properties.Appearance.Options.UseBackColor = true;
            this.searchkh.Properties.Appearance.Options.UseForeColor = true;
            this.searchkh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.searchkh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchkh.Size = new System.Drawing.Size(346, 20);
            this.searchkh.TabIndex = 1;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Coffee";
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(356, 91);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 29);
            this.search.TabIndex = 5;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bt_reload);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.cbb_acction);
            this.groupBox2.Controls.Add(this.searchkh);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1352, 126);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(580, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 42);
            this.label2.TabIndex = 13;
            this.label2.Text = "Khách Hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt_reload
            // 
            this.bt_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_reload.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reload.Appearance.Options.UseFont = true;
            this.bt_reload.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.bt_reload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_reload.ImageOptions.Image")));
            this.bt_reload.Location = new System.Drawing.Point(437, 85);
            this.bt_reload.Name = "bt_reload";
            this.bt_reload.Size = new System.Drawing.Size(95, 37);
            this.bt_reload.TabIndex = 12;
            this.bt_reload.Text = "Reload";
            this.bt_reload.Click += new System.EventHandler(this.bt_reload_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1249, 80);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(91, 35);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Export";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cbb_acction
            // 
            this.cbb_acction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_acction.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbb_acction.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_acction.FormattingEnabled = true;
            this.cbb_acction.Items.AddRange(new object[] {
            "Add",
            "Delete",
            "Edit"});
            this.cbb_acction.Location = new System.Drawing.Point(1156, 87);
            this.cbb_acction.Name = "cbb_acction";
            this.cbb_acction.Size = new System.Drawing.Size(80, 27);
            this.cbb_acction.TabIndex = 10;
            this.cbb_acction.Text = "Action";
            this.cbb_acction.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gctr_khachhang);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(904, 559);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // gctr_khachhang
            // 
            this.gctr_khachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctr_khachhang.Location = new System.Drawing.Point(3, 17);
            this.gctr_khachhang.LookAndFeel.SkinName = "iMaginary";
            this.gctr_khachhang.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gctr_khachhang.MainView = this.gv_khachhang;
            this.gctr_khachhang.Name = "gctr_khachhang";
            this.gctr_khachhang.Size = new System.Drawing.Size(898, 539);
            this.gctr_khachhang.TabIndex = 0;
            this.gctr_khachhang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_khachhang});
            // 
            // gv_khachhang
            // 
            this.gv_khachhang.GridControl = this.gctr_khachhang;
            this.gv_khachhang.Name = "gv_khachhang";
            this.gv_khachhang.OptionsBehavior.Editable = false;
            this.gv_khachhang.OptionsBehavior.ReadOnly = true;
            this.gv_khachhang.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_khachhang_RowClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbb_chucvu);
            this.groupBox4.Controls.Add(this.txt_sodthKH);
            this.groupBox4.Controls.Add(this.labelControl6);
            this.groupBox4.Controls.Add(this.bt_apply);
            this.groupBox4.Controls.Add(this.bt_reset);
            this.groupBox4.Controls.Add(this.labelControl5);
            this.groupBox4.Controls.Add(this.txt_emailkh);
            this.groupBox4.Controls.Add(this.labelControl4);
            this.groupBox4.Controls.Add(this.txt_hotenkh);
            this.groupBox4.Controls.Add(this.labelControl3);
            this.groupBox4.Controls.Add(this.txt_makh);
            this.groupBox4.Controls.Add(this.labelControl1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(904, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(448, 559);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // cbb_chucvu
            // 
            this.cbb_chucvu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_chucvu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbb_chucvu.FormattingEnabled = true;
            this.cbb_chucvu.Location = new System.Drawing.Point(216, 236);
            this.cbb_chucvu.Name = "cbb_chucvu";
            this.cbb_chucvu.Size = new System.Drawing.Size(131, 23);
            this.cbb_chucvu.TabIndex = 12;
            this.cbb_chucvu.Click += new System.EventHandler(this.cbb_chucvu_Click);
            // 
            // txt_sodthKH
            // 
            this.txt_sodthKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sodthKH.Location = new System.Drawing.Point(217, 190);
            this.txt_sodthKH.Name = "txt_sodthKH";
            this.txt_sodthKH.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_sodthKH.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sodthKH.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_sodthKH.Properties.Appearance.Options.UseBackColor = true;
            this.txt_sodthKH.Properties.Appearance.Options.UseFont = true;
            this.txt_sodthKH.Properties.Appearance.Options.UseForeColor = true;
            this.txt_sodthKH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txt_sodthKH.Size = new System.Drawing.Size(130, 24);
            this.txt_sodthKH.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(79, 192);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 15);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Số DTH KH:";
            // 
            // bt_apply
            // 
            this.bt_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_apply.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_apply.Appearance.Options.UseFont = true;
            this.bt_apply.Location = new System.Drawing.Point(237, 311);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(75, 23);
            this.bt_apply.TabIndex = 9;
            this.bt_apply.Text = "Apply";
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_reset.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.Appearance.Options.UseFont = true;
            this.bt_reset.Location = new System.Drawing.Point(125, 311);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(75, 23);
            this.bt_reset.TabIndex = 8;
            this.bt_reset.Text = "Reset";
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(80, 238);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 15);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Chức vụ:";
            // 
            // txt_emailkh
            // 
            this.txt_emailkh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_emailkh.Location = new System.Drawing.Point(218, 143);
            this.txt_emailkh.Name = "txt_emailkh";
            this.txt_emailkh.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_emailkh.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emailkh.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_emailkh.Properties.Appearance.Options.UseBackColor = true;
            this.txt_emailkh.Properties.Appearance.Options.UseFont = true;
            this.txt_emailkh.Properties.Appearance.Options.UseForeColor = true;
            this.txt_emailkh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txt_emailkh.Size = new System.Drawing.Size(130, 24);
            this.txt_emailkh.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(80, 145);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 15);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Email KH:";
            // 
            // txt_hotenkh
            // 
            this.txt_hotenkh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_hotenkh.Location = new System.Drawing.Point(218, 96);
            this.txt_hotenkh.Name = "txt_hotenkh";
            this.txt_hotenkh.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_hotenkh.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hotenkh.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_hotenkh.Properties.Appearance.Options.UseBackColor = true;
            this.txt_hotenkh.Properties.Appearance.Options.UseFont = true;
            this.txt_hotenkh.Properties.Appearance.Options.UseForeColor = true;
            this.txt_hotenkh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txt_hotenkh.Size = new System.Drawing.Size(130, 24);
            this.txt_hotenkh.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(80, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 15);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Họ Tên KH:";
            // 
            // txt_makh
            // 
            this.txt_makh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_makh.Enabled = false;
            this.txt_makh.Location = new System.Drawing.Point(218, 48);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_makh.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makh.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_makh.Properties.Appearance.Options.UseBackColor = true;
            this.txt_makh.Properties.Appearance.Options.UseFont = true;
            this.txt_makh.Properties.Appearance.Options.UseForeColor = true;
            this.txt_makh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txt_makh.Size = new System.Drawing.Size(130, 24);
            this.txt_makh.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(80, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 15);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã khách hàng:";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 685);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = null;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1352, 20);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // FORM_KHACHHANG
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(88)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 705);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "iMaginary";
            this.Name = "FORM_KHACHHANG";
            this.Text = "KHACHHANG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.searchkh.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctr_khachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_khachhang)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sodthKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_emailkh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hotenkh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_makh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        public DevExpress.XtraGrid.GridControl gctr_khachhang;
        public DevExpress.XtraGrid.Views.Grid.GridView gv_khachhang;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton bt_apply;
        private DevExpress.XtraEditors.SimpleButton bt_reset;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public System.Windows.Forms.ComboBox cbb_chucvu;
        public DevExpress.XtraEditors.TextEdit txt_emailkh;
        public DevExpress.XtraEditors.TextEdit txt_hotenkh;
        public DevExpress.XtraEditors.TextEdit txt_makh;
        public DevExpress.XtraEditors.TextEdit txt_sodthKH;
        public System.Windows.Forms.ComboBox cbb_acction;
        public DevExpress.XtraEditors.SearchControl searchkh;
        public System.Windows.Forms.Button search;
        private DevExpress.XtraEditors.SimpleButton bt_reload;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private System.Windows.Forms.Label label2;
    }
}