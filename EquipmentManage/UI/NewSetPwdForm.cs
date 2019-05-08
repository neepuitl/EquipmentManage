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
    public partial class NewSetPwdForm : Form
    {
        string Pwd;
        public NewSetPwdForm(string pwd)
        {
            Pwd = pwd;
            InitializeComponent();
        }

        private void NewSetPwdForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SkinButton1_Click(object sender, EventArgs e)
        {
            int Rows = 0;
            if (BLL.BLL.Set_Login_Pwd_Test(Pwd) == true)
            {
                Rows = DAL.DAL.Execute(DAL.DAL.InsertString("UserSet", "(Pwd,ExcelRoute,ApparatusType,ApparatusName)", "(@Pwd,@ExcelRoute,@ApparatusType,@ApparatusName)"),
                    new SqlParameter(@"Pwd", SkinTextBox3.Text.Trim()),
                    new SqlParameter(@"ExcelRoute", string.Empty),
                    new SqlParameter(@"ApparatusType", string.Empty),
                    new SqlParameter(@"ApparatusName", string.Empty));
                if (Rows > 0)
                {
                    MessageBox.Show("请重新登录！","修改密码成功", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
           
        }
    }
}
