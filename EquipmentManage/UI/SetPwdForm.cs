using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentManage.UI
{
    public partial class SetPwdForm : Form
    {
        string Pwd;
        public SetPwdForm(string pwd)
        {
            Pwd = pwd;
            InitializeComponent();
        }

        private void SetPwdForm_Load(object sender, EventArgs e)
        {

        }

        private void SkinButton1_Click(object sender, EventArgs e)
        {

            if (BLL.BLL.Login_Pwd(SkinTextBox1.Text.Trim()) == true)
            {

                if (SkinTextBox2.Text.Trim() == SkinTextBox3.Text.Trim())
                {
                    if (SkinTextBox2.Text.Trim().Length < 6)
                    {
                        MessageBox.Show("密码长度不能小于6！");
                    }
                    else
                    {
                        if (SkinTextBox2.Text.Trim() == string.Empty)
                        {
                            MessageBox.Show("密码不能设置为空！");
                        }
                        else
                        {

                            int Rows = DAL.DAL.Execute(DAL.DAL.UpdateString("UserSet", "Pwd=@pwd2", "Pwd=@pwd1"),
                      new SqlParameter(@"pwd1", SkinTextBox1.Text.Trim()),
                      new SqlParameter(@"pwd2", SkinTextBox2.Text.Trim()));
                            if (Rows > 0)
                            {
                                MessageBox.Show("修改密码成功，请重新登录！","修改成功",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                Application.Exit();
                            }

                        }
                    }

                }
                else MessageBox.Show("设置的新密码不一致！");
            }
            else MessageBox.Show("登录密码不正确！");

        }
    }
}
