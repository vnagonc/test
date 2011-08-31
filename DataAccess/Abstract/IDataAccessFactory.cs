using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IDataAccessFactory
    {
        IBaiDA GetBaiDA();
        IKyThiDA GetKyThiDA();
    }
}
