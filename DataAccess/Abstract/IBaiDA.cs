using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IBaiDA:IBaseDA<Bai,int>
    {
        List<Bai> LayTheoDoKho(DoKho doKho);

    }
}
