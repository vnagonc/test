using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public String HoTen { get; set; }
        public DateTime NgayThamGia { get; set; }
        public DateTime LanCuoiOnline { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
    }
}
