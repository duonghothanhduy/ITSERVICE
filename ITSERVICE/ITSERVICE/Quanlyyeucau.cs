using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ITSERVICE
{
    public partial class QUANLYYEUCAU : DevExpress.XtraEditors.XtraForm
    {
       
        public QUANLYYEUCAU(string tt_taikhoan)
        {
            InitializeComponent();
            taikhoan.Caption = tt_taikhoan;
        }

        private void barEditItem2_EditValueChanged(object sender, EventArgs e)
        {
            label1.Text = search.EditValue.ToString();
        }

        private void barLargeButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            FORM_KHACHHANG f = new FORM_KHACHHANG();
            f.Show();
        }
    }
}