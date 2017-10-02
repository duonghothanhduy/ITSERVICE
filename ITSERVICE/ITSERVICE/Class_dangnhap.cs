using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITSERVICE.LQTOSQL;
using DevExpress.XtraEditors;
using System.IO;
using System.Windows.Forms;

namespace ITSERVICE
{
    class Class_dangnhap
    {
        Class_connect data;
        public Class_dangnhap()
        {
            data = new Class_connect();
            
        }
        public static string chuoi = "";
        public int f_dangnhap(string loginname,string password)
        {
            ACCOUNT account = data.database().ACCOUNTs.SingleOrDefault(a => a.LOGINNAME_AC == loginname && a.PASSWORD_AC == password);
            if (account != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
