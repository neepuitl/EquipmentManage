using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EquipmentManage.Model
{
    //实体类，用来封装数据
    class UserBorrow
    {
        public int Id { get; set; }//数据库中的表的Id
        public string ApparatusName { get; set; } //器械名称
        public string  BorrowDate{ get; set; }//借用日期
        public string BorrowNumber { get; set; }//借用数量
        public string ReturnDate { get; set; }//借用日期
        public string UserName { get; set; }//借用人姓名
        public string Telephone { get; set; }//借用人电话
    }
}
