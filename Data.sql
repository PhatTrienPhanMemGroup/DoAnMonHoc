CREATE DATABASE dbQuanLyQuanCafe
GO

USE dbQuanLyQuanCafe
GO

-- DoUong (Drinks)
-- Ban (Table)
-- DanhMucDoUong (DrinksCategory)
-- TaiKhoan (Account)
-- HoaDon (Bill)
-- ChiTietHoaDon (BillInfo)

CREATE TABLE tbl_Table
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR (100) NOT NULL DEFAULT N'Bàn chưa đặt tên',
	status NVARCHAR(50) NOT NULL DEFAULT N'Trống' --Trống, Có người
)
GO
CREATE TABLE tbl_Account
(
	userName NVARCHAR(100) PRIMARY KEY,
	displayName NVARCHAR(100) NOT NULL, 	
	passWord NVARCHAR(100) NOT NULL DEFAULT 123,
	type INT NOT NULL DEFAULT 0 -- 1:Quản lý, 0:Nhân viên thu ngân
)
GO

CREATE TABLE tbl_DrinksCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR (100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE tbl_Drinks
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR (100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	FOREIGN KEY (idCategory) REFERENCES tbl_DrinksCategory(id)
)
GO

CREATE TABLE tbl_Bill
(
	id INT IDENTITY PRIMARY KEY,
	dateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	dateCheckOut DATE,
	idTable INT NOT NULL, 
	status INT NOT NULL DEFAULT 0 --1: Đã thanh toán, 0: Chưa thanh toán (Mặc định là chưa thanh toán)
	FOREIGN KEY (idTable) REFERENCES tbl_Table(id)
)
Go

CREATE TAble tbl_BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idDrinks INT NOT NULL,
	count INT NOT NULL DEFAULT 0 --Số lượng
	FOREIGN KEY (idBill) REFERENCES tbl_Bill(id),
	FOREIGN KEY (idDrinks) REFERENCES tbl_Drinks(id)
)
GO