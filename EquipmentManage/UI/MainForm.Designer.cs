namespace EquipmentManage.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skinMenuStrip1 = new CCWin.SkinControl.SkinMenuStrip();
            this.添加借用信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.今日借用信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.往日借用信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.未归还记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成Excel表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置器械类型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dgv = new CCWin.SkinControl.SkinDataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Bt_Single = new System.Windows.Forms.ToolStripButton();
            this.Bt_Delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tb_search = new System.Windows.Forms.ToolStripTextBox();
            this.Bt_Search = new System.Windows.Forms.ToolStripButton();
            this.Tb_Return = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skinMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinMenuStrip1
            // 
            this.skinMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinMenuStrip1.Back = System.Drawing.Color.White;
            this.skinMenuStrip1.BackRadius = 4;
            this.skinMenuStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinMenuStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinMenuStrip1.BaseForeAnamorphosis = false;
            this.skinMenuStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinMenuStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseItemAnamorphosis = true;
            this.skinMenuStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemBorderShow = true;
            this.skinMenuStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemDown")));
            this.skinMenuStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemMouse")));
            this.skinMenuStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemRadius = 4;
            this.skinMenuStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.skinMenuStrip1.ItemAnamorphosis = true;
            this.skinMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemBorderShow = true;
            this.skinMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemRadius = 4;
            this.skinMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加借用信息ToolStripMenuItem,
            this.今日借用信息ToolStripMenuItem,
            this.往日借用信息ToolStripMenuItem,
            this.未归还记录ToolStripMenuItem,
            this.生成Excel表ToolStripMenuItem,
            this.设置器械类型ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.skinMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.skinMenuStrip1.Name = "skinMenuStrip1";
            this.skinMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Size = new System.Drawing.Size(932, 28);
            this.skinMenuStrip1.SkinAllColor = true;
            this.skinMenuStrip1.TabIndex = 0;
            this.skinMenuStrip1.Text = "skinMenuStrip1";
            this.skinMenuStrip1.TitleAnamorphosis = true;
            this.skinMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinMenuStrip1.TitleRadius = 4;
            this.skinMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 添加借用信息ToolStripMenuItem
            // 
            this.添加借用信息ToolStripMenuItem.Name = "添加借用信息ToolStripMenuItem";
            this.添加借用信息ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.添加借用信息ToolStripMenuItem.Text = "添加借用信息";
            this.添加借用信息ToolStripMenuItem.Click += new System.EventHandler(this.添加借用信息ToolStripMenuItem_Click);
            // 
            // 今日借用信息ToolStripMenuItem
            // 
            this.今日借用信息ToolStripMenuItem.Name = "今日借用信息ToolStripMenuItem";
            this.今日借用信息ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.今日借用信息ToolStripMenuItem.Text = "今日借用信息";
            this.今日借用信息ToolStripMenuItem.Click += new System.EventHandler(this.今日借用信息ToolStripMenuItem_Click);
            // 
            // 往日借用信息ToolStripMenuItem
            // 
            this.往日借用信息ToolStripMenuItem.Name = "往日借用信息ToolStripMenuItem";
            this.往日借用信息ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.往日借用信息ToolStripMenuItem.Text = "往日借用信息";
            this.往日借用信息ToolStripMenuItem.Click += new System.EventHandler(this.往日借用信息ToolStripMenuItem_Click);
            // 
            // 未归还记录ToolStripMenuItem
            // 
            this.未归还记录ToolStripMenuItem.Name = "未归还记录ToolStripMenuItem";
            this.未归还记录ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.未归还记录ToolStripMenuItem.Text = "未归还记录";
            this.未归还记录ToolStripMenuItem.Click += new System.EventHandler(this.未归还记录ToolStripMenuItem_Click);
            // 
            // 生成Excel表ToolStripMenuItem
            // 
            this.生成Excel表ToolStripMenuItem.Name = "生成Excel表ToolStripMenuItem";
            this.生成Excel表ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.生成Excel表ToolStripMenuItem.Text = "生成Excel表";
            this.生成Excel表ToolStripMenuItem.Click += new System.EventHandler(this.生成Excel表ToolStripMenuItem_Click);
            // 
            // 设置器械类型ToolStripMenuItem
            // 
            this.设置器械类型ToolStripMenuItem.Name = "设置器械类型ToolStripMenuItem";
            this.设置器械类型ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.设置器械类型ToolStripMenuItem.Text = "设置";
            this.设置器械类型ToolStripMenuItem.Click += new System.EventHandler(this.设置器械类型ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv.ColumnFont = null;
            this.Dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv.EnableHeadersVisualStyles = false;
            this.Dgv.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Dgv.HeadFont = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Dgv.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.Dgv.Location = new System.Drawing.Point(6, 29);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv.RowTemplate.Height = 23;
            this.Dgv.Size = new System.Drawing.Size(920, 344);
            this.Dgv.TabIndex = 1;
            this.Dgv.TitleBack = null;
            this.Dgv.TitleBackColorBegin = System.Drawing.Color.White;
            this.Dgv.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bt_Single,
            this.Bt_Delete,
            this.toolStripSeparator2,
            this.Tb_search,
            this.Bt_Search,
            this.Tb_Return,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(932, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "返回当前记录表";
            // 
            // Bt_Single
            // 
            this.Bt_Single.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bt_Single.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Single.Image")));
            this.Bt_Single.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_Single.Name = "Bt_Single";
            this.Bt_Single.Size = new System.Drawing.Size(24, 24);
            this.Bt_Single.Text = "修改单个行";
            this.Bt_Single.Click += new System.EventHandler(this.Bt_Single_Click);
            // 
            // Bt_Delete
            // 
            this.Bt_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bt_Delete.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Delete.Image")));
            this.Bt_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_Delete.Name = "Bt_Delete";
            this.Bt_Delete.Size = new System.Drawing.Size(24, 24);
            this.Bt_Delete.Text = "删除单行记录";
            this.Bt_Delete.Click += new System.EventHandler(this.Bt_Delete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // Tb_search
            // 
            this.Tb_search.Name = "Tb_search";
            this.Tb_search.Size = new System.Drawing.Size(100, 27);
            // 
            // Bt_Search
            // 
            this.Bt_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bt_Search.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Search.Image")));
            this.Bt_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_Search.Name = "Bt_Search";
            this.Bt_Search.Size = new System.Drawing.Size(24, 24);
            this.Bt_Search.Text = "搜索当前表格";
            this.Bt_Search.Click += new System.EventHandler(this.Bt_Search_Click);
            // 
            // Tb_Return
            // 
            this.Tb_Return.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tb_Return.Image = ((System.Drawing.Image)(resources.GetObject("Tb_Return.Image")));
            this.Tb_Return.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tb_Return.Name = "Tb_Return";
            this.Tb_Return.Size = new System.Drawing.Size(24, 24);
            this.Tb_Return.Text = "返回当前表格";
            this.Tb_Return.Click += new System.EventHandler(this.Tb_Return_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Dgv);
            this.groupBox1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 379);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.skinMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.skinMenuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 器材管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.skinMenuStrip1.ResumeLayout(false);
            this.skinMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinMenuStrip skinMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加借用信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 今日借用信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 往日借用信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 未归还记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置器械类型ToolStripMenuItem;
        private CCWin.SkinControl.SkinDataGridView Dgv;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成Excel表ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton Bt_Single;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox Tb_search;
        private System.Windows.Forms.ToolStripButton Bt_Search;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Bt_Delete;
        private System.Windows.Forms.ToolStripButton Tb_Return;
        private System.Windows.Forms.Timer timer1;
    }
}