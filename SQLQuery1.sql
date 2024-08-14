﻿CREATE DATABASE QLNS
ON (
	NAME= QLNS_dat,
	FILENAME= 'D:\QLNS_dat.mdf',
	SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 5
)
LOG ON (
	NAME= QLNS_log,
	FILENAME= 'D:\QLNS_log.ldf',
	SIZE = 5,
    MAXSIZE = 25,
    FILEGROWTH = 5
)
GO
USE QLNS
--USE master
--DROP DATABASE QLNS
--DROP TABLE TrinhDo
GO
CREATE TABLE TrinhDo (
	MaTD INT IDENTITY(1,1) PRIMARY KEY,
	TenTD NVARCHAR(255),
)

CREATE TABLE PhongBan (
	MaPB INT IDENTITY(1,1) PRIMARY KEY,
	TenPB NVARCHAR(255)
)

CREATE TABLE ChucVu (
	MaCV INT IDENTITY(1,1) PRIMARY KEY,
	TenCV NVARCHAR(255)
)

CREATE TABLE DanToc (
	MaDT INT IDENTITY(1,1) PRIMARY KEY,
	TenDT NVARCHAR(50) UNIQUE,
)

CREATE TABLE TonGiao (
	MaTG INT IDENTITY(1,1) PRIMARY KEY,
	TenTG NVARCHAR(50) UNIQUE,
)

CREATE TABLE CongTy (
	MaCTY INT IDENTITY(1,1) PRIMARY KEY,
	TenCTY NVARCHAR(50),
	DienThoai NVARCHAR(50),
	Email NVARCHAR(255),
	DiaChi NVARCHAR(255)
)

--CREATE TABLE KhenThuong (
--	MaKT INT IDENTITY(1,1) PRIMARY KEY,
--	TenKT NVARCHAR(50) UNIQUE,
--)

--CREATE TABLE KyLuat (
--	MaKL INT IDENTITY(1,1) PRIMARY KEY,
--	LyDo NVARCHAR(50) UNIQUE,
--)

--CREATE TABLE BaoHiem (
--	MaBH INT IDENTITY(1,1) PRIMARY KEY,
--	SoBaoHiem NVARCHAR(20),
--	NoiCap NVARCHAR(255),
--	NoiDangKyKham NVARCHAR(255),
--	MaNV INT REFERENCES NhanVien(MaNV),
--)

--CREATE TABLE LuongNhanVien (
--	MaLuong INT IDENTITY(1,1) PRIMARY KEY,
--	Luong FLOAT, 
--	Thuong FLOAT,
--	PhuCap FLOAT,
--	LuongKyTruoc FLOAT,
--	UngLuong FLOAT,
--	MaNV INT REFERENCES NhanVien(MaNV),
--)

CREATE TABLE NhanVien (
	MaNV INT IDENTITY(1,1) PRIMARY KEY,
	MaDT INT,
	MaTG INT,
	MaTD INT,
	MaPB INT,
	MaCV INT,
	MaCTY INT,
	HoTen NVARCHAR(50),
	GioiTinh BIT,
	NgaySinh DATE,
	DiaChi NVARCHAR(255),
	CCCD NVARCHAR(20),
	QueQuan NVARCHAR(255),
	NoiOHienTai NVARCHAR(255),
	DienThoai NVARCHAR(10),
	HinhAnh VARBINARY(max),
	FOREIGN KEY (MaDT) REFERENCES DanToc(MaDT),
	FOREIGN KEY (MaTG) REFERENCES TonGiao(MaTG),
	FOREIGN KEY (MaTD) REFERENCES TrinhDo(MaTD),
	FOREIGN KEY (MaPB) REFERENCES PhongBan(MaPB),
	FOREIGN KEY (MaCV) REFERENCES ChucVu(MaCV),
	FOREIGN KEY (MaCTY) REFERENCES CongTy(MaCTY),
)
-- drop table HopDong
CREATE TABLE HopDong (
	SoHD INT PRIMARY KEY,
	NgayKy DATE,
	NgayBatDau DATE,
	NgayKetThuc DATE,
	LanKy NVARCHAR(10),
	ThoiGian NVARCHAR(10),
	HeSoLuong FLOAT,
	NoiDung XML,
	MaNV INT REFERENCES NhanVien(MaNV)
	ON UPDATE CASCADE
	ON DELETE CASCADE
)

--ALTER TABLE NhanVIen
--ADD MaTonGiao INT,
--FOREIGN KEY (MaTonGiao) REFERENCES TonGiao(MaTonGiao);

CREATE TABLE TaiKhoan (
	TaiKhoan NVARCHAR(50) PRIMARY KEY,
	MatKhau NVARCHAR(20),
)

INSERT INTO TaiKhoan
VALUES ('admin', 'admin')

INSERT INTO DanToc (TenDT)
VALUES ('Kinh')

INSERT INTO TonGiao (TenTG)
VALUES (N'Không')

INSERT INTO TrinhDo (TenTD)
VALUES ('12/12'), (N'Cao đẳng')

INSERT INTO PhongBan (TenPB)
VALUES ('IT')

INSERT INTO ChucVu(TenCV)
VALUES (N'Nhân viên')

SELECT NV.MaNV, DT.TenDT, TG.TenTG, TD.TenTD, PB.TenPB, CV.TenCV, CTY.TenCTY, NV.HoTen, NV.GioiTinh, NV.NgaySinh, NV.DiaChi, NV.CCCD, NV.QueQuan, NV.NoiOHienTai, NV.DienThoai, NV.HinhAnh  
FROM NhanVien NV
INNER JOIN DanToc DT ON NV.MaDT = DT.MaDT
INNER JOIN TonGiao TG ON NV.MaTG = TG.MaTG
INNER JOIN TrinhDo TD ON NV.MaTD = TD.MaTD 
INNER JOIN PhongBan PB ON NV.MaPB = PB.MaPB 
INNER JOIN ChucVu CV ON NV.MaCV = CV.MaCV 
INNER JOIN CongTy CTY ON NV.MaCTY = CTY.MaCTY

INSERT INTO CongTy(TenCTY, DienThoai, Email, DiaChi)
VALUES (N'CTY TNHH Hiền Phát Vi Na', '02513511610', 'gashienphat1979@gmail.com', N'Quốc lộ 51, An Phước, Long Thành, Đồng Nai')