using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public interface IKyThiDA:IBaseDA <KyThi,int>
    {
        KyThi LayTheoMa(int p);
    }
}
