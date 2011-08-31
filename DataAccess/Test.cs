using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Test
    {
        public int ID { get; set; }
        public int IDBai { get; set; }
        public int Diem { get; set; }
        public string MoTa { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }

        public Test() { }
        public Test(int id, int idBai)
        {
            ID = id; 
            IDBai = idBai;

        }
        public Test(int id, int idBai, int diem)
        {
            ID = id;
            IDBai = idBai;            
        }
        public Test(int id, int idBai, int diem, string moTa)
        {
            ID = id;
            IDBai = idBai;
            Diem = diem;            
            MoTa = moTa;
        }
        public Test(int id, int idBai, int diem, string input, string output)
        {
            ID = id;
            IDBai = idBai;
            Diem = diem;
            Input = input;
            Output = output;            
        }
        public Test(int id, int idBai, int diem, string input, string output, string moTa)
        {
            ID = id;
            IDBai = idBai;
            Diem = diem;
            Input = input;
            Output = output;
            MoTa = moTa;
        }
        public Test(int id, Bai bai)
        {
            ID = id;
            IDBai = bai.ID;

        }
        public Test(int id, Bai bai, int diem)
        {
            ID = id;
            IDBai = bai.ID;
        }
        public Test(int id, Bai bai, int diem, string moTa)
        {
            ID = id;
            bai.ID = bai.ID;
            Diem = diem;
            MoTa = moTa;
        }
        public Test(int id, Bai bai, int diem, string input, string output)
        {
            ID = id;
            bai.ID = bai.ID;
            Diem = diem;
            Input = input;
            Output = output;
        }
        public Test(int id, Bai bai, int diem, string input, string output, string moTa)
        {
            ID = id;
            bai.ID = bai.ID;
            Diem = diem;
            Input = input;
            Output = output;
            MoTa = moTa;
        }
    }
}
