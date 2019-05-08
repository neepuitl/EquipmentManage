namespace EquipmentManage.UI
{
    partial class AddBorrowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBorrowForm));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.Cb_Apprartus_Name = new CCWin.SkinControl.SkinComboBox();
            this.Tb_Borrow_Number = new System.Windows.Forms.TextBox();
            this.Tb_User = new System.Windows.Forms.TextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.Tb_Phone = new System.Windows.Forms.TextBox();
            this.Bt_Add = new CCWin.SkinControl.SkinButton();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.Dtp_ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.Dtp_BorrowDate = new System.Windows.Forms.DateTimePicker();
            this.Bt_AlterDate = new CCWin.SkinControl.SkinButton();
            this.Time1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(34, 24);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(92, 27);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "器械名称";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel2.Location = new System.Drawing.Point(34, 105);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(92, 27);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "借用数量";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel3.Location = new System.Drawing.Point(34, 190);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(72, 27);
            this.skinLabel3.TabIndex = 2;
            this.skinLabel3.Text = "借用人";
            // 
            // Cb_Apprartus_Name
            // 
            this.Cb_Apprartus_Name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cb_Apprartus_Name.FormattingEnabled = true;
            this.Cb_Apprartus_Name.Location = new System.Drawing.Point(162, 24);
            this.Cb_Apprartus_Name.Name = "Cb_Apprartus_Name";
            this.Cb_Apprartus_Name.Size = new System.Drawing.Size(242, 26);
            this.Cb_Apprartus_Name.TabIndex = 3;
            this.Cb_Apprartus_Name.WaterText = "";
            // 
            // Tb_Borrow_Number
            // 
            this.Tb_Borrow_Number.Location = new System.Drawing.Point(162, 105);
            this.Tb_Borrow_Number.Name = "Tb_Borrow_Number";
            this.Tb_Borrow_Number.Size = new System.Drawing.Size(242, 25);
            this.Tb_Borrow_Number.TabIndex = 4;
            // 
            // Tb_User
            // 
            this.Tb_User.Location = new System.Drawing.Point(162, 195);
            this.Tb_User.Name = "Tb_User";
            this.Tb_User.Size = new System.Drawing.Size(242, 25);
            this.Tb_User.TabIndex = 5;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel4.Location = new System.Drawing.Point(34, 268);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(112, 27);
            this.skinLabel4.TabIndex = 6;
            this.skinLabel4.Text = "借用人电话";
            // 
            // Tb_Phone
            // 
            this.Tb_Phone.Location = new System.Drawing.Point(162, 273);
            this.Tb_Phone.Name = "Tb_Phone";
            this.Tb_Phone.Size = new System.Drawing.Size(242, 25);
            this.Tb_Phone.TabIndex = 7;
            // 
            // Bt_Add
            // 
            this.Bt_Add.BackColor = System.Drawing.Color.Transparent;
            this.Bt_Add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Bt_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Add.DownBack = null;
            this.Bt_Add.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.Bt_Add.Location = new System.Drawing.Point(149, 464);
            this.Bt_Add.MouseBack = null;
            this.Bt_Add.Name = "Bt_Add";
            this.Bt_Add.NormlBack = null;
            this.Bt_Add.Size = new System.Drawing.Size(255, 48);
            this.Bt_Add.TabIndex = 8;
            this.Bt_Add.Text = "添加";
            this.Bt_Add.UseVisualStyleBackColor = false;
            this.Bt_Add.Click += new System.EventHandler(this.Bt_Add_Click);
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel5.Location = new System.Drawing.Point(34, 408);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(92, 27);
            this.skinLabel5.TabIndex = 9;
            this.skinLabel5.Text = "归还时间";
            // 
            // Dtp_ReturnDate
            // 
            this.Dtp_ReturnDate.CustomFormat = "yyyy/MM/dd";
            this.Dtp_ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_ReturnDate.Location = new System.Drawing.Point(162, 410);
            this.Dtp_ReturnDate.Name = "Dtp_ReturnDate";
            this.Dtp_ReturnDate.Size = new System.Drawing.Size(242, 25);
            this.Dtp_ReturnDate.TabIndex = 13;
            
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.skinLabel6.Location = new System.Drawing.Point(34, 338);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(92, 27);
            this.skinLabel6.TabIndex = 14;
            this.skinLabel6.Text = "借用时间";
            // 
            // Dtp_BorrowDate
            // 
            this.Dtp_BorrowDate.CustomFormat = "yyyy/MM/dd hh:mm tt";
            this.Dtp_BorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_BorrowDate.Location = new System.Drawing.Point(162, 339);
            this.Dtp_BorrowDate.Name = "Dtp_BorrowDate";
            this.Dtp_BorrowDate.Size = new System.Drawing.Size(242, 25);
            this.Dtp_BorrowDate.TabIndex = 15;
            // 
            // Bt_AlterDate
            // 
            this.Bt_AlterDate.BackColor = System.Drawing.Color.Transparent;
            this.Bt_AlterDate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Bt_AlterDate.DownBack = null;
            this.Bt_AlterDate.Location = new System.Drawing.Point(410, 339);
            this.Bt_AlterDate.MouseBack = null;
            this.Bt_AlterDate.Name = "Bt_AlterDate";
            this.Bt_AlterDate.NormlBack = null;
            this.Bt_AlterDate.Size = new System.Drawing.Size(134, 26);
            this.Bt_AlterDate.TabIndex = 16;
            this.Bt_AlterDate.Text = "修改默认时间";
            this.Bt_AlterDate.UseVisualStyleBackColor = false;
            this.Bt_AlterDate.Click += new System.EventHandler(this.Bt_AlterDate_Click);
            // 
            // Time1
            // 
            this.Time1.Enabled = true;
            this.Time1.Tick += new System.EventHandler(this.Time1_Tick_1);
            // 
            // AddBorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 524);
            this.Controls.Add(this.Bt_AlterDate);
            this.Controls.Add(this.Dtp_BorrowDate);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.Dtp_ReturnDate);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.Bt_Add);
            this.Controls.Add(this.Tb_Phone);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.Tb_User);
            this.Controls.Add(this.Tb_Borrow_Number);
            this.Controls.Add(this.Cb_Apprartus_Name);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBorrowForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.AddBorrowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinComboBox Cb_Apprartus_Name;
        private System.Windows.Forms.TextBox Tb_Borrow_Number;
        private System.Windows.Forms.TextBox Tb_User;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private System.Windows.Forms.TextBox Tb_Phone;
        private CCWin.SkinControl.SkinButton Bt_Add;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private System.Windows.Forms.DateTimePicker Dtp_ReturnDate;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private System.Windows.Forms.DateTimePicker Dtp_BorrowDate;
        private CCWin.SkinControl.SkinButton Bt_AlterDate;
        private System.Windows.Forms.Timer Time1;
    }
}