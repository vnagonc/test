using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;

namespace DataAccess.Access
{
    public class BaiDA:IBaiDA
    {
        #region IBaiDA Members

        public List<Bai> LayTheoDoKho(DoKho doKho)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IBaseDA<Bai> Members

        public Bai LayTheoMa(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bai> LayTatCa()
        {
            throw new NotImplementedException();
        }

        public int Them(Bai obj)
        {
            throw new NotImplementedException();
        }

        public int Xoa(int id)
        {
            throw new NotImplementedException();
        }

        public int Xoa(Bai obj)
        {
            throw new NotImplementedException();
        }

        public int CapNhat(Bai obj)
        {
            throw new NotImplementedException();
        }

        public int Luu(Bai obj)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
