using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.InMemory
{
    public static class InMemoryDatabase
    {
        static Dictionary<string, object> DataBase;
        public static int BaiNextID = 0;
        static Dictionary<int, Bai> tblBai;
        static Dictionary<int, KyThi> tblKyThi;

       static InMemoryDatabase()
       {
           DataBase = new Dictionary<string, Object>();
            KhoiTaoTableBai();

           KhoiTaoTableKyThi();           
       }

       private static void KhoiTaoTableKyThi()
       {
           tblKyThi = new Dictionary<int, KyThi>();
           KyThi kt = new KyThi(0, "Kỳ thi 0");
           kt.DanhSachBai.Add(tblBai[0]);
           kt.DanhSachBai.Add(tblBai[1]);
           kt.DanhSachBai.Add(tblBai[2]);
           tblKyThi.Add(kt.ID, kt);

           kt = new KyThi(1, "Kỳ thi 1");
           kt.DanhSachBai.Add(tblBai[2]);
           kt.DanhSachBai.Add(tblBai[4]);
           kt.DanhSachBai.Add(tblBai[6]);
           tblKyThi.Add(kt.ID, kt);

           kt = new KyThi(2, "Kỳ thi 2");
           kt.DanhSachBai.Add(tblBai[3]);
           kt.DanhSachBai.Add(tblBai[5]);
           kt.DanhSachBai.Add(tblBai[7]);
           kt.DanhSachBai.Add(tblBai[9]);
           tblKyThi.Add(kt.ID, kt);

           kt = new KyThi(3, "Kỳ thi 3");
           kt.DanhSachBai.Add(tblBai[2]);
           kt.DanhSachBai.Add(tblBai[7]);
           tblKyThi.Add(kt.ID, kt);

           DataBase.Add("KyThi", tblKyThi);
       }

       private static void KhoiTaoTableBai()
       {
           tblBai = new Dictionary<int, Bai>();
           Bai b = new Bai(0, "Tổng mảng0", "Noi dung 0", 0, "D:\\FileCham0.exe", DateTime.Now, 1, 1000, "D:\\ThuMucBai0", "D:\\ThuMucBai0\\Test.zip", true, DoKho.RatDe);
           tblBai.Add(b.ID, b);
           b = new Bai(1, "Tổng mảng1", "Noi dung 1", 2, null, DateTime.Now, 1, 1000, "D:\\ThuMucBai1", "D:\\ThuMucBai1\\Test.zip", true, DoKho.De);
           tblBai.Add(b.ID, b);
           b = new Bai(2, "Tổng mảng2", "Noi dung 2", 3, null, DateTime.Now, 1, 1000, "D:\\ThuMucBai2", "D:\\ThuMucBai2\\Test.zip", true, DoKho.TrungBinh);
           tblBai.Add(b.ID, b);
           b = new Bai(3, "Tổng mảng3", "Noi dung 3", 4, null, DateTime.Now, 1, 1000, "D:\\ThuMucBai3", "D:\\ThuMucBai3\\Test.zip", true, DoKho.HoiKho);
           tblBai.Add(b.ID, b);
           b = new Bai(4, "Tổng mảng4", "Noi dung 4", 2, null, DateTime.Now, 1, 1000, "D:\\ThuMucBai4", "D:\\ThuMucBai4\\Test.zip", true, DoKho.Kho);
           tblBai.Add(b.ID, b);
           b = new Bai(5, "Tổng mảng5", "Noi dung 5", 2, null, DateTime.Now, 1, 1000, "D:\\ThuMucBai5", "D:\\ThuMucBai5\\Test.zip", false, DoKho.RatKho);
           tblBai.Add(b.ID, b);
           b = new Bai(6, "Tổng mảng6", "Noi dung 6", 1, null, DateTime.Now, 1, 1000, "D:\\ThuMucBai6", "D:\\ThuMucBai6\\Test.zip", true, DoKho.TrungBinh);
           tblBai.Add(b.ID, b);
           b = new Bai(7, "Tổng mảng7", "Noi dung 7", 0, "D:\\FileCham7.exe", DateTime.Now, 1, 1000, "D:\\ThuMucBai7", "D:\\ThuMucBai7\\Test.zip", false, DoKho.RatDe);
           tblBai.Add(b.ID, b);
           b = new Bai(8, "Tổng mảng8", "Noi dung 8", 3, null, DateTime.Now, 1, 1000, "D:\\ThuMucBai8", "D:\\ThuMucBai8\\Test.zip", true, DoKho.RatKho);
           tblBai.Add(b.ID, b);
           b = new Bai(9, "Tổng mảng9", "Noi dung 9", 4, null, DateTime.Now, 1, 1000, "D:\\ThuMucBai9", "D:\\ThuMucBai9\\Test.zip", true, DoKho.Kho);
           tblBai.Add(b.ID, b);
           b = new Bai(10, "Tổng mảng10", "Noi dung 10", 0, "D:\\FileCham10.exe", DateTime.Now, 1, 1000, "D:\\ThuMucBai10", "D:\\ThuMucBai1-\\Test.zip", true, DoKho.De);
           tblBai.Add(b.ID, b);           
           BaiNextID = tblBai.Count;
           DataBase.Add("Bai", tblBai);           
       }
       //private static Dictionary<int 
        public static Dictionary<int,Bai> BaiTable
        {
            get
            {
                return (Dictionary<int, Bai>)DataBase["Bai"];
            }
        }
        public static Dictionary<int, KyThi> KyThiTable
        {
            get
            {
       
                return (Dictionary<int, KyThi>)DataBase["KyThi"];
            }
        }
    }
}
