namespace EquipmentManage.UI
{
    partial class EditSingleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSingleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Cb_Apprartus_Name = new CCWin.SkinControl.SkinComboBox();
            this.Dtp_BorrowDate = new System.Windows.Forms.DateTimePicker();
            this.Dtp_ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.Bt_Add = new CCWin.SkinControl.SkinButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "器械名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(50, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "借用时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(50, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "借用数量";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 28);
            this.textBox3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(50, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "归还时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(50, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "借用人";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(149, 292);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(216, 28);
            this.textBox5.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(50, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "联系电话";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(149, 354);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(216, 28);
            this.textBox6.TabIndex = 12;
            // 
            // Cb_Apprartus_Name
            // 
            this.Cb_Apprartus_Name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cb_Apprartus_Name.FormattingEnabled = true;
            this.Cb_Apprartus_Name.Location = new System.Drawing.Point(149, 44);
            this.Cb_Apprartus_Name.Name = "Cb_Apprartus_Name";
            this.Cb_Apprartus_Name.Size = new System.Drawing.Size(216, 29);
            this.Cb_Apprartus_Name.TabIndex = 13;
            this.Cb_Apprartus_Name.WaterText = "";
            // 
            // Dtp_BorrowDate
            // 
            this.Dtp_BorrowDate.CustomFormat = "yyyy/MM/dd hh:mm tt";
            this.Dtp_BorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_BorrowDate.Location = new System.Drawing.Point(149, 106);
            this.Dtp_BorrowDate.Name = "Dtp_BorrowDate";
            this.Dtp_BorrowDate.Size = new System.Drawing.Size(216, 28);
            this.Dtp_BorrowDate.TabIndex = 16;
            // 
            // Dtp_ReturnDate
            // 
            this.Dtp_ReturnDate.CustomFormat = "yyyy/MM/dd";
            this.Dtp_ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_ReturnDate.Location = new System.Drawing.Point(149, 230);
            this.Dtp_ReturnDate.Name = "Dtp_ReturnDate";
            this.Dtp_ReturnDate.Size = new System.Drawing.Size(216, 28);
            this.Dtp_ReturnDate.TabIndex = 17;
            // 
            // Bt_Add
            // 
            this.Bt_Add.BackColor = System.Drawing.Color.Transparent;
            this.Bt_Add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Bt_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Add.DownBack = null;
            this.Bt_Add.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.Bt_Add.Location = new System.Drawing.Point(170, 407);
            this.Bt_Add.MouseBack = null;
            this.Bt_Add.Name = "Bt_Add";
            this.Bt_Add.NormlBack = null;
            this.Bt_Add.Size = new System.Drawing.Size(130, 48);
            this.Bt_Add.TabIndex = 18;
            this.Bt_Add.Text = "确认修改";
            this.Bt_Add.UseVisualStyleBackColor = false;
            this.Bt_Add.Click += new System.EventHandler(this.Bt_Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bt_Add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Dtp_ReturnDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Dtp_BorrowDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Cb_Apprartus_Name);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(35, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 473);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改单个行";
            // 
            // EditSingleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 518);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSingleForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改单个行";
            this.Load += new System.EventHandler(this.EditSingleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private CCWin.SkinControl.SkinComboBox Cb_Apprartus_Name;
        private System.Windows.Forms.DateTimePicker Dtp_BorrowDate;
        private System.Windows.Forms.DateTimePicker Dtp_ReturnDate;
        private CCWin.SkinControl.SkinButton Bt_Add;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}