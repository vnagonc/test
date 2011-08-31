using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;

namespace DataAccess.Access
{
    public class DataAccessFactory:IDataAccessFactory
    {
        #region IDataAccessFactory Members

        public IBaiDA GetBaiDA()
        {
            return new BaiDA();
        }

        #endregion
    }
}
