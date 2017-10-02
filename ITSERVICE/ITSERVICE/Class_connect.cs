using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITSERVICE.LQTOSQL;

namespace ITSERVICE
{
    class Class_connect
    {
        Data_itserviceDataContext data;
        public Class_connect()
        {
            data = new Data_itserviceDataContext();
        }

        public Data_itserviceDataContext database()
        {
            return data;
        }
    }
}
