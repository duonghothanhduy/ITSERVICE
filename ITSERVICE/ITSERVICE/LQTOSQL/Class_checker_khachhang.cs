using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITSERVICE.LQTOSQL;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace ITSERVICE.LQTOSQL
{
    class Class_checker_khachhang
    {
        Class_connect data;
        public Class_checker_khachhang()
        {
            data = new Class_connect();
        }

        //kiem tra nhap so
        public bool IsNumber(string text)
        {
            foreach (char c in text)
            {
                if (!Char.IsDigit(c))//Digit: ko phai so
                {
                    return false;
                }
            }
            return true;
        }

        //kiem tra them khách hang
        public bool checker_add_khachang(string hoten, string email, string sdth, string chucvu)
        {
            int kt = 0;
            string thongbao = "";
            var sql = data.database().KHACHHANGs.ToList();
            var sql_chucvu = data.database().CHUCVUs.ToList();
            if (hoten == "")
            {
                kt = 1;
                thongbao += "Ho tên còn tróng!\n";
            }

            if (email == "")
            {
                kt = 1;
                thongbao += "Email còn tróng!\n";
            }
            else
            {
                if (email.Contains('@') == true)
                {
                    string[] chuoi = email.Split('@');
                    if (chuoi[0] == "")
                    {
                        kt = 1;
                        thongbao += "Email Không chính xác\n";
                    }
                    else
                    {
                        if (chuoi[1] == "")
                        {
                            kt = 1;
                            thongbao += "Email Không chính xác\n";
                        }
                        else
                        {
                            foreach (var i in sql)
                            {
                                if (email == i.EMAIL_KH)
                                {
                                    kt = 1;
                                    thongbao += "Email đã tồn tại!\n";
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    kt = 1;
                    thongbao += "Email Không chính xác\n";
                }

            }

            if (sdth == "")
            {
                kt = 1;
                thongbao += "Số điện thoại còn tróng!\n";
            }
            else
            {
                if (IsNumber(sdth) == true)
                {
                    if (sdth.Length >= 9 && sdth.Length <= 11)
                    {
                        foreach (var i in sql)
                        {
                            if (sdth == i.SODTH_KH)
                            {
                                kt = 1;
                                thongbao += "Số điện thoại đã tồn tại!\n";
                                break;
                            }
                        }
                    }
                    else
                    {
                        kt = 1;
                        thongbao += "Số điện thoại không đúng!\n";
                    }
                }
                else
                {
                    kt = 1;
                    thongbao += "Số điện thoại không hợp lệ!\n";
                }

            }

            if (chucvu == "")
            {
                kt = 1;
                thongbao += "Chức vụ còn tróng!\n";
            }
            else
            {
                int cv = 0;
                foreach (var i in sql_chucvu)
                {
                    if (chucvu == i.TENCHUCVU)
                    {
                        cv = 1;
                        break;
                    }
                }
                if (cv == 0)
                {
                    kt = 1;
                    thongbao += "Chức vụ không tồn tại!\n";
                }
            }

            if (kt == 1)
            {
                XtraMessageBox.Show(thongbao, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        //kiem tra xoa
        public bool ktrxoa(string makh)
        {
            int kt = 0;
            string thongbao = "";
            if(makh=="")
            {
                kt=1;
                thongbao = "Hãy chọn khách hàng muốn xóa trong bãng danh sách!";
            }
            if(kt==1)
            {
                XtraMessageBox.Show(thongbao, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }


        public bool ktredit(string makh,string hoten, string email, string sdth, string chucvu)
        {

            int kt = 0;
            string thongbao = "";
            var sql = data.database().KHACHHANGs.ToList();
            var sql_chucvu = data.database().CHUCVUs.ToList();
            if (hoten == "")
            {
                kt = 1;
                thongbao += "Ho tên còn tróng!\n";
            }

            if (email == "")
            {
                kt = 1;
                thongbao += "Email còn tróng!\n";
            }
            else
            {
                if (email.Contains('@') == true)
                {
                    string[] chuoi = email.Split('@');
                    if (chuoi[0] == "")
                    {
                        kt = 1;
                        thongbao += "Email Không chính xác\n";
                    }
                    else
                    {
                        if (chuoi[1] == "")
                        {
                            kt = 1;
                            thongbao += "Email Không chính xác\n";
                        }
                        else
                        {
                            foreach (var i in sql)
                            {
                                if (email == i.EMAIL_KH && i.MAKH!=makh)
                                {
                                    kt = 1;
                                    thongbao += "Email đã tồn tại!\n";
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    kt = 1;
                    thongbao += "Email Không chính xác\n";
                }

            }

            if (sdth == "")
            {
                kt = 1;
                thongbao += "Số điện thoại còn trống!\n";
            }
            else
            {
                if (IsNumber(sdth) == true)
                {
                    if (sdth.Length >= 9 && sdth.Length <= 11)
                    {
                        foreach (var i in sql)
                        {
                            if (sdth == i.SODTH_KH && i.MAKH!=makh)
                            {
                                kt = 1;
                                thongbao += "Số điện thoại đã tồn tại!\n";
                                break;
                            }
                        }
                    }
                    else
                    {
                        kt = 1;
                        thongbao += "Số điện thoại không đúng!\n";
                    }
                }
                else
                {
                    kt = 1;
                    thongbao += "Số điện thoại không hợp lệ!\n";
                }

            }

            if (chucvu == "")
            {
                kt = 1;
                thongbao += "Chức vụ còn tróng!\n";
            }
            else
            {
                int cv = 0;
                foreach (var i in sql_chucvu)
                {
                    if (chucvu == i.TENCHUCVU)
                    {
                        cv = 1;
                        break;
                    }
                }
                if (cv == 0)
                {
                    kt = 1;
                    thongbao += "Chức vụ không tồn tại!\n";
                }
            }

            if (kt == 1)
            {
                XtraMessageBox.Show(thongbao, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
