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
    public partial class EditSingleForm : Form
    {
        string Pwd;
        string Id;
        string tableName;
        public delegate void Dataview();//定义委托
        public event Dataview Update_Dgv_Edit;//定义委托事件
        
        public EditSingleForm(string pwd, string id, string table)
        {
            Pwd = pwd;
            Id = id;
            tableName = table;
            InitializeComponent();
        }

        private void EditSingleForm_Load(object sender, EventArgs e)
        {
            Cb_Apprartus_Name.DataSource = BLL.BLL.Apparatus_Name(Pwd);
            Cb_Apprartus_Name.Text = BLL.BLL.Edit_String(Id, tableName)[0];
            Dtp_BorrowDate.Text = BLL.BLL.Edit_String(Id, tableName)[1];
            textBox3.Text = BLL.BLL.Edit_String(Id, tableName)[2];
            Dtp_ReturnDate.Text = BLL.BLL.Edit_String(Id, tableName)[3];
            textBox5.Text = BLL.BLL.Edit_String(Id, tableName)[4];
            textBox6.Text = BLL.BLL.Edit_String(Id, tableName)[5];
        }

        private void Bt_Add_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim() != string.Empty)
            {
                if (textBox5.Text.Trim() != string.Empty)
                {
                    if (textBox6.Text.Trim() != string.Empty)
                    {
                        string[] borrowdate = Dtp_BorrowDate.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        string[] borrowlongdate = borrowdate[0].Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                        string borrowyear = borrowlongdate[0];//借用时间的日
                        string borrowmonth = borrowlongdate[1];//借用时间的月
                        string borrowday = borrowlongdate[2];//借用时间的年
                        string[] returnlongdate = Dtp_ReturnDate.Text.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                        string returnyear = returnlongdate[0];//归还时间的年
                        string returnmonth = returnlongdate[1];//归还时间的月
                        string returnday = returnlongdate[2];//归还时间的日

                        if (Int32.Parse(returnyear) > Int32.Parse(borrowyear) || Int32.Parse(returnyear) == Int32.Parse(borrowyear))
                        {

                            //月份相同时比较日
                            if (Int32.Parse(returnmonth) == Int32.Parse(borrowmonth))
                            {
                                if (Int32.Parse(returnday) >= Int32.Parse(borrowday))
                                {
                                    int rows = BLL.BLL.Edit_Borrow(Cb_Apprartus_Name.Text, Dtp_BorrowDate.Text, textBox3.Text.Trim(), Dtp_ReturnDate.Text, textBox5.Text.Trim(), textBox6.Text.Trim(), Id,tableName);
                                    if (rows > 0) MessageBox.Show("修改成功！");
                                    Update_Dgv_Edit();
                                    this.Close();
                                }
                                else MessageBox.Show("请重新设置归还时间！", "归还时间不正确");
                            }
                            //月份大于时直接添加
                            else if (Int32.Parse(returnmonth) > Int32.Parse(borrowmonth))
                            {
                                int rows = BLL.BLL.Edit_Borrow(Cb_Apprartus_Name.Text, Dtp_BorrowDate.Text, textBox3.Text.Trim(), Dtp_ReturnDate.Text, textBox5.Text.Trim(), textBox6.Text.Trim(), Id,tableName);
                                if (rows > 0) MessageBox.Show("修改成功！");
                                Update_Dgv_Edit();
                                this.Close();
                            }
                            else MessageBox.Show("请重新设置归还时间！", "归还时间不正确");
                        }
                        else MessageBox.Show("请重新设置归还时间！", "归还时间不正确");

                    }
                    else MessageBox.Show("借用数量不能为空！", "修改失败");
                }
                else MessageBox.Show("借用人姓名不能为空！", "修改失败");
            }
            else MessageBox.Show("借用数量不能为空！", "修改失败");
        }
    }
}
