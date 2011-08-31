using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Bai
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string NoiDung { get; set; }
        public int MaFileCham { get; set; }        
        public string FileCham { get; set; }
        public DateTime NgayDang { get; set; }
        public long GioiHanThoiGian { get; set; }
        public long GioihanBoNho { get; set; }
        public string ThuMucBai { get; set; }
        public string TestDataZipFile { get; set; }
        public bool HienThi { get; set; }
        public QuyenDownload ChoDownloadTestData { get; set; }
        public DoKho DoKho { get; set; }        

        public Bai()
        { }
        public Bai(int id, string tenBai, String noiDung,int maFileCham, string fileCham
            ,DateTime ngayDang,long gioiHanThoiGian,long gioiHanBoNho, string thuMuc,
            string testDataZipFile,bool hienThi, DoKho doKho)
        {
            ID = id;
            Ten = tenBai;
            NoiDung = noiDung;
            MaFileCham = maFileCham;
            FileCham = fileCham;
            NgayDang = ngayDang;
            GioiHanThoiGian = gioiHanThoiGian;
            GioihanBoNho = gioiHanBoNho;
            ThuMucBai = thuMuc;
            TestDataZipFile = testDataZipFile;
            HienThi = hienThi;
            DoKho = doKho;
        }
    
    }
    
}
