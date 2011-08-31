using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class KyThi
    {
        public List<Bai> DanhSachBai { get; set; }
        public String TenKyThi { get; set; }
        public int ID { get; set; }
        public KyThi(int id, String ten)
        {
            ID = id;
            TenKyThi = ten;
            DanhSachBai = new List<Bai>();
        }
    }
}
