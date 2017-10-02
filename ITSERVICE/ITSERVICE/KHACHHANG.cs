using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ITSERVICE
{
    public partial class FORM_KHACHHANG : DevExpress.XtraEditors.XtraForm
    {
        Class_khachhang class_kh;
        public int action = 0;
        public FORM_KHACHHANG()
        {
            InitializeComponent();
            class_kh = new Class_khachhang();
            class_kh.loaddulieu(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = searchControl1.EditValue.ToString();
        }

        private void searchControl1_EditValueChanged(object sender, EventArgs e)
        {
            this.AcceptButton = search;
        }

        //show du lieu qua ben phai~ khi click vao gridview
        private void gv_khachhang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int donghientai = 0;
            donghientai = gv_khachhang.FocusedRowHandle;
            txt_makh.Text = gv_khachhang.GetRowCellValue(donghientai, "MAKH").ToString();
            txt_hotenkh.Text = gv_khachhang.GetRowCellValue(donghientai, "HOTEN_KH").ToString();
            txt_emailkh.Text = gv_khachhang.GetRowCellValue(donghientai, "EMAIL_KH").ToString();
            txt_sodthKH.Text = gv_khachhang.GetRowCellValue(donghientai, "SODTH_KH").ToString();
            cbb_chucvu.Text = gv_khachhang.GetRowCellValue(donghientai, "TENCHUCVU").ToString();
        }

        private void cbb_chucvu_Click(object sender, EventArgs e)
        {
            class_kh.loaddulieucb(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_acction.SelectedIndex==0)
            {
                
                txt_makh.Enabled = false;
                class_kh.taomakh(this);
                action = 1;
            }
            if(cbb_acction.SelectedIndex==1)
            {
                txt_makh.Enabled = false;
                action = 2;
            }

            if (cbb_acction.SelectedIndex == 2)
            {
                txt_makh.Enabled = false;
                action = 3;
            }
        }

        private void bt_apply_Click(object sender, EventArgs e)
        {
            if (action == 1)
            {
                class_kh.addkhachhang(this);
            }
            if(action==2)
            {
                class_kh.xoakhachhang(this);
            }
            if(action==3)
            {
                class_kh.editkhachhang(this);
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            class_kh.reset(this);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            class_kh.xuatfile(this);
        }

     
    }
}