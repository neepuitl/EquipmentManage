using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace EquipmentManage.DAL
{
    class DAL
    {
        public static string ConStr = "Server=.;user=syf;pwd=123456;database=EquipmentManage";
        /// <summary>
        /// 执行sql命令，代入参数实现增、删、改
        /// </summary>
        /// <param name="sql">增、删、改Sql语句</param>
        /// <param name="ps">sql参数</param>
        /// <returns></returns>
        public static int Execute(string sql, params SqlParameter[] ps)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                if (ps != null) com.Parameters.AddRange(ps);
                return com.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 读取数据，返回datareader
        /// </summary>
        /// <param name="sql">Sql查询语句</param>
        /// <param name="ps">Sql参数</param>
        /// <returns></returns>
        public static SqlDataReader Reader(string sql, params SqlParameter[] ps)
        {
            SqlConnection con = new SqlConnection(ConStr);
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            if (ps != null) com.Parameters.AddRange(ps);
            return com.ExecuteReader(CommandBehavior.CloseConnection);
        }


        /// <summary>
        /// sql选择字符串，可代入参数，改变sql语句
        /// </summary>
        /// <param name="parameter1"></param>
        /// <param name="parameter2"></param>
        /// <param name="where">值为空字符时无where，不为空时可添加语句</param>
        /// <returns></returns>
        public static string SelectString(string parameter1, string parameter2, string where)
        {
            string str = string.Empty;
            if (where == string.Empty)
            {
                string sqlSelect = string.Empty;
                sqlSelect = string.Format("select {0} from {1};", parameter1, parameter2);
                str = sqlSelect;
            }
            else
            {
                string sqlSelect = string.Empty;
                sqlSelect = string.Format("select {0} from {1} where {2};", parameter1, parameter2, where);
                str = sqlSelect;
            }
            return str;
        }

        /// <summary>
        /// sql添加语句，代入参数，改变sql语句
        /// </summary>
        /// <param name="TableString"></param>
        /// <param name="ValueString1"></param>
        /// <param name="ValueString2"></param>
        /// <returns></returns>
        public static string InsertString(string TableString, string ValueString1, string ValueString2)
        {
            string sqlInsert =string.Empty;
            sqlInsert = string.Format("insert into {0} {1}values {2};",TableString,ValueString1,ValueString2);
            return sqlInsert;
        }


        /// <summary>
        /// sql删除语句，代入参数，改变sql语句
        /// </summary>
        /// <param name="TableString"></param>
        /// <param name="Condition"></param>
        /// <returns></returns>
        public static string DelectString(string TableString, string Condition)
        {
            string sqlDelect = string.Empty;
            sqlDelect = string.Format("delete from {0} where {1};", TableString, Condition);
            return sqlDelect;
        }


        /// <summary>
        /// sql更新语句，代入参数，改变sql语句
        /// </summary>
        /// <param name="TableString"></param>
        /// <param name="ValueString"></param>
        /// <param name="Condition"></param>
        /// <returns></returns>
        public static string UpdateString(string TableString, string ValueString, string Condition)
        {
            string sqlUpdate =string.Empty;
            sqlUpdate = string.Format("update {0} set {1} where {2};", TableString, ValueString, Condition);
            return sqlUpdate;
        }
        /// <summary>
        /// 删除表的语句
        /// </summary>
        /// <param name="tableName">要删除的表名</param>
        /// <returns></returns>
        public static string Delete_All(string tableName)
        {
            string sqlDelete = string.Empty;
            sqlDelete = string.Format("delete from {0};", tableName);
            return sqlDelete;
        }

    }
}
