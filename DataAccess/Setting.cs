using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public  class Setting
    {
        public static IDataAccessFactory DaFactory
        {
            get
            {
             //   return new Access.DataAccessFactory();
                return new InMemory.DataAccessFactory();
            }
        }
    }
}
