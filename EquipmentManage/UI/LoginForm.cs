using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EquipmentManage.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Bt_Exite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bt_Login_Click(object sender, EventArgs e)
        {
            
            if (BLL.BLL.Login_Pwd(Tb_Pwd.Text.Trim()) == true)
            {
                this.Hide();
                MainForm mainForm = new MainForm(Tb_Pwd.Text.Trim());
                mainForm.Show();
            }
            else MessageBox.Show("密码错误！", "登录失败");

        }
        
    }
}
