using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IBaseDA<T,TKey>
    {
        T LayTheoMa(TKey id);
        List<T> LayTatCa();
        int Them(T obj);
        int Xoa(TKey id);
        int Xoa(T obj);
        int CapNhat(T obj);
        int Luu(T obj); // Them hoac CapNhat
    }
}
