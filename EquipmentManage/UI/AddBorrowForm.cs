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
    public partial class AddBorrowForm : Form
    {
        int click = 0;
        string Pwd;
        public delegate void Dataview();//定义委托
        public event Dataview Update_Dgv_Add;//定义委托事件
        public AddBorrowForm(string number)
        {
            
            Pwd = number;
            InitializeComponent();
        }

        private void AddBorrowForm_Load(object sender, EventArgs e)
        {
            Cb_Apprartus_Name.DataSource = BLL.BLL.Apparatus_Name(Pwd);
        }

        private void Bt_Add_Click(object sender, EventArgs e)
        {
            if (Tb_Borrow_Number.Text.Trim() != string.Empty)
            {
                if (Tb_User.Text.Trim() != string.Empty)
                {
                    if (Tb_Phone.Text.Trim() != string.Empty)
                    {
                        string[] borrowdate = Dtp_BorrowDate.Text.Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries);
                        string[] borrowlongdate = borrowdate[0].Split(new char[] { '/'},StringSplitOptions.RemoveEmptyEntries);
                        string borrowyear = borrowlongdate[0];//借用时间的日
                        string borrowmonth = borrowlongdate[1];//借用时间的月
                        string borrowday = borrowlongdate[2];//借用时间的年
                        string[] returnlongdate = Dtp_ReturnDate.Text.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                        string returnyear = returnlongdate[0];//归还时间的年
                        string returnmonth = returnlongdate[1];//归还时间的月
                        string returnday = returnlongdate[2];//归还时间的日

                        if (Int32.Parse(returnyear) > Int32.Parse(borrowyear)|| Int32.Parse(returnyear) == Int32.Parse(borrowyear))
                        {
                           
                                //月份相同时比较日
                                if (Int32.Parse(returnmonth) == Int32.Parse(borrowmonth))
                                {
                                    if (Int32.Parse(returnday) >= Int32.Parse(borrowday))
                                    {
                                     int rows=BLL.BLL.Add_Borrow(Cb_Apprartus_Name.Text,Dtp_BorrowDate.Text,Tb_Borrow_Number.Text.Trim(),Dtp_ReturnDate.Text,Tb_User.Text.Trim(),Tb_Phone.Text.Trim());
                                    if (rows > 0) MessageBox.Show("添加成功");
                                    click = 0;
                                    Time1.Enabled = true;
                                    Bt_AlterDate.Text = "修改默认时间";
                                    Dtp_ReturnDate.Text = DateTime.Now.ToShortDateString();
                                    Update_Dgv_Add();//触发控件，刷新data控件
                                    Clear_Add();//清除控件中的值，获得焦距。
                                    }
                                    else MessageBox.Show("请重新设置归还时间！", "归还时间不正确");
                                }
                                //月份大于时直接添加
                                else if(Int32.Parse(returnmonth) > Int32.Parse(borrowmonth))
                                {
                                int rows = BLL.BLL.Add_Borrow(Cb_Apprartus_Name.Text, Dtp_BorrowDate.Text, Tb_Borrow_Number.Text.Trim(), Dtp_ReturnDate.Text, Tb_User.Text.Trim(), Tb_Phone.Text.Trim());
                                if (rows > 0) MessageBox.Show("添加成功");
                                click = 0;
                                Time1.Enabled = true;
                                Bt_AlterDate.Text = "修改默认时间";
                                Dtp_ReturnDate.Text = DateTime.Now.ToShortDateString();
                                Update_Dgv_Add();//触发控件，刷新data控件
                                Clear_Add();//清除控件中的值，获得焦距。
                            }
                                else MessageBox.Show("请重新设置归还时间！", "归还时间不正确");
                        }
                        else MessageBox.Show("请重新设置归还时间！", "归还时间不正确");

                    }
                    else MessageBox.Show("借用数量不能为空！","添加失败");
                }
                else MessageBox.Show("借用人姓名不能为空！","添加失败");
            }
            else MessageBox.Show("借用数量不能为空！", "添加失败");
        }

        private void Bt_AlterDate_Click(object sender, EventArgs e)
        {
            
            if (click % 2 == 0)
            {
                Time1.Enabled = false;
                Bt_AlterDate.Text = "恢复默认时间";
                click++;
            }
            else
            {
                Time1.Enabled = true;
                Bt_AlterDate.Text = "修改默认时间";
                click++;
            }
        }
        
        //时刻更新借用时间
        private void Time1_Tick_1(object sender, EventArgs e)
        {
            Dtp_BorrowDate.Text = DateTime.Now.ToString();
        }
        //添加后，清除控件中的值，方便下次添加
        private void Clear_Add()
        {
            Cb_Apprartus_Name.Focus();
            Tb_Phone.Text = string.Empty;
            Tb_User.Text = string.Empty;
            Tb_Borrow_Number.Text = string.Empty;
        }

       
    }
}
