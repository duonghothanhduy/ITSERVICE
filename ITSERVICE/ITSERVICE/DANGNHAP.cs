using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ITSERVICE.LQTOSQL;
using DevExpress.XtraEditors;
using System.Threading.Tasks;
using System.IO;

namespace ITSERVICE
{
    public partial class DANGNHAP : DevExpress.XtraEditors.XtraForm
    {
        Class_dangnhap dangnhap;
   
        public DANGNHAP()
        {
            InitializeComponent();
            dangnhap = new Class_dangnhap();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.Properties.PasswordChar= '*';
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {

            if(dangnhap.f_dangnhap(txt_loginname.Text,txt_password.Text)==1)
            {
                string dulieu = txt_loginname.Text.ToString();
                QUANLYYEUCAU quanlyyeucau = new QUANLYYEUCAU(dulieu);
                quanlyyeucau.Show();
                Visible = false;
            }
            else
            {
                XtraMessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txt_password_EditValueChanged(object sender, EventArgs e)
        {
            this.AcceptButton = bt_dangnhap;
        }

    }
}
