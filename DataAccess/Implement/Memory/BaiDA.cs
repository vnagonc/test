using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataAccess;

namespace DataAccess.InMemory
{
    public class BaiDA:IBaiDA
    {
        #region IBaiDA Members

        public List<Bai> LayTheoDoKho(DoKho doKho)
        {
            List<Bai> lstResult = new List<Bai>();
            foreach (Bai b in InMemoryDatabase.BaiTable.Values)
                if (b.DoKho == doKho)
                    lstResult.Add(b);
            return (List < Bai > )lstResult;
        }

        #endregion

        #region IBaseDA<Bai> Members

        public Bai LayTheoMa(int id)
        {
            return InMemoryDatabase.BaiTable[id];
        }

        public List<Bai> LayTatCa()
        {
            List<Bai> dsBai = new List<Bai>();
            foreach (Bai b in InMemoryDatabase.BaiTable.Values)
                dsBai.Add(b);
            return dsBai;
        }

        public int Them(Bai obj)
        {
            InMemoryDatabase.BaiTable.Add(obj.ID, obj);
            InMemoryDatabase.BaiNextID++;
            return obj.ID;
        }

        public int Xoa(int id)
        {
            if (!InMemoryDatabase.BaiTable.ContainsKey(id))
                return 0;
            InMemoryDatabase.BaiTable.Remove(id);
            return 1;
        }

        public int Xoa(Bai obj)
        {
            return Xoa(obj.ID);
        }

        public int CapNhat(Bai obj)
        {
            if (!InMemoryDatabase.BaiTable.ContainsKey(obj.ID))
                return 0;
            InMemoryDatabase.BaiTable[obj.ID] = obj;
            return 1;
        }

        public int Luu(Bai obj)
        {
            if (LayTheoMa(obj.ID) == null)
            {
                return Them(obj);
            }
            else
                return CapNhat(obj);
        }

        #endregion
    }
}
