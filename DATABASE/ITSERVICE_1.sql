﻿CREATE DATABASE ITSERVICE

CREATE TABLE CHUCVU
(
	MACHUCVU VARCHAR(15) PRIMARY KEY,
	TENCHUCVU NVARCHAR(100) NOT NULL UNIQUE,
	MOTA_CHUCVU NVARCHAR(200) 
)

CREATE TABLE KHACHHANG
(
	MAKH VARCHAR(15) PRIMARY KEY,
	HOTEN_KH NVARCHAR(100) NOT NULL,
	EMAIL_KH VARCHAR(100) NOT NULL UNIQUE,
	SODTH_KH VARCHAR(100) NOT NULL UNIQUE CHECK (LEN(SODTH_KH) BETWEEN 9 AND 11 ),
	MACHUCVU VARCHAR(15) FOREIGN KEY REFERENCES CHUCVU(MACHUCVU),
	HIENHANH_KH BIT
)

CREATE TABLE LOAITK
(
	MALOAI_TK INT PRIMARY KEY IDENTITY,
	TENLOAI_TK NVARCHAR(100) UNIQUE
)

CREATE TABLE ACCOUNT
(
	LOGINNAME_AC VARCHAR(15) PRIMARY KEY,
	PASSWORD_AC VARCHAR(15) NOT NULL,
	MALOAI_TK INT FOREIGN KEY REFERENCES LOAITK(MALOAI_TK),
	MAKH VARCHAR(15) FOREIGN KEY REFERENCES KHACHHANG(MAKH),
	HIENHANH_AC BIT
)

CREATE TABLE LOAI_YC
(
	MALOAI_YC VARCHAR(15) PRIMARY KEY,
	TENLOAI_YC NVARCHAR(100) NOT NULL UNIQUE,
	MOTALOAI_YC NVARCHAR(200)
)

CREATE TABLE LINHVUC
(
	MALV VARCHAR(15) PRIMARY KEY,
	TENLV NVARCHAR(100) NOT NULL UNIQUE,
	HIENHANH_LV BIT
)

CREATE TABLE KITHUATVIEN
(
	MAKTV VARCHAR(15) PRIMARY KEY,
	HOTEN_KTV NVARCHAR(50) NOT NULL,
	EMAIL_KTV VARCHAR(50) NOT NULL UNIQUE,
	SODTH_KTV VARCHAR(15) NOT NULL CHECK (LEN(SODTH_KTV) BETWEEN 9 AND 11),
	HIENHANH_KTV BIT
)

CREATE TABLE CTKTV
(
	MAKTV VARCHAR(15) NOT NULL
	FOREIGN KEY REFERENCES KITHUATVIEN(MAKTV),
	MALV VARCHAR(15) NOT NULL
	FOREIGN KEY REFERENCES LINHVUC(MALV),
	PRIMARY KEY(MAKTV,MALV),
	MOTA_NHOM_KTV NVARCHAR(200)
)

CREATE TABLE DANHMUC_YEUCAU
(
	MADMYC VARCHAR(15) PRIMARY KEY,
	MALOAI_YC VARCHAR(15) FOREIGN KEY REFERENCES LOAI_YC(MALOAI_YC),
	MALV VARCHAR(15) FOREIGN KEY REFERENCES LINHVUC(MALV),
	TIEUDE_DMYC  NVARCHAR(100) NOT NULL UNIQUE,
	MOTA_DMYC NVARCHAR(200) NOT NULL,
	HIENHANH_DMYC BIT
)

CREATE TABLE TRANGTHAI_YC
(
	MATT_YC VARCHAR(15) PRIMARY KEY,
	TENTT_YC NVARCHAR(50) NOT NULL UNIQUE,
	MOTA_TTYC NVARCHAR(200)
)

CREATE TABLE TINHTRANG_XN
(
	MATT_XN VARCHAR(15) PRIMARY KEY,
	TENTT_XN NVARCHAR(50) NOT NULL UNIQUE,
	MOTA_TTXN NVARCHAR(200)
)

CREATE TABLE PHIEU_YC
(
	MAPYC Varchar(15) PRIMARY KEY,
	TIEUDE_PYC Nvarchar(50) NOT NULL,
	NGAYLAP_PYC Datetime NOT NULL,
	MAKH Varchar(15) FOREIGN KEY REFERENCES KHACHHANG(MAKH),
	MADMYC Varchar(15) FOREIGN KEY REFERENCES DANHMUC_YEUCAU(MADMYC),
	MATT_YC Varchar(15) FOREIGN KEY REFERENCES TRANGTHAI_YC(MATT_YC),
	MATT_XN Varchar(15) FOREIGN KEY REFERENCES TINHTRANG_XN(MATT_XN),
	MAKTV Varchar(15) FOREIGN KEY REFERENCES KITHUATVIEN(MAKTV),
	MOTA_PYC Nvarchar(200) NOT NULL,
	GHICHU Nvarchar(100) NULL,
	HIENHANH_PYC BIT
)

CREATE TABLE PHIEUXACNHAN_YC
(
	MAPHIEUXN_YC VARCHAR(15) PRIMARY KEY,
	NGAYLAP_PXN DATETIME NOT NULL,
	TIEUDE_XN NVARCHAR(50) NOT NULL,
	MOTA_XN NVARCHAR(200) NOT NULL,
	MAPYC VARCHAR(15) FOREIGN KEY REFERENCES PHIEU_YC(MAPYC),
	HIENHANH_PXNYC BIT
)

CREATE TABLE CONGVIEC
(
	MACONGVIEC VARCHAR(15) PRIMARY KEY,
	TENCONGVIEC NVARCHAR(50) NOT NULL UNIQUE,
	HIENHANH_CONGVIEC BIT
)

CREATE TABLE CTCV
(
	MAPYC VARCHAR(15) NOT NULL
	FOREIGN KEY REFERENCES PHIEU_YC(MAPYC),
	MACONGVIEC VARCHAR(15) NOT NULL
	FOREIGN KEY REFERENCES CONGVIEC(MACONGVIEC),
	PRIMARY KEY(MAPYC,MACONGVIEC),
	THOIGIAN_THUCHIEN DATETIME NOT NULL,
	HIENHANH_CTCV BIT
)



-- RANG BUOC MOI NGAY MOT KI THUAT VIEN CHI DUOC GAN TOI DA 5 YEU CAU
CREATE TRIGGER YC_DUOCGAN
ON PHIEU_YC
FOR INSERT,UPDATE,DELETE
AS
BEGIN
	IF((SELECT COUNT(*)
	   FROM PHIEU_YC 
	   GROUP BY PHIEU_YC.MAKTV,DAY(NGAYLAP_PYC),MONTH(NGAYLAP_PYC),YEAR(NGAYLAP_PYC)
	   HAVING COUNT(MAPYC)>5)>0)
	BEGIN
		PRINT N'MỖI NGÀY KĨ THUẬT VIÊN CHỈ ĐƯỢC GÁN XỬ LÝ TỐI ĐA 5 YÊU CẦU'
		ROLLBACK TRAN
	END
END

DROP TRIGGER YC_DUOCGAN
--MOT KHACH HANG CHI CO TOI DA MOT TAI KHOANG
CREATE TRIGGER TK_KH
ON ACCOUNT
FOR INSERT,UPDATE,DELETE
AS
BEGIN
	IF((SELECT COUNT(*)
	   FROM ACCOUNT 
	   GROUP BY MAKH
	   HAVING COUNT(LOGINNAME_AC)>1)>0)
	BEGIN
		PRINT N'MỖI KHÁCH HÀNG CHỈ CÓ TỐI ĐA MỘT TÀI KHOẢNG'
		ROLLBACK TRAN
	END
END


--THỜI GIAN LẬP PHIEU XAC NHAN PHAI LƠN HƠN THỜI GIAN LẬP PHIẾU YÊU CẦU
CREATE TRIGGER TG_PXN
ON PHIEUXACNHAN_YC
FOR INSERT,UPDATE,DELETE
AS
BEGIN
	IF((SELECT COUNT(*)
	   FROM PHIEUXACNHAN_YC X,PHIEU_YC Y 
	   WHERE 
			X.MAPYC = Y.MAPYC 
			AND X.NGAYLAP_PXN<=Y.NGAYLAP_PYC
	   )>0)
	BEGIN
		PRINT N'Ngày giờ lập phiếu xác nhận phải lớn hơn ngày giờ lập phiếu yêu cầu'
		ROLLBACK TRAN
	END
END

--THỜI GIAN THỰC HIỆN CÔNG VIỆC PHAI LƠN HƠN THỜI GIAN LẬP PHIẾU YÊU CẦU
CREATE TRIGGER TG_THCV
ON CTCV
FOR INSERT,UPDATE,DELETE
AS
BEGIN
	IF((SELECT COUNT(*)
	   FROM PHIEU_YC Y,CTCV C 
	   WHERE 
			Y.MAPYC = C.MAPYC 
			AND C.THOIGIAN_THUCHIEN<=Y.NGAYLAP_PYC
	   )>0)
	BEGIN
		PRINT N'Ngày giờ thực hiện công việc phải lớn hơn ngày giờ lập phiếu yêu cầu'
		ROLLBACK TRAN
	END
END





-- TAO PROC DE XUAT THONG TIN KHACH HANG QUA  VISUAL
CREATE PROC PROC_KHACHHANG
AS
BEGIN
	SELECT KHACHHANG.MAKH,KHACHHANG.HOTEN_KH,KHACHHANG.EMAIL_KH,KHACHHANG.SODTH_KH,CHUCVU.TENCHUCVU
	FROM KHACHHANG,CHUCVU
	WHERE KHACHHANG.MACHUCVU = CHUCVU.MACHUCVU AND KHACHHANG.HIENHANH_KH=1
END