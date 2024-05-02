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

-- Them du lieu NHANVIEN
INSERT INTO NHAN_VIEN (manv, tennv, ngaysinh, gioitinh, diachi, sdt_nv, CCCD, taikhoan, matkhau, quyen)
VALUES 
  ('NV001', N'Nguyễn Thị An', '1995-3-2', N'Nữ', N'Khóm 1, Phường 1, TP.Trà Vinh, Tỉnh Trà Vinh', '0123456789', '089359753217', 'an', '123', 'NhanVien'),
  ('NV002', N'Trần Văn Bình', '1995-5-4', N'Nam', N'Khóm 2, Phường 2, TP.Trà Vinh, Tỉnh Trà Vinh', '0987654321', '089731579241', 'binh', '123', 'NhanVien'),
  ('NV003', N'Lê Minh Cường', '1996-1-5', N'Nam', N'Khóm 3, Phường 3, TP.Trà Vinh, Tỉnh Trà Vinh', '0369871245', '080638593165', 'cuong', '123', 'NhanVien'),
  ('NV004', N'Phạm Thị Dung', '1997-12-9', N'Nữ', N'Khóm 4, Phường 4, TP.Trà Vinh, Tỉnh Trà Vinh', '0543217890', '083815730825', 'Dung', '123', 'NhanVien'),
  ('NV005', N'Hoàng Văn Hiếu', '1993-8-20', N'Nam', N'Khóm 5, Phường 5, TP.Trà Vinh, Tỉnh Trà Vinh', '0789123456', '081832070068', 'hieu', '456', 'NhanVien'),
  ('NV006', N'Nguyễn Thị Sương', '1996-4-30', N'Nữ', N'Khóm 6, Phường 6, TP.Trà Vinh, Tỉnh Trà Vinh', '0123456789', '084639714086', 'suong', '456', 'NhanVien'),
  ('NV007', N'Trần Văn Tâm', '1990-12-11', N'Nam', N'Khóm 7, Phường 7, TP.Trà Vinh, Tỉnh Trà Vinh', '0987654321', '081538408386', 'tam', '456', 'NhanVien'),
  ('NV008', N'Lê Thị Hồng', '1992-8-20', N'Nữ', N'Khóm 8, Phường 8, TP.Trà Vinh, Tỉnh Trà Vinh', '0369871245', '085632970914', 'hong', '789', 'NhanVien'),
  ('NV009', N'Phan Văn Quân', '1994-4-22', N'Nam', N'Khóm 9, Phường 9, TP.Trà Vinh, Tỉnh Trà Vinh', '0543217890', '086278426902', 'quan', '789', 'NhanVien'),
  ('NV010', N'Võ Thị Hảo', '1989-8-8', N'Nữ', N'Khóm 10, Phường 10, TP.Trà Vinh, Tỉnh Trà Vinh', '0789123456', '083652198573', 'hao', '789', 'NhanVien');

-- Them du lieu THIET_BI  
INSERT INTO THIET_BI(Matb, Tentb, Ngaynhap, Soluongmua, NCC, Baohanh, Giamua, Tinhtrang, Ghichu)
VALUES
 ('01',N'Máy chiếu', '2023-1-1', '7',N'Nhà cung cấp A', N'2 năm', N'7.000.000 đồng', N'Tốt', ''),
 ('02', 'Remote', '2023-1-2', '7', N'Nhà cung cấp B', N'2 năm', N'3.500.000 đồng', N'Bình thường', ''),
 ('03', N'Cổng kết nối', '2023-1-3', '10', N'Nhà cung cấp A', N'2 năm', N'1500000 đồng', N'Bình thường', ''),
 ('04', N'Ổ điện', '2023-1-4', '5', N'Nhà cung cấp C', N'2 năm', N'3.000.000 đồng', N'Bình thường', ''),
 ('05', N'Nam châm', '2023-1-5', '30', N'Nhà cung cấp D', N'2 năm', N'240.000 đồng', N'Tốt', ''),
 ('06', 'Micro', '2023-1-6', '7', N'Nhà cung cấp A', N'2 năm', N'1.050.000 đồng', N'Tốt', ''),
 ('07', 'Loa', '2023-1-7', '8', N'Nhà cung cấp B', N'2 năm', N'2.400.000 đồng', N'Bình thường', ''),
 ('08', N'Ống nghiệm', '2023-1-8', '6', N'Nhà cung cấp F', N'2 năm', N'350.000 đồng', N'Bình thường', ''),
 ('09', N'Kẹp gấp ống nghiệm', '2023-1-9', '9', N'Nhà cung cấp F', N'2 năm', N'180.000 đồng', N'Bình thường', ''),
 ('10', N'Đèn cồn', '2023-1-10', '5', N'Nhà cung cấp F', N'2 năm', N'250.000 đồng', N'Bình thường', ''),
 ('00', '', '', '', '', '', '', '', '');
  
-- Thêm dữ liệu bảng PHIEU_MUON
INSERT INTO  PHIEU_MUON(id, Nguoimuon, Gioitinh, CCCD, Sdt, Ngaymuon, Camuon, TenPhong, Soluong, Tentb, manv, Ghichu, Matb)
VALUES 
  ('001', N'Gv.Nguyễn Thị Xuân', N'Nữ', '085412345678', '0343 823 756', '2023-11-01',N'Sáng', N'Phòng lý thuyết 1', '2', N'1.Máy chiếu, 1.Remote', 'NV001', '', '00'),
  ('002', N'Gv.Bùi Quốc Tuấn', N'Nam', '089765436543', '0982 741 232', '2023-11-01', N'Sáng', N'Phòng lý thuyết 2', '2', N'1.Máy chiếu, 1.Remote', 'NV001', '', '00'),
  ('003', N'Gv.Nguyễn Gia Nghi', N'Nữ', '085673290136', '0762 258 313', '2023-11-01', N'Sáng', N'Phòng lý thuyết 3', '3', N'1.Máy chiếu, 1.Remote, 1.Loa', 'NV001', '', '00'),
  ('004', N'Gv.Trần Văn Minh', N'Nam', '085934713168', '0128 356 440', '2023-11-01', N'Chiều', N'Phòng lý thuyết 5', '16', N'1.Ổ điện, 15.Nam châm', 'NV002', '', '00'),
  ('005', N'Gv.Đinh Gia Huy', N'Nam', '084751426082', '0985 541 683', '2023-11-01', N'Chiều', N'Phòng lý thuyết 6', '2', N'1.Loa, 1.Micro', 'NV002', '', '00'),
  ('006', N'Gv.Lê Ngọc Ánh ', N'Nữ', '089252137509', '0985 727 286', '2023-11-02', N'Sáng', N'Phòng thực hành Hóa - Sinh', '15', N'5.Ống nghiệm, 5.Đèn cồn, 5.Kẹp gấp ống nghiệm', 'NV003', '', '00'),
  ('007', N'Gv.Phạm Văn Cường', 'Nam', '083913247507', '0912 343 686', '2023-11-02', N'Sáng', N'Phòng lý thuyết 4', '2', N'1.Máy chiếu, 1.Cổng kết nối', 'NV003', '', '00'),
  ('008', N'Gv.Trần Thu An', N'Nữ', '089271836501', '0937 571 606', '2023-11-02', N'Chiều', N'Phòng lý thuyết 2', '2', N'1.Ổ điện, 1.Loa', 'NV004', '', '00');
  
-- Thêm dữ liệu PHIEU_TRA
INSERT INTO  PHIEU_TRA(mapt, Nguoitra, Gioitinh, CCCD, Sdt, Ngaytra, Catra, TenPhong, Soluong, Tentb, manv, Ghichu, Matb)
VALUES 
  ('PT001', N'Gv.Nguyễn Thị Xuân', N'Nữ', '085412345678', '0343 823 756', '2023-11-01',N'Sáng', N'Phòng lý thuyết 1', '2', N'1.Máy chiếu, 1.Remote', 'NV001', '', '00'),
  ('PT002', N'Gv.Bùi Quốc Tuấn', N'Nam', '089765436543', '0982 741 232', '2023-11-01', N'Sáng', N'Phòng lý thuyết 2', '2', N'1.Máy chiếu, 1.Remote', 'NV001', '', '00'),
  ('PT003', N'Gv.Nguyễn Gia Nghi', N'Nữ', '085673290136', '0762 258 313', '2023-11-01', N'Sáng', N'Phòng lý thuyết 3', '3', N'1.Máy chiếu, 1.Remote, 1.Loa', 'NV001', '', '00'),
  ('PT004', N'Gv.Trần Văn Minh', N'Nam', '085934713168', '0128 356 440', '2023-11-01', N'Chiều', N'Phòng lý thuyết 5', '16', N'1.Ổ điện, 15.Nam châm', 'NV002', '', '00'),
  ('PT005', N'Gv.Đinh Gia Huy', N'Nam', '084751426082', '0985 541 683', '2023-11-01', N'Chiều', N'Phòng lý thuyết 6', '2', N'1.Loa, 1.Micro', 'NV002', '', '00'),
  ('PT006', N'Gv.Lê Ngọc Ánh ', N'Nữ', '089252137509', '0985 727 286', '2023-11-01', N'Sáng', N'Phòng thực hành Hóa - Sinh', '15', N'5.Ống nghiệm, 5.Đèn cồn, 5.Kẹp gấp ống nghiệm', 'NV003', '', '00'),
  ('PT007', N'Gv.Phạm Văn Cường', 'Nam', '083913247507', '0912 343 686', '2023-11-01', N'Sáng', N'Phòng lý thuyết 4', '2', N'1.Máy chiếu, 1.Cổng kết nối', 'NV003', '', '00'),
  ('PT008', N'Gv.Trần Thu An', N'Nữ', '089271836501', '0937 571 606', '2023-11-01', N'Chiều', N'Phòng lý thuyết 2', '2', N'1.Ổ điện, 1.Loa', 'NV004', '', '00');

  
-- Them du lieu PHIEU_NHAP  
INSERT INTO PHIEU_NHAP(Mapn, Tentbm, Soluongnhap, NCC, Gianhap, Ngaynhap, manv, Ghichu)
VALUES
   ('PN001', N'Máy chiếu', '3', N'Nhà cung cấp A', N'3.000.000 đồng', '2023-11-10', 'NV001', ''),
   ('PN002', N'Tivi', '4', N'Nhà cung cấp B', N'16.000.000 đồng', '2023-11-15', 'NV001', ''),
   ('PN003', N'Loa', '2', N'Nhà cung cấp C', N'1.000.000 đồng', '2023-11-14', 'NV002', ''),
   ('PN004', N'Ổ điện', '3', N'Nhà cung cấp A', N'300.000 đồng', '2023-11-17', 'NV002', ''),
   ('PN005', N'Remote', '3', N'Nhà cung cấp A', N'600.000 đồng', '2023-11-10', 'NV001', ''),
   ('PN006', N'Bộ dụng cụ hóa học', '3', N'Nhà cung cấp D', N'5.000.000 đồng', '2023-11-21', 'NV003', N'Dùng trong thực hành');
   
   
UPDATE PHIEU_MUON
SET Ngaymuon = CONVERT(varchar(10), Ngaymuon, 103);