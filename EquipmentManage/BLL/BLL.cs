using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Spire.Xls;
using System.Data.OleDb;

namespace EquipmentManage.BLL
{
    class BLL
    {
        /// <summary>
        /// 验证登录密码
        /// </summary>
        /// <param name="pwd">用户输入的密码</param>
        /// <returns>正确返回True，错误返回false</returns>
        public static bool Login_Pwd(string pwd)
        {
            bool loginbool = false;
            string Pwd = string.Empty;
            SqlDataReader reader = DAL.DAL.Reader(DAL.DAL.SelectString("*", "UserSet", string.Empty), null);
            while (reader.Read())
            {
                Pwd = reader["Pwd"].ToString();
            }
            reader.Close();
            if (Pwd == pwd) loginbool = true;
            return loginbool;
        }
        /// <summary>
        /// 返回设置的数组值
        /// </summary>
        /// <param name="pwd">用户登录密码</param>
        /// <returns>设置的数组</returns>
        public static string[] Set_Test_Array(string pwd)
        {
            string[] set = { };
            SqlDataReader reader = DAL.DAL.Reader(DAL.DAL.SelectString("*", "UserSet", "Pwd=@pwd"), new SqlParameter(@"pwd", pwd));
            while (reader.Read())
            {
                set = new string[] { reader["ExcelRoute"].ToString(),
                                    reader["ApparatusType"].ToString(),
                                       reader["ApparatusName"].ToString()};

            }
            return set;
        }
        /// <summary>
        /// 检测密码是否设置为空
        /// </summary>
        /// <param name="pwd">用户登录输入的密码</param>
        /// <returns>密码为空返回true，否则返回false</returns>
        public static bool Set_Login_Pwd_Test(string pwd)
        {
            bool mybool = false;
            string Pwd = string.Empty;
            SqlDataReader reader = DAL.DAL.Reader(DAL.DAL.SelectString("*", "UserSet", "Pwd=@pwd"), new SqlParameter(@"pwd", pwd));
            while (reader.Read())
            {
                Pwd = reader["Pwd"].ToString();
            }
            reader.Close();
            if (Pwd == string.Empty) mybool = true;
            return mybool;
        }
        /// <summary>
        /// 检测用户初次使用是否已经设置好软件设置
        /// </summary>
        /// <param name="pwd">用户登录时输入的密码</param>
        /// <returns>设置好返回true，否则返回false</returns>
        public static bool Set_Login_Test(string pwd)
        {
            bool mybool = false;
            string ExcelRoute = string.Empty;
            string ApparatusType = string.Empty;
            string ApparatusName = string.Empty;
            SqlDataReader reader = DAL.DAL.Reader(DAL.DAL.SelectString("*", "UserSet", "Pwd=@pwd"), new SqlParameter(@"pwd", pwd));
            while (reader.Read())
            {
                ExcelRoute = reader["ExcelRoute"].ToString();
                ApparatusType = reader["ApparatusType"].ToString();
                ApparatusName = reader["ApparaTusName"].ToString();
            }
            reader.Close();
            if (ExcelRoute != string.Empty && ApparatusName != string.Empty && ApparatusName != string.Empty)
                mybool = true;
            return mybool;
        }
        /// <summary>
        /// 修改设置
        /// </summary>
        /// <param name="pwd">用户登录输入的密码</param>
        /// <param name="name">器械名称</param>
        /// <param name="type">器械类型</param>
        /// <param name="path">Excel文件保存路径</param>
        /// <returns>如果设置成功返回true，否则返回false</returns>
        public static bool Add_set(string pwd, List<string> name, string type, string path)
        {
            bool mybool = false;
            string Name = string.Empty;//
            for (int i = 0; i < name.Count; i++)
            {
                Name = name[i] + '.' + Name;
            }
            int rows = DAL.DAL.Execute(DAL.DAL.UpdateString("UserSet", "ApparatusType=@type,ApparatusName=@name,ExcelRoute=@path", "Pwd=@pwd"),
                 new SqlParameter(@"type", type),
                 new SqlParameter(@"name", Name),
                 new SqlParameter(@"path", path),
                 new SqlParameter(@"pwd", pwd));
            if (rows > 0) mybool = true;
            return mybool;

        }
        /// <summary>
        /// 返回设置属性中器械名称数组
        /// </summary>
        /// <param name="pwd">用户输入的密码</param>
        /// <returns>返回器械名称数组</returns>
        public static string[] Apparatus_Name(string pwd)
        {
            string name = string.Empty;
            SqlDataReader reader = DAL.DAL.Reader(DAL.DAL.SelectString("*", "UserSet", "Pwd=@pwd"),
                new SqlParameter(@"pwd", pwd));
            while (reader.Read())
            {
                name = reader["ApparatusName"].ToString();
            }
            reader.Close();
            string[] item = name.Split('.');
            return item;
        }
        /// <summary>
        /// 添加借用信息
        /// </summary>
        /// <param name="ApparatusName">借用器械名称</param>
        /// <param name="BorrowDate">借用日期</param>
        /// <param name="BorrowNumber">借用数量</param>
        /// <param name="ReturnDate">归还日期</param>
        /// <param name="UserName">借用人姓名</param>
        /// <param name="Telephone">借用人电话</param>
        /// <returns>数据库中todayborrow表中影响的行数</returns>
        public static int Add_Borrow(string ApparatusName, string BorrowDate, string BorrowNumber, string ReturnDate, string UserName, string Telephone)
        {
            return DAL.DAL.Execute(DAL.DAL.InsertString("TodayBorrow", "(ApparatusName,BorrowDate,BorrowNumber,ReturnDate,UserName,Telephone)", "(@ApparatusName,@BorrowDate,@BorrowNumber,@ReturnDate,@UserName,@Telephone)"),
                 new SqlParameter(@"ApparatusName", ApparatusName),
                 new SqlParameter(@"BorrowDate", BorrowDate),
                 new SqlParameter(@"BorrowNumber", BorrowNumber),
                 new SqlParameter(@"ReturnDate", ReturnDate),
                 new SqlParameter(@"UserName", UserName),
                 new SqlParameter(@"Telephone", Telephone)
                 );
        }
        /// <summary>
        /// 读取数据库中数据表，返回datetable
        /// </summary>
        /// <param name="sqlstring">读取的SQL语句</param>
        /// <returns>datetable对象</returns>
        public static DataTable Dgv_Source(string sqlstring)
        {
            SqlConnection con = new SqlConnection(DAL.DAL.ConStr);
            DataSet dataSet = new DataSet();
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlstring, con);
                adapter.Fill(dataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return dataSet.Tables[0];
        }
        /// <summary>
        /// 读取用户设置数据
        /// </summary>
        /// <param name="pwd">用户登录输入的密码</param>
        /// <param name="parameter">要读取的属性字符串</param>
        /// <returns>用户设置的属性值</returns>
        public static string Read_User_Set(string pwd, string parameter)
        {
            string value = string.Empty;
            SqlDataReader reader = DAL.DAL.Reader(DAL.DAL.SelectString("*", "UserSet", "Pwd=@pwd"), new SqlParameter(@"pwd", pwd));
            while (reader.Read())
            {
                value = reader[parameter].ToString();
            }
            reader.Close();
            return value;
        }
        /// <summary>
        /// 删除datagridview行记录
        /// </summary>
        /// <param name="id">数据库中行id</param>
        /// <param name="tableName">数据库中要删除行记录的表名</param>
        /// <returns>删除成功返回true，否则返回false</returns>
        public static bool Delete_Row(string id, string tableName)
        {
            bool mybool = false;
            int rows = DAL.DAL.Execute(DAL.DAL.DelectString(tableName, "Id=@Id"), new SqlParameter(@"Id", id));
            if (rows > 0) mybool = true;
            return mybool;
        }
        /// <summary>
        /// 读取数据库中某一表中的单行记录
        /// </summary>
        /// <param name="id">行id</param>
        /// <param name="tableName">table名</param>
        /// <returns>List字符串数组</returns>
        public static List<string> Edit_String(string id, string tableName)
        {
            List<string> str = new List<string>();
            SqlDataReader reader = DAL.DAL.Reader(DAL.DAL.SelectString("*", tableName, "Id=id"), new SqlParameter(@"id", id));
            while (reader.Read())
            {
                str.Add(reader["ApparatusName"].ToString());
                str.Add(reader["BorrowDate"].ToString());
                str.Add(reader["BorrowNumber"].ToString());
                str.Add(reader["ReturnDate"].ToString());
                str.Add(reader["UserName"].ToString());
                str.Add(reader["Telephone"].ToString());
            }
            reader.Close();
            return str;
        }
        /// <summary>
        /// 编辑单一行时，修改值到数据库
        /// </summary>
        /// <param name="ApparatusName">借用器械名称</param>
        /// <param name="BorrowDate">借用日期</param>
        /// <param name="BorrowNumber">借用数量</param>
        /// <param name="ReturnDate">归还日期</param>
        /// <param name="UserName">借用人姓名</param>
        /// <param name="Telephone">借用人电话</param>
        /// <returns>数据库中todayborrow表中影响的行数</returns>
        /// <param name="id">数据库中id的值</param>

        public static int Edit_Borrow(string ApparatusName, string BorrowDate, string BorrowNumber, string ReturnDate, string UserName, string Telephone, string id, string table)
        {
            return DAL.DAL.Execute(DAL.DAL.UpdateString(table, "ApparatusName=@ApparatusName,BorrowDate=@BorrowDate,BorrowNumber=@BorrowNumber,ReturnDate=@ReturnDate,UserName=@UserName,Telephone=@Telephone", "Id=@id"),
                 new SqlParameter(@"ApparatusName", ApparatusName),
                 new SqlParameter(@"BorrowDate", BorrowDate),
                 new SqlParameter(@"BorrowNumber", BorrowNumber),
                 new SqlParameter(@"ReturnDate", ReturnDate),
                 new SqlParameter(@"UserName", UserName),
                 new SqlParameter(@"Telephone", Telephone),
                 new SqlParameter(@"Id", id));
        }
        /// <summary>
        /// 删除数据库中指定表的一行
        /// </summary>
        /// <param name="id">数据库中行id</param>
        /// <param name="table">要删除表中记录的表名</param>
        /// <returns></returns>
        public static int Delete_Borrow(string id, string table)
        {
            return DAL.DAL.Execute(DAL.DAL.DelectString(table, "Id=@id"), new SqlParameter(@"id", id));
        }

        /// <summary>
        /// 检测今日借用表中的数据，将符合条件的记录，添加到往日借用表（Yesterday）中
        /// </summary>
        /// <returns>如果成功返回True，否则返回fasle</returns>
        public static bool Test_TodayBorrow()
        {

             bool mybool = false;
            List<Model.UserBorrow> Data = new List<Model.UserBorrow>();//用来储存符合条件的记录
            SqlDataReader reader = DAL.DAL.Reader(DAL.DAL.SelectString("*", "TodayBorrow", string.Empty), null);
            while (reader.Read())
            {
                Model.UserBorrow data = new Model.UserBorrow
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    ApparatusName = reader["ApparatusName"].ToString(),
                    BorrowDate = reader["BorrowDate"].ToString(),
                    BorrowNumber = reader["BorrowNumber"].ToString(),
                    ReturnDate = reader["Returndate"].ToString(),
                    Telephone = reader["Telephone"].ToString(),
                    UserName = reader["UserName"].ToString()
                };
                string[] todayDate = data.BorrowDate.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);//分割数据库TodayBorrow表中借用日期
                string[] Year_month_day = todayDate[0].Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);//分割借用日期年月日，为数组
                string[] Now_year_month_day = DateTime.Now.ToShortDateString().Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);//分割现在年月日，为数组
                //现在的年份大于借用日期的年份
                if (Int32.Parse(Now_year_month_day[0]) > Int32.Parse(Year_month_day[0]))
                {
                    Data.Add(data);//将符合条件的记录添加到集合
                }
                //年份相同时，比较月份，现在月份大时，直接添加
                if (Int32.Parse(Now_year_month_day[0]) == Int32.Parse(Year_month_day[0]) && Int32.Parse(Now_year_month_day[1]) > Int32.Parse(Year_month_day[1]))
                {
                    Data.Add(data);//将符合条件的记录添加到集合
                   
                }
                //年份、月份相同时，比较日，现在日大时，直接添加
                if (Int32.Parse(Now_year_month_day[0]) == Int32.Parse(Year_month_day[0]) && Int32.Parse(Now_year_month_day[1]) == Int32.Parse(Year_month_day[1]) && Int32.Parse(Now_year_month_day[2]) > Int32.Parse(Year_month_day[2]))
                {

                    Data.Add(data);//将符合条件的记录添加到集合

                }
            }
            reader.Close();
            int insertRows = 0;
            int deleteRows = 0;
            //遍历储存有符合条件的记录，添加到YesterdayBorrow
            foreach (Model.UserBorrow item in Data)
            {
                insertRows = DAL.DAL.Execute(DAL.DAL.InsertString("YesterdayBorrow", "(ApparatusName,BorrowDate,BorrowNumber,ReturnDate,UserName,Telephone)", "(@ApparatusName,@BorrowDate,@BorrowNumber,@ReturnDate,@UserName,@Telephone)"),
                 new SqlParameter(@"ApparatusName", item.ApparatusName),
                 new SqlParameter(@"BorrowDate", item.BorrowDate),
                 new SqlParameter(@"BorrowNumber", item.BorrowNumber),
                 new SqlParameter(@"ReturnDate", item.ReturnDate),
                 new SqlParameter(@"UserName", item.UserName),
                 new SqlParameter(@"Telephone", item.Telephone));
            }
            //遍历数组，删除TodayBorrow表中符合条件的记录
            foreach (Model.UserBorrow item in Data)
            {
                deleteRows = BLL.Delete_Borrow(item.Id.ToString(), "TodayBorrow");

            }
            if (insertRows > 0 && deleteRows > 0)
            {
                mybool = true;
            }
            return mybool;

        }
        public static bool Test_YesterdayBorrow()
        {
            bool mybool = false;
            List<Model.UserBorrow> Data = new List<Model.UserBorrow>();//用来储存符合条件的记录
            SqlDataReader reader = DAL.DAL.Reader(DAL.DAL.SelectString("*", "YesterdayBorrow", string.Empty), null);
            while (reader.Read())
            {
                Model.UserBorrow data = new Model.UserBorrow
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    ApparatusName = reader["ApparatusName"].ToString(),
                    BorrowDate = reader["BorrowDate"].ToString(),
                    BorrowNumber = reader["BorrowNumber"].ToString(),
                    ReturnDate = reader["Returndate"].ToString(),
                    Telephone = reader["Telephone"].ToString(),
                    UserName = reader["UserName"].ToString()
                };
                string[] yesterdayDate = data.ReturnDate.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);//分割数据库YesterdayBorrow表中借用日期
                string[] Year_month_day = yesterdayDate[0].Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);//分割借用日期年月日，为数组
                string[] Now_year_month_day = DateTime.Now.ToShortDateString().Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);//分割现在年月日，为数组
                //现在的年份大于归还日期的年份
                if (Int32.Parse(Now_year_month_day[0]) > Int32.Parse(Year_month_day[0]))
                {
                    Data.Add(data);//将符合条件的记录添加到集合
                }
                //年份相同时，比较月份，现在月份大时，直接添加
                if (Int32.Parse(Now_year_month_day[0]) == Int32.Parse(Year_month_day[0]) && Int32.Parse(Now_year_month_day[1]) > Int32.Parse(Year_month_day[1]))
                {
                    Data.Add(data);//将符合条件的记录添加到集合
                }
                //年份、月份相同时，比较日，现在日大时，直接添加
                if (Int32.Parse(Now_year_month_day[0]) == Int32.Parse(Year_month_day[0]) && Int32.Parse(Now_year_month_day[1]) == Int32.Parse(Year_month_day[1]) && Int32.Parse(Now_year_month_day[2]) > Int32.Parse(Year_month_day[2]))
                {
                    Data.Add(data);//将符合条件的记录添加到集合
                }
            }
            reader.Close();
            int insertRows = 0;
            int deleteRows = 0;
            //遍历储存有符合条件的记录，添加到NoReturnRecord
            foreach (Model.UserBorrow item in Data)
            {
                insertRows = DAL.DAL.Execute(DAL.DAL.InsertString("NoReturnRecord", "(ApparatusName,BorrowDate,BorrowNumber,ReturnDate,UserName,Telephone)", "(@ApparatusName,@BorrowDate,@BorrowNumber,@ReturnDate,@UserName,@Telephone)"),
                 new SqlParameter(@"ApparatusName", item.ApparatusName),
                 new SqlParameter(@"BorrowDate", item.BorrowDate),
                 new SqlParameter(@"BorrowNumber", item.BorrowNumber),
                 new SqlParameter(@"ReturnDate", item.ReturnDate),
                 new SqlParameter(@"UserName", item.UserName),
                 new SqlParameter(@"Telephone", item.Telephone));
            }
            //遍历数组，删除TodayBorrow表中符合条件的记录
            foreach (Model.UserBorrow item in Data)
            {
                deleteRows = BLL.Delete_Borrow(item.Id.ToString(), "YesterdayBorrow");
            }
            if (insertRows > 0 && deleteRows > 0)
            {
                mybool = true;
            }
            return mybool;
        }
        /// <summary>
        /// 搜索一个表中的数据，返回list集合
        /// </summary>
        /// <param name="tableName">要搜索表的名称</param>
        /// <param name="searchName">要搜索的内容</param>
        /// <returns></returns>
        public static List<Model.UserBorrow> Search_nowTable(string tableName,string searchName)
        {
            List<Model.UserBorrow> Data = new List<Model.UserBorrow>();
            SqlDataReader reader = DAL.DAL.Reader(DAL.DAL.SelectString("*",tableName,
                "ApparatusName like @apparatusname or " +
                "BorrowDate like @borrowdate or " +
                "BorrowNumber like @borrownumber or " +
                "ReturnDate like @returndate or " +
                "UserName like @username or " +
                "Telephone like @telephone"),
                new SqlParameter(@"apparatusname",searchName),
                new SqlParameter(@"borrowdate", searchName),
                new SqlParameter(@"borrownumber", searchName),
                new SqlParameter(@"returndate", searchName),
                new SqlParameter(@"username", searchName),
                new SqlParameter(@"telephone", searchName)
                );
            while (reader.Read())
            {
                Model.UserBorrow data = new Model.UserBorrow();
                {
                    data.ApparatusName = reader["ApparatusName"].ToString();
                    data.BorrowDate = reader["BorrowDate"].ToString();
                    data.ReturnDate = reader["ReturnDate"].ToString();
                    data.UserName = reader["UserName"].ToString();
                    data.Telephone = reader["Telephone"].ToString();
                    data.BorrowNumber = reader["BorrowNumber"].ToString();
                }
                Data.Add(data);

            }
            reader.Close();
            return Data;


        }
        

        //}
        /// <summary>
        /// 读取数据库中的表，返回datatable对象
        /// </summary>
        /// <param name="tableName">要读取的表名</param>
        /// <returns>datatable对象</returns>

        public static DataSet Reader_table(string tableName)
        {
            DataSet ds = new DataSet();
           
            SqlConnection con = new SqlConnection(DAL.DAL.ConStr);
            SqlDataAdapter adapter = new SqlDataAdapter(DAL.DAL.SelectString("*",tableName,string.Empty),con);
            adapter.Fill(ds,"table1");
            return ds;
        }
       /// <summary>
       /// 创建excel文件，将数据库中的数据写入到excel中
       /// </summary>
       /// <param name="path">文件保存的路径</param>
        public static void Create_excel(string path)
        {
            
            Workbook wb = new Workbook();
            wb.Worksheets.Add("今日借用信息");
            wb.Worksheets.Add("往日借用信息");
            wb.Worksheets.Add("未归还记录");
            wb.Worksheets["今日借用信息"].InsertDataTable(BLL.Reader_table("TodayBorrow").Tables[0], true, 1, 1,true);
            wb.Worksheets["往日借用信息"].InsertDataTable(BLL.Reader_table("YesterdayBorrow").Tables[0],true,1,1,true);
            wb.Worksheets["未归还记录"].InsertDataTable(BLL.Reader_table("NoReturnRecord").Tables[0], true, 1, 1, true);
            wb.Worksheets.Remove("Sheet1");
            wb.Worksheets.Remove("Sheet3");
            wb.Worksheets.Remove("Sheet2");
            if (path.EndsWith("\\"))
            {
                
                wb.SaveToFile(path + DateTime.Now.ToString("D") + "器械管理系统记录" + ".xls");
            }
            else
            {
                
                wb.SaveToFile(path + "\\" + DateTime.Now.ToString("D") + "器械管理系统记录" + ".xls");
            }

            MessageBox.Show("文件保存在: "+path, "Excle文件创建成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process[] excelProcess = System.Diagnostics.Process.GetProcessesByName("EXCEL");
            foreach (System.Diagnostics.Process p in excelProcess)
            {
                p.Kill();
            }
        }
        /// <summary>
        /// 清空数据库中TodayBorrow表和YesterdayBorrow、NoReturnRecord表中的数据
        /// </summary>
        /// <returns>清空了返回true，否则返回false</returns>
        public static bool DeleteTable()
        {
            bool mybool = false;
            int row=DAL.DAL.Execute(DAL.DAL.Delete_All("TodayBorrow"));
            int row1 = DAL.DAL.Execute(DAL.DAL.Delete_All("YesterdayBorrow"));
            int row2 = DAL.DAL.Execute(DAL.DAL.Delete_All("NoReturnRecord"));
            if (row > 0 && row1 > 0 && row2 > 0)
            mybool = true;
            return mybool;

        }

    }
}
