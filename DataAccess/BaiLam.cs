using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class BailamThiSinh
    {
        public User ThiSinh { get; set; }
        public Bai Bai { get; set; }
        public KyThi KyThi { get; set; }
        public DateTime NgayGui { get; set; }
        public String FileGui { get; set; }
        public String Code { get; set; }
        public TrangThaiBienDich TrangThaiBienDich { get; set; }
        
        public BailamThiSinh(User thiSinh, Bai bai)
        {
            ThiSinh = thiSinh;
            Bai = bai;            
        }
    }
}
