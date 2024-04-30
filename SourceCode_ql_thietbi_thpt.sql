CREATE DATABASE QLTB;
go 
use QLTB
go



-- Tạo bảng NHAN_VIEN   
CREATE TABLE NHAN_VIEN (
  manv VARCHAR(50) NOT NULL,
  tennv NVARCHAR(50) NOT NULL,
  ngaysinh Date NOT NULL,
  gioitinh NVARCHAR (10) NOT NULL,
  diachi NVARCHAR(50) NOT NULL,
  sdt_nv VARCHAR(20) NOT NULL,
  CCCD VARCHAR(13) NOT NULL,
  taikhoan VARCHAR (50) NOT NULL,
  matkhau VARCHAR (50) NOT NULL,
  quyen VARCHAR (50) NOT NULL,
  
  PRIMARY KEY (manv)
  
);

-- Tao bang THIET_BI 
CREATE TABLE THIET_BI (
  Matb VARCHAR(20),
  Tentb NVARCHAR(50) NOT NULL,
  Ngaynhap Date NOT NULL,
  Soluongmua VARCHAR(50) NOT NULL,
  NCC NVARCHAR(50) NOT NULL,
  Baohanh NVARCHAR (20) NOT NULL,
  Giamua NVARCHAR (50) NOT NULL,
  Tinhtrang NVARCHAR(50) NOT NULL,
  Ghichu NVARCHAR(50) NOT NULL,
  
  PRIMARY KEY (Matb)
);

-- Tạo bảng PHIEU_MUON/TRA  
CREATE TABLE  PHIEU_MUON(
  id VARCHAR(20) NOT NULL,
  Nguoimuon NVARCHAR (50) NOT NULL,
  Gioitinh NVARCHAR (10) NOT NULL,
  CCCD VARCHAR(15) NOT NULL,
  Sdt VARCHAR(20) NOT NULL,
  Ngaymuon Date NOT NULL,
  Camuon NVARCHAR (20) NOT NULL,
  TenPhong NVARCHAR(50) NOT NULL,
  Soluong VARCHAR(20) NOT NULL,
  Tentb NVARCHAR(50) NOT NULL,
  manv VARCHAR(50) NOT NULL,
  Ghichu NVARCHAR(50) NOT NULL,
  Matb VARCHAR(20),
	
  PRIMARY KEY (id),
  
  FOREIGN KEY (manv) REFERENCES NHAN_VIEN (manv),
  FOREIGN KEY (Matb) REFERENCES THIET_BI (Matb)
  
);
-- Phieu tra    
CREATE TABLE  PHIEU_TRA(
  mapt VARCHAR(20) NOT NULL,
  Nguoitra NVARCHAR (50) NOT NULL,
  Gioitinh NVARCHAR (10) NOT NULL,
  CCCD VARCHAR(15) NOT NULL,
  Sdt VARCHAR(20) NOT NULL,
  Ngaytra Date NOT NULL,
  Catra NVARCHAR (20) NOT NULL,
  TenPhong NVARCHAR(50) NOT NULL,
  Soluong VARCHAR(20) NOT NULL,
  Tentb NVARCHAR(50) NOT NULL,
  manv VARCHAR(50) NOT NULL,
  Ghichu NVARCHAR(50) NOT NULL,
  Matb VARCHAR(20),
	
  PRIMARY KEY (mapt),
  
  FOREIGN KEY (manv) REFERENCES NHAN_VIEN (manv),
  FOREIGN KEY (Matb) REFERENCES THIET_BI (Matb)
);


-- Tạo bảng PHIEU_NHAP 
CREATE TABLE  PHIEU_NHAP(
  Mapn VARCHAR(20) NOT NULL,
  Tentbm NVARCHAR(50) NOT NULL,
  Soluongnhap VARCHAR(50) NOT NULL,
  NCC NVARCHAR(50) NOT NULL,
  Gianhap NVARCHAR (50) NOT NULL,
  Ngaynhap Date NOT NULL,
  manv VARCHAR(50) NOT NULL,
  Ghichu NVARCHAR(50),
	
  PRIMARY KEY (Mapn),
  
  FOREIGN KEY (manv) REFERENCES NHAN_VIEN (manv)
);

