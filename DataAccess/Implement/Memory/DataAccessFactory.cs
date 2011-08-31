using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using DataAccess.Implement.Memory;

namespace DataAccess.InMemory
{
    public class DataAccessFactory:IDataAccessFactory
    {
        #region IDataAccessFactory Members

        public IBaiDA GetBaiDA()
        {
            return new BaiDA();
        }

        #endregion
        public IKyThiDA GetKyThiDA()
        {
            return new KyThiDA();
        }
    }

}
