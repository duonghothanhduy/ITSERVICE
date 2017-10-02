using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITSERVICE.LQTOSQL;
using DevExpress.XtraGrid;
using System.Windows.Forms;
using System.IO;


namespace ITSERVICE
{
    class Class_khachhang
    {
        Class_connect data;
        Class_checker_khachhang checker;
        public Class_khachhang()
        {
            data = new Class_connect();
            checker = new Class_checker_khachhang();
        }

        //load du lieu vao gridview
        public void loaddulieu(FORM_KHACHHANG f)
        {
            var sql = data.database().PROC_KHACHHANG();
            f.gctr_khachhang.DataSource = sql;
        }

        public void reset(FORM_KHACHHANG f)
        {
              f.txt_makh.Text = "";
              f.txt_hotenkh.Text = "";
              f.txt_emailkh.Text = "";
              f.txt_sodthKH.Text = "";
              f.cbb_chucvu.Text = "";
        }

        //load du lieu combobox
        public void loaddulieucb(FORM_KHACHHANG f)
        {
            var sql = data.database().CHUCVUs.ToList();
            f.cbb_chucvu.DataSource = sql;
            f.cbb_chucvu.DisplayMember = "TENCHUCVU";
            f.cbb_chucvu.ValueMember = "TENCHUCVU";
        }

        //tạo mới mã khách hàng
        public void taomakh(FORM_KHACHHANG f)
        {
            var sql = data.database().KHACHHANGs.ToList();
            f.txt_makh.Text = "KH"+(sql.LongCount() + 1).ToString();
        }

        //add khach hàng
        public void addkhachhang(FORM_KHACHHANG f)
        {
            KHACHHANG KH = new KHACHHANG();
           if(checker.checker_add_khachang(f.txt_hotenkh.Text,f.txt_emailkh.Text,f.txt_sodthKH.Text,f.cbb_chucvu.Text)==true)
           {
               var sql = data.database().CHUCVUs.SingleOrDefault(a=>a.TENCHUCVU==f.cbb_chucvu.Text);
               KH.MAKH = f.txt_makh.Text;
               KH.HOTEN_KH = f.txt_hotenkh.Text;
               KH.EMAIL_KH = f.txt_emailkh.Text;
               KH.SODTH_KH = f.txt_sodthKH.Text;
               KH.MACHUCVU = sql.MACHUCVU;
               data.database().KHACHHANGs.InsertOnSubmit(KH);
               data.database().SubmitChanges();
               DialogResult thongbao = MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
               if(thongbao==DialogResult.OK)
               {
                   loaddulieu(f);
               }
             
           }
        }

        //xoa khach hang
        public void xoakhachhang(FORM_KHACHHANG f)
        {
            if(checker.ktrxoa(f.txt_makh.Text)==true)
            {
                var sql = data.database().KHACHHANGs.ToList();
                foreach(var i in sql)
                {
                    if(i.MAKH==f.txt_makh.Text)
                    {
                        data.database().KHACHHANGs.DeleteOnSubmit(i);
                        data.database().SubmitChanges();
                        break;
                    }
                }
                DialogResult thongbao = MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK);
                if(thongbao == DialogResult.OK)
                {
                    loaddulieu(f);
                    reset(f);
                }
            }
        }


        //edit khách hàng
        public void editkhachhang(FORM_KHACHHANG f)
        {
            if(checker.ktredit(f.txt_makh.Text,f.txt_hotenkh.Text,f.txt_emailkh.Text,f.txt_sodthKH.Text,f.cbb_chucvu.Text)==true)
            {
                var sql = data.database().CHUCVUs.SingleOrDefault(a => a.TENCHUCVU == f.cbb_chucvu.Text);
                var sql_kh = data.database().KHACHHANGs.SingleOrDefault(a => a.MAKH == f.txt_makh.Text);
                sql_kh.HOTEN_KH = f.txt_hotenkh.Text;
                sql_kh.EMAIL_KH = f.txt_emailkh.Text;
                sql_kh.SODTH_KH = f.txt_sodthKH.Text;
                sql_kh.MACHUCVU = sql.MACHUCVU;
                data.database().SubmitChanges();
                DialogResult thongbao = MessageBox.Show("Đã sữa thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK);
                if (thongbao == DialogResult.OK)
                {
                    loaddulieu(f);
                    reset(f);
                }
            }
        }

        public void xuatfile(FORM_KHACHHANG f)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            f.gv_khachhang.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            f.gv_khachhang.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            f.gv_khachhang.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            f.gv_khachhang.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            f.gv_khachhang.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            f.gv_khachhang.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
