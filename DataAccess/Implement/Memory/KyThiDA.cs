using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.InMemory;

namespace DataAccess.Implement.Memory
{
    public class KyThiDA:IKyThiDA
    {
        #region IBaseDA<KyThi,int> Members

        public KyThi LayTheoMa(int id)
        {
            return InMemoryDatabase.KyThiTable[id];
           // throw new NotImplementedException();
        }

        public List<KyThi> LayTatCa()
        {

            //throw new NotImplementedException();
            List<KyThi> dsKyThi = new List<KyThi>();
            foreach (KyThi kt in InMemoryDatabase.KyThiTable.Values)
                dsKyThi.Add(kt);
            return dsKyThi;
        }

        public int Them(KyThi obj)
        {
            throw new NotImplementedException();
        }

        public int Xoa(int id)
        {
            throw new NotImplementedException();
        }

        public int Xoa(KyThi obj)
        {
            throw new NotImplementedException();
        }

        public int CapNhat(KyThi obj)
        {
            throw new NotImplementedException();
        }

        public int Luu(KyThi obj)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
