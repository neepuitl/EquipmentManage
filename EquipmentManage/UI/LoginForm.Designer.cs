namespace EquipmentManage.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Bt_Exite = new CCWin.SkinControl.SkinButton();
            this.Bt_Login = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.Tb_Pwd = new CCWin.SkinControl.SkinTextBox();
            this.SuspendLayout();
            // 
            // Bt_Exite
            // 
            this.Bt_Exite.BackColor = System.Drawing.Color.Transparent;
            this.Bt_Exite.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Bt_Exite.DownBack = null;
            this.Bt_Exite.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bt_Exite.Location = new System.Drawing.Point(190, 128);
            this.Bt_Exite.MouseBack = null;
            this.Bt_Exite.Name = "Bt_Exite";
            this.Bt_Exite.NormlBack = null;
            this.Bt_Exite.Size = new System.Drawing.Size(93, 33);
            this.Bt_Exite.TabIndex = 9;
            this.Bt_Exite.Text = "退出";
            this.Bt_Exite.UseVisualStyleBackColor = false;
            this.Bt_Exite.Click += new System.EventHandler(this.Bt_Exite_Click);
            // 
            // Bt_Login
            // 
            this.Bt_Login.BackColor = System.Drawing.Color.Transparent;
            this.Bt_Login.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Bt_Login.DownBack = null;
            this.Bt_Login.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bt_Login.Location = new System.Drawing.Point(16, 128);
            this.Bt_Login.MouseBack = null;
            this.Bt_Login.Name = "Bt_Login";
            this.Bt_Login.NormlBack = null;
            this.Bt_Login.Size = new System.Drawing.Size(93, 33);
            this.Bt_Login.TabIndex = 8;
            this.Bt_Login.Text = "登录";
            this.Bt_Login.UseVisualStyleBackColor = false;
            this.Bt_Login.Click += new System.EventHandler(this.Bt_Login_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(12, 61);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(51, 20);
            this.skinLabel2.TabIndex = 7;
            this.skinLabel2.Text = "密码";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("黑体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(73, 9);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(169, 38);
            this.skinLabel1.TabIndex = 6;
            this.skinLabel1.Text = "用户登录";
            // 
            // Tb_Pwd
            // 
            this.Tb_Pwd.BackColor = System.Drawing.Color.Transparent;
            this.Tb_Pwd.DownBack = null;
            this.Tb_Pwd.Icon = null;
            this.Tb_Pwd.IconIsButton = false;
            this.Tb_Pwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.Tb_Pwd.IsPasswordChat = '*';
            this.Tb_Pwd.IsSystemPasswordChar = false;
            this.Tb_Pwd.Lines = new string[0];
            this.Tb_Pwd.Location = new System.Drawing.Point(80, 61);
            this.Tb_Pwd.Margin = new System.Windows.Forms.Padding(0);
            this.Tb_Pwd.MaxLength = 20;
            this.Tb_Pwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.Tb_Pwd.MouseBack = null;
            this.Tb_Pwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.Tb_Pwd.Multiline = false;
            this.Tb_Pwd.Name = "Tb_Pwd";
            this.Tb_Pwd.NormlBack = null;
            this.Tb_Pwd.Padding = new System.Windows.Forms.Padding(5);
            this.Tb_Pwd.ReadOnly = false;
            this.Tb_Pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Tb_Pwd.Size = new System.Drawing.Size(203, 28);
            // 
            // 
            // 
            this.Tb_Pwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_Pwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tb_Pwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.Tb_Pwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.Tb_Pwd.SkinTxt.MaxLength = 20;
            this.Tb_Pwd.SkinTxt.Name = "BaseText";
            this.Tb_Pwd.SkinTxt.PasswordChar = '*';
            this.Tb_Pwd.SkinTxt.Size = new System.Drawing.Size(193, 22);
            this.Tb_Pwd.SkinTxt.TabIndex = 0;
            this.Tb_Pwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Tb_Pwd.SkinTxt.WaterText = "";
            this.Tb_Pwd.TabIndex = 5;
            this.Tb_Pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Tb_Pwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Tb_Pwd.WaterText = "";
            this.Tb_Pwd.WordWrap = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 194);
            this.Controls.Add(this.Bt_Exite);
            this.Controls.Add(this.Bt_Login);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.Tb_Pwd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "器材管理系统";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton Bt_Exite;
        private CCWin.SkinControl.SkinButton Bt_Login;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox Tb_Pwd;
    }
}