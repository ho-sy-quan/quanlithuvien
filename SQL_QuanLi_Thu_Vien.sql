create database QL_Thu_Vien
go

use QL_Thu_Vien
go


CREATE TABLE nguoidung (
  id_nguoidung INT PRIMARY KEY IDENTITY(1,1),
  tendangnhap NVARCHAR(255) NOT NULL,
  matkhau NVARCHAR(255) NOT NULL
);

CREATE TABLE vaiTro (
  id_vaitro INT PRIMARY KEY IDENTITY(1,1),
  tenVaiTro NVARCHAR(255) NOT NULL,
  id_nguoidung INT,
  FOREIGN KEY (id_nguoidung) REFERENCES nguoidung(id_nguoidung)
);

CREATE TABLE khachhang (
  ma_khachhang INT PRIMARY KEY IDENTITY(1,1),
  ten_khachhang NVARCHAR(255) NOT NULL,
  so_dienthoai NVARCHAR(20),
);

CREATE TABLE dausach (
  ma_dausach INT PRIMARY KEY IDENTITY(1,1),
  ten_dausach NVARCHAR(255) NOT NULL,
  so_luong INT,
  ten_tacgia NVARCHAR(255),
  theloai NVARCHAR(255),
  soluongconlai int,
 
);

CREATE TABLE sach (
  id_sach INT PRIMARY KEY IDENTITY(1,1),
  Trangthai bit,
  id_dausach INT,
  FOREIGN KEY (id_dausach) REFERENCES dausach(ma_dausach)
);

CREATE TABLE nhanvien (
  ma_nhanvien INT PRIMARY KEY IDENTITY(1,1),
  ten_nhanvien NVARCHAR(255) NOT NULL,
  so_dienthoai NVARCHAR(20),
  dia_chi NVARCHAR(255),
  gioitinh NVARCHAR(10)
);

CREATE TABLE hoadon_thue (
  id_hoadon_thue INT PRIMARY KEY IDENTITY(1,1),
  ngay_thue DATE,
  id_dausach INT,
  id_khachhang INT,
  gia_thue float,
  tien_coc float,
  FOREIGN KEY (id_dausach) REFERENCES dausach(ma_dausach),
  FOREIGN KEY (id_khachhang) REFERENCES khachhang(ma_khachhang)
);

CREATE TABLE hoadon_tra (
  id_hoadon_tra INT PRIMARY KEY IDENTITY(1,1),
  ngay_tra DATE,
  id_hoadon_thue INT,
  FOREIGN KEY (id_hoadon_thue) REFERENCES hoadon_thue(id_hoadon_thue)
);

INSERT INTO nguoidung (tendangnhap, matkhau)
VALUES
  (N'hosyquan', N'123456'),
  (N'user2', N'password2'),
  (N'user3', N'password3'),
  (N'user4', N'password4'),
  (N'user5', N'password5');

INSERT INTO vaiTro (tenVaiTro, id_nguoidung)
VALUES
  (N'ADMIN', 1),
  (N'Người dùng', 2),
  (N'Người dùng', 3),
  (N'Người dùng', 4),
  (N'Người dùng', 5);

INSERT INTO khachhang (ten_khachhang, so_dienthoai)
VALUES
  (N'Khách hàng 1', N'0123456789'),
  (N'Khách hàng 2', N'0987654321'),
  (N'Khách hàng 3', N'0123412345'),
  (N'Khách hàng 4', N'0987609876'),
  (N'Khách hàng 5', N'0123498765');

INSERT INTO dausach (ten_dausach, so_luong, ten_tacgia, theloai,soluongconlai)
VALUES
  (N'Đầu sách 1- 1357', 2, N'Đinh mặc', N'Trinh thám',2),
  (N'Đầu sách 2', 5, N'Tác giả 2', N'Thể loại 2',5),
  (N'Đầu sách 3', 3, N'Tác giả 3', N'Thể loại 1',3),
  (N'Đầu sách 4', 8, N'Tác giả 1', N'Thể loại 3',8),
  (N'Đầu sách 5', 2, N'Tác giả 2', N'Thể loại 2',2);

INSERT INTO sach (Trangthai,id_dausach)
VALUES
  (1,1),
  (1,1),
  (1,3),
  (1,4),
  (1,5);

INSERT INTO nhanvien (ten_nhanvien, so_dienthoai, dia_chi, gioitinh)
VALUES
  (N'Nhân viên 1', N'0123456789', N'Địa chỉ 1', N'Nam'),
  (N'Nhân viên 2', N'0987654321', N'Địa chỉ 2', N'Nữ'),
  (N'Nhân viên 3', N'0123412345', N'Địa chỉ 3', N'Nam'),
  (N'Nhân viên 4', N'0987609876', N'Địa chỉ 4', N'Nữ'),
  (N'Nhân viên 5', N'0123498765', N'Địa chỉ 5', N'Nam');

INSERT INTO hoadon_thue (ngay_thue, id_dausach, id_khachhang, gia_thue, tien_coc)
VALUES
  ('2024-03-01', 1, 1, 10.5, 5.0),
  ('2024-03-02', 2, 2, 8.0, 3.0),
  ('2024-03-03', 3, 3, 7.2, 2.5),
  ('2024-03-04', 4, 4, 12.3, 6.0),
  ('2024-03-05', 5, 5, 9.9, 4.5);

INSERT INTO hoadon_tra (ngay_tra, id_hoadon_thue)
VALUES
  ('2024-03-06', 1),
  ('2024-03-07', 2),
  ('2024-03-08', 3),
  ('2024-03-09', 4),
  ('2024-03-10', 5);