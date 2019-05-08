using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace EquipmentManage.UI
{
    public partial class MainForm : Form
    {
        string Pwd;
        public MainForm(string number)
        {
            Pwd = number;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            toolStrip1.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "今日借用信息";
            Dgv.Visible = true;
            Dgv.DataSource = BLL.BLL.Dgv_Source(DAL.DAL.SelectString("*", "TodayBorrow", string.Empty));
            Dgv.Columns[0].Visible = false;
            Dgv.Columns[1].HeaderCell.Value = "器械名称";
            Dgv.Columns[2].HeaderCell.Value = "借用时间";
            Dgv.Columns[3].HeaderCell.Value = "借用数量";
            Dgv.Columns[4].HeaderCell.Value = "归还时间";
            Dgv.Columns[5].HeaderCell.Value = "借用人";
            Dgv.Columns[6].HeaderCell.Value = "联系电话";

            if (BLL.BLL.Set_Login_Pwd_Test(Pwd) == true)
            {
                MessageBox.Show("初次使用设置密码！", "安全提示");
                NewSetPwdForm newSetPwdForm = new NewSetPwdForm(Pwd);
                newSetPwdForm.ShowDialog();
            }
            if (BLL.BLL.Set_Login_Test(Pwd) == false)
            {
                MessageBox.Show("初次使用，请设置软件设置！");
                SetForm setForm = new SetForm(Pwd);
                setForm.ShowDialog();
            }


        }

        private void 添加借用信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddBorrowForm addBorrowForm = new AddBorrowForm(Pwd);
            //编辑后刷新今日借用信息
            addBorrowForm.Update_Dgv_Add += new AddBorrowForm.Dataview(Update_Dgv_Today);
            addBorrowForm.ShowDialog();


        }

        private void 今日借用信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            toolStrip1.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "今日借用信息";
            Dgv.Visible = true;
            Dgv.DataSource = BLL.BLL.Dgv_Source(DAL.DAL.SelectString("*", "TodayBorrow", string.Empty));
            Dgv.Columns[0].Visible = false;
            Dgv.Columns[1].HeaderCell.Value = "器械名称";
            Dgv.Columns[2].HeaderCell.Value = "借用时间";
            Dgv.Columns[3].HeaderCell.Value = "借用数量";
            Dgv.Columns[4].HeaderCell.Value = "归还时间";
            Dgv.Columns[5].HeaderCell.Value = "借用人";
            Dgv.Columns[6].HeaderCell.Value = "联系电话";

        }

        private void 往日借用信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "往日借用信息";
            Dgv.Visible = true;
            Dgv.DataSource = BLL.BLL.Dgv_Source(DAL.DAL.SelectString("*", "YesterdayBorrow", string.Empty));
            Dgv.Columns[0].Visible = false;
            Dgv.Columns[1].HeaderCell.Value = "器械名称";
            Dgv.Columns[2].HeaderCell.Value = "借用时间";
            Dgv.Columns[3].HeaderCell.Value = "借用数量";
            Dgv.Columns[4].HeaderCell.Value = "归还时间";
            Dgv.Columns[5].HeaderCell.Value = "借用人";
            Dgv.Columns[6].HeaderCell.Value = "联系电话";

        }

        private void 未归还记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            Dgv.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "未归还记录";
            Dgv.DataSource = BLL.BLL.Dgv_Source(DAL.DAL.SelectString("*", "NoReturnRecord", string.Empty));
            Dgv.Columns[0].Visible = false;
            Dgv.Columns[1].HeaderCell.Value = "器械名称";
            Dgv.Columns[2].HeaderCell.Value = "借用时间";
            Dgv.Columns[3].HeaderCell.Value = "借用数量";
            Dgv.Columns[4].HeaderCell.Value = "归还时间";
            Dgv.Columns[5].HeaderCell.Value = "借用人";
            Dgv.Columns[6].HeaderCell.Value = "联系电话";

        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPwdForm setPwd = new SetPwdForm(Pwd);
            setPwd.ShowDialog();
        }

        private void 设置器械类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm setForm = new SetForm(Pwd);
            setForm.ShowDialog();
        }


        //修改单个单元格
        private void Bt_Single_Click(object sender, EventArgs e)
        {
            string table = string.Empty;
            if (groupBox1.Text == "今日借用信息")
            {
                table = "TodayBorrow";
            }
            if (groupBox1.Text == "往日借用信息")
            {
                table = "YesterdayBorrow";
            }
            if (groupBox1.Text == "未归还记录")
            {
                table = "NoReturnRecord";
            }

            if (Dgv.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(Dgv.SelectedRows[0].Cells[0].Value);
                EditSingleForm editSingleForm = new EditSingleForm(Pwd, id.ToString(), table);
                //编辑后刷新今日借用信息
                if (table == "TodayBorrow")
                {
                    editSingleForm.Update_Dgv_Edit += new EditSingleForm.Dataview(Update_Dgv_Today);
                    editSingleForm.ShowDialog();
                }
                //编辑后刷新往日借用信息
                if (table == "YesterdayBorrow")
                {
                    editSingleForm.Update_Dgv_Edit += new EditSingleForm.Dataview(Update_Dgv_Yesterday);
                    editSingleForm.ShowDialog();
                }
                //编辑后刷新为归还记录
                if (table == "NoReturnRecord")
                {
                    editSingleForm.Update_Dgv_Edit += new EditSingleForm.Dataview(Update_Dgv_NoReturnBorrow);
                    editSingleForm.ShowDialog();
                }

            }
            else MessageBox.Show("请选中要编辑的行！");
        }

        //删除单行数据
        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            string table = string.Empty;
            if (groupBox1.Text == "今日借用信息")
            {
                table = "TodayBorrow";
            }
            if (groupBox1.Text == "往日借用信息")
            {
                table = "YesterdayBorrow";
            }
            if (groupBox1.Text == "未归还记录")
            {
                table = "NoReturnRecord";
            }
           
            if (Dgv.SelectedRows.Count == 1)
            {

                
                DialogResult result = MessageBox.Show("是否要修改当前行中单元格的内容?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(Dgv.SelectedRows[0].Cells[0].Value);
                    BLL.BLL.Delete_Row(id.ToString(), table);
                }
                if (groupBox1.Text == "今日借用信息")
                {
                    Update_Dgv_Today();//更新今日借用信息
                }
                if (groupBox1.Text == "往日借用信息")
                {
                    Update_Dgv_Yesterday();//更新往日借用信息
                }
                if (groupBox1.Text == "未归还记录")
                {
                    Update_Dgv_NoReturnBorrow();//更新未归还记录
                }
            }
            //删除多行数据
            else if (Dgv.SelectedRows.Count > 1)
            {

                DialogResult result = MessageBox.Show("是否要修改当前选中的内容?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < Dgv.SelectedRows.Count; i++)
                    {

                        int id = Convert.ToInt32(Dgv.SelectedRows[i].Cells[0].Value);
                        BLL.BLL.Delete_Row(id.ToString(), table);
                    }
                }
                if (groupBox1.Text == "今日借用信息")
                {
                    Update_Dgv_Today();//更新今日借用信息
                }
                if (groupBox1.Text == "往日借用信息")
                {
                    Update_Dgv_Yesterday();//更新往日借用信息
                }
                if (groupBox1.Text == "未归还记录")
                {
                    Update_Dgv_NoReturnBorrow();//更新未归还记录
                }


            }
            else MessageBox.Show("请选中要删除的行！");
        }
        //用于更新今日借用信息
        private void Update_Dgv_Today()
        {

            toolStrip1.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "今日借用信息";
            Dgv.Visible = true;
            Dgv.DataSource = BLL.BLL.Dgv_Source(DAL.DAL.SelectString("*", "TodayBorrow", string.Empty));
            Dgv.Columns[0].Visible = false;
            Dgv.Columns[1].HeaderCell.Value = "器械名称";
            Dgv.Columns[2].HeaderCell.Value = "借用时间";
            Dgv.Columns[3].HeaderCell.Value = "借用数量";
            Dgv.Columns[4].HeaderCell.Value = "归还时间";
            Dgv.Columns[5].HeaderCell.Value = "借用人";
            Dgv.Columns[6].HeaderCell.Value = "联系电话";
        }

        //用于更新昨日借用借用信息
        private void Update_Dgv_Yesterday()
        {

            toolStrip1.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "往日借用信息";
            Dgv.Visible = true;
            Dgv.DataSource = BLL.BLL.Dgv_Source(DAL.DAL.SelectString("*", "YesterdayBorrow", string.Empty));
            Dgv.Columns[0].Visible = false;
            Dgv.Columns[1].HeaderCell.Value = "器械名称";
            Dgv.Columns[2].HeaderCell.Value = "借用时间";
            Dgv.Columns[3].HeaderCell.Value = "借用数量";
            Dgv.Columns[4].HeaderCell.Value = "归还时间";
            Dgv.Columns[5].HeaderCell.Value = "借用人";
            Dgv.Columns[6].HeaderCell.Value = "联系电话";

        }
        //用于更新为归还记录
        private void Update_Dgv_NoReturnBorrow()
        {

            toolStrip1.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "为归还记录";
            Dgv.Visible = true;
            Dgv.DataSource = BLL.BLL.Dgv_Source(DAL.DAL.SelectString("*", "NoReturnRecord", string.Empty));
            Dgv.Columns[0].Visible = false;
            Dgv.Columns[1].HeaderCell.Value = "器械名称";
            Dgv.Columns[2].HeaderCell.Value = "借用时间";
            Dgv.Columns[3].HeaderCell.Value = "借用数量";
            Dgv.Columns[4].HeaderCell.Value = "归还时间";
            Dgv.Columns[5].HeaderCell.Value = "借用人";
            Dgv.Columns[6].HeaderCell.Value = "联系电话";
        }
        //返回当前记录表
        private void Tb_Return_Click(object sender, EventArgs e)
        {
            if (groupBox1.Text == "今日借用信息")
            {
                Update_Dgv_Today();//更新今日借用信息
            }
            if (groupBox1.Text == "往日借用信息")
            {
                Update_Dgv_Yesterday();//更新往日借用信息
            }
            if (groupBox1.Text == "未归还记录")
            {
                Update_Dgv_NoReturnBorrow();//更新未归还记录
            }
        }

        //time控件，时时将添加的记录分类
        private void timer1_Tick(object sender, EventArgs e)
        {
            BLL.BLL.Test_TodayBorrow();
            BLL.BLL.Test_YesterdayBorrow();
        }
        //搜索当前表格中的信息，用名字搜索
        private void Bt_Search_Click(object sender, EventArgs e)
        {
            if (groupBox1.Text == "今日借用信息")
            {
                Dgv.DataSource = BLL.BLL.Search_nowTable("TodayBorrow", Tb_search.Text.Trim());//搜索今日借用信息
            }
            if (groupBox1.Text == "往日借用信息")
            {
                Dgv.DataSource = BLL.BLL.Search_nowTable("YesterdayBorrow", Tb_search.Text.Trim());//搜索往日借用信息
            }
            if (groupBox1.Text == "未归还记录")
            {
                Dgv.DataSource = BLL.BLL.Search_nowTable("NoReturnRecord", Tb_search.Text.Trim());//搜索未归还记录
            }


        }


        //将当前表格生成Excle表格 
        private void 生成Excel表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLL.BLL.Create_excel(BLL.BLL.Read_User_Set(Pwd, "ExcelRoute"));
        }

        private void 清空数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Tb_Apparatus_Name.Text.Trim() != BLL.BLL.Read_User_Set(Pwd, "ApparatusType"))
            //{

            //    DialogResult result = MessageBox.Show("您在更改器械类型，这将会清空从前的数据！单击是，清空数据(建议您生成excel表后再清空)", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if (result == DialogResult.Yes)
            //    {
            //        if(BLL.BLL.DeleteTable()==true)
            //            MessageBox.Show();
            //    }
            //}
        }
        //关闭软件所有进程
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }


}
