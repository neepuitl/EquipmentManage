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
    public partial class SetForm : Form
    {
        string Pwd;
        
        public SetForm(string number)
        {
            Pwd = number;
            InitializeComponent();
        }

        private void SetForm_Load(object sender, EventArgs e)
        {
            
            Tb_path.Text = BLL.BLL.Read_User_Set(Pwd, "ExcelRoute");
            if(BLL.BLL.Read_User_Set(Pwd, "ApparatusType") != string.Empty)
            {
                Tb_Apparatus_Type.Text = BLL.BLL.Read_User_Set(Pwd, "ApparatusType");
                Tb_Apparatus_Type.ReadOnly = true;
            }
            string[] items = BLL.BLL.Read_User_Set(Pwd, "ApparatusName").Trim().Split(new char []{ '.'},StringSplitOptions.RemoveEmptyEntries);//移除split方法产生的空格
            foreach (string  item in items)
            {
                listBox1.Items.Add(item);
            }
            

        }

        private void Bt_Select_Path_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                this.Tb_path.Text = folder.SelectedPath;
            }
        }
        //添加器械名称到listbox1
        private void Bt_Add_Apparatus_name_Click(object sender, EventArgs e)
        {
            if (Tb_Apparatus_Type.Text.Trim()!= string.Empty)
            {
                if (Tb_Apparatus_Name.Text.Trim() != string.Empty)
                {
                    listBox1.Items.Add(Tb_Apparatus_Name.Text);
                    Tb_Apparatus_Type.ReadOnly = true;
                    Tb_Apparatus_Name.Text = string.Empty;
                    Tb_Apparatus_Name.Focus();
                }
                else MessageBox.Show("添加器械名称不能为空！","添加失败");
            }
            else
            {
                MessageBox.Show("器械类型不能为空！","请设置器械类型");
                Tb_Apparatus_Type.Focus();
            }
        }
        //移除已将添加的器械名称
        private void Bt_Remove_Click(object sender, EventArgs e)
        {

            listBox1.Items.Remove(listBox1.SelectedItem);
        }
        //修改器械类型
        private void Bt_Alter_Type_Click(object sender, EventArgs e)
        {
            Tb_Apparatus_Type.ReadOnly = false;
            listBox1.Items.Clear();
            Tb_Apparatus_Type.Focus();
            
        }
        //添加器械
        private void Bt_Add_Set(object sender, EventArgs e)
        {

            List<string> name = new List<string>();
            if (listBox1.Items.Count > 0)
            {
               
                foreach (string item in listBox1.Items)
                {
                    name.Add(item);
                }
                if (Tb_Apparatus_Type.Text.Trim() != BLL.BLL.Read_User_Set(Pwd, "ApparatusType"))
                {

                    DialogResult result = MessageBox.Show("您在更改器械类型，这将会清空从前的数据！单击是，清空数据(建议您生成excel表后再清空)", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        BLL.BLL.DeleteTable();
                        BLL.BLL.Add_set(Pwd, name, Tb_Apparatus_Type.Text.Trim(), Tb_path.Text);
                        MessageBox.Show("设置成功！");
                        this.Close();
                    }
                }
                else if(Tb_Apparatus_Type.Text.Trim() == BLL.BLL.Read_User_Set(Pwd, "ApparatusType"))
                {
                    BLL.BLL.Add_set(Pwd, name, Tb_Apparatus_Type.Text.Trim(), Tb_path.Text);
                    MessageBox.Show("设置成功！");
                    this.Close();
                }
            }
            else MessageBox.Show("器械名称至少大于1项！","设置失败");
        }
    }
}
