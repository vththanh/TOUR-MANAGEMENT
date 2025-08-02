-- Tạo database
USE master;
GO
IF  EXISTS (
	SELECT name 
		FROM sys.databases 
		WHERE name = N'TOUR_MANAGEMENT'
)
DROP DATABASE TOUR_MANAGEMENT
GO
CREATE DATABASE TOUR_MANAGEMENT ;
GO
USE TOUR_MANAGEMENT;
GO
-- Bảng Chức vụ
CREATE TABLE ChucVu (
    MaCV CHAR(2) PRIMARY KEY,
    TenCV NVARCHAR(50)
);
-- Bảng Loại tour (trong nước / nước ngoài)
CREATE TABLE LOAITOUR (
    MaLoaiTour CHAR(2) PRIMARY KEY,
    TenLoaiTour NVARCHAR(100) 
);
-- Bảng Nhân viên
CREATE TABLE NhanVien (
    MaNV CHAR(5) PRIMARY KEY,
    HoTen NVARCHAR(100),
    GioiTinh NVARCHAR(5) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    NgaySinh DATE,
    Email VARCHAR(255),
    DiaChi NVARCHAR(200),
    SDT VARCHAR(20),
    MaCV CHAR(2) NOT NULL,
    FOREIGN KEY (MaCV) REFERENCES ChucVu(MaCV)
);
-- Bảng Tài khoản
CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY NOT NULL,
    MatKhau VARCHAR(50) NOT NULL,
    MaNV CHAR(5) NOT NULL,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
-- Bảng Khách hàng
CREATE TABLE KHACHHANG (
    MaKH CHAR(5) PRIMARY KEY,
    HoTen NVARCHAR(100),
    GioiTinh NVARCHAR(5) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    SDT VARCHAR(20),
    Email VARCHAR(255)
);
-- Bảng Điểm xuất phát
CREATE TABLE DIEMXUATPHAT (
    MaXP CHAR(5) PRIMARY KEY,
    DiaDiemXP NVARCHAR(200)
);
-- Bảng Điểm du lịch
CREATE TABLE DIEMDULICH (
    MaDDL CHAR(5) PRIMARY KEY,
    TenDDL NVARCHAR(200),
	MaLoaiTour CHAR(2) NOT NULL, 
    FOREIGN KEY (MaLoaiTour) REFERENCES LOAITOUR(MaLoaiTour)
);
-- Bảng Phương tiện tour
CREATE TABLE PHUONGTIENTOUR (
    MaPhuongTien CHAR(5) PRIMARY KEY,
    TenPhuongTien NVARCHAR(100)
);
-- Bảng thông tin Tour
CREATE TABLE THONGTINTOUR (
    MaTour CHAR(4) PRIMARY KEY,
    TenTour NVARCHAR(200),
    MoTaTour NVARCHAR(MAX),
    AnhTour NVARCHAR(255),
    GiaTour DECIMAL(18,2) CHECK (GiaTour > 0),
    TGBatDau DATE,
    TGKetThuc DATE,
    MaLoaiTour CHAR(2) NOT NULL,
    MaPhuongTien CHAR(5),
    MaXP CHAR(5),
    MaDDL CHAR(5),
    CONSTRAINT FK_ThongTinTour_MaLoaiTour FOREIGN KEY (MaLoaiTour) REFERENCES LOAITOUR(MaLoaiTour),
    CONSTRAINT FK_ThongTinTour_MaPhuongTien FOREIGN KEY (MaPhuongTien) REFERENCES PhuongTienTour(MaPhuongTien) ON DELETE SET NULL,
    CONSTRAINT FK_ThongTinTour_MaXP FOREIGN KEY (MaXP) REFERENCES DiemXuatPhat(MaXP) ON DELETE SET NULL,
    CONSTRAINT FK_ThongTinTour_MaDDL FOREIGN KEY (MaDDL) REFERENCES DiemDuLich(MaDDL) ON DELETE SET NULL
);
-- Bảng Hóa đơn 
CREATE TABLE HOADON (
    SoHD char(5) PRIMARY KEY,
    MaNV CHAR(5) NOT NULL ,
    MaKH CHAR(5) NOT NULL,
    MaTour CHAR(4),
    SoLuongVe INT CHECK (SoLuongVe >=1),
    NgayDangKy DATETIME,
    NgayLapHD DATETIME,
    ThanhTien DECIMAL(18,2),
	CONSTRAINT FK_HoaDon_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    CONSTRAINT FK_HoaDon_MaKH FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT FK_HoaDon_MaTour FOREIGN KEY (MaTour) REFERENCES ThongTinTour(MaTour) ON DELETE SET NULL,
	CONSTRAINT CK_HoaDon_Ngay CHECK (
        NgayDangKy <= NgayLapHD
        AND NgayDangKy <= GETDATE()
        AND NgayLapHD <= GETDATE())
);
GO
-- Tự động cập nhật ThanhTien trong bảng HOADON khi thêm hoặc sửa hóa đơn
CREATE TRIGGER trg_Update_ThanhTien
ON HOADON
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE HOADON
    SET ThanhTien = tt.GiaTour * hd.SoLuongVe
    FROM HOADON hd
    JOIN inserted i ON hd.SoHD = i.SoHD
    JOIN THONGTINTOUR tt ON hd.MaTour = tt.MaTour;
END;
GO
--===============THÊM GIÁ TRỊ DỮ LIỆU===============================
INSERT INTO ChucVu (MaCV, TenCV) VALUES
('QL', N'Quản lý'),
('NV', N'Nhân viên');

INSERT INTO NhanVien (MaNV, HoTen, GioiTinh, NgaySinh, Email, DiaChi, SDT, MaCV) VALUES
('NV001', N'Nguyễn Minh Châu', N'Nữ', '2004-02-03', 'chau@gmail.com', N'Tp.Hồ Chí Minh', '0912345678', 'QL'),
('NV002', N'Võ Thị Hiền Thanh', N'Nữ', '2004-02-24', 'thanh@gmail.com', N'Đà Nẵng', '0934567890', 'NV');

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, MaNV) VALUES
('minhchau', '123', 'NV001'),
('hienthanh', '123', 'NV002');

INSERT INTO KHACHHANG (MaKH, HoTen, GioiTinh, SDT, Email) VALUES
('KH001', N'Phạm Văn C', N'Nam', N'0987654321', N'c@gmail.com'),
('KH002', N'Lê Thị D', N'Nữ', N'0978123456', N'd@gmail.com'),
('KH003', N'Le Nhan', N'Nam', N'9876543211 ', N'vanc@email.com'),
('KH004', N'Le Thi Minh', N'Nam', N'0912345678 ', N'minhle@email.com'),
('KH005', N'Pham Van Hau', N'Nam', N'0987654321 ', N'hau.pham@email.com'),
('KH006', N'Nguyen Anh Tuan', N'Nam', N'0365897412 ', N'tuanna@email.com'),
('KH007', N'Tran Thi Nga', N'Nữ', N'0777777777 ', N'ngatran@email.com'),
('KH008', N'Hoang Van Cuong', N'Nam', N'0123456789 ', N'cuonghoang@email.com'),
('KH009', N'Doan Ngoc Thao', N'Nữ', N'0933333333 ', N'thaongoc@email.com'),
('KH010', N'Vu Thi Hien', N'Nữ', N'0888888888 ', N'hienvu@email.com');

INSERT INTO LOAITOUR (MaLoaiTour, TenLoaiTour) VALUES
('TN', N'Trong nước'),
('NN', N'Nước ngoài');

INSERT INTO DIEMXUATPHAT (MaXP, DiaDiemXP) VALUES
('XP001', N'Hà Nội'),
('XP002', N'Hồ Chí Minh'),
('XP003', N'Hải Phòng'),
('XP004', N'Đà Lạt'),
('XP005', N'Cần Thơ'),
('XP006', N'Nha Trang'),
('XP007', N'Phú Quốc');

INSERT INTO DIEMDULICH (MaDDL, TenDDL, MaLoaiTour) VALUES
('DL001', N'Hạ Long', 'TN'),
('DL002', N'Sapa', 'TN'),
('DL003', N'Paris', 'NN'),
('DL004', N'Phú Quốc','TN'),
('DL005', N'Singapore', 'NN'),
('DL006', N'Malaysia', 'NN'),
('DL007', N'Hàn Quốc', 'NN'),
('DL008', N'Hội An', 'TN'),
('DL009', N'Bali', 'NN'),
('DL010', N'Kyoto', 'NN');

INSERT INTO PHUONGTIENTOUR(MaPhuongTien, TenPhuongTien) VALUES
('PT001', N'Máy bay'),
('PT002', N'Xe khách'),
('PT003', N'Xe du lịch 16 chỗ'),
('PT004', N'Xe du lịch 45 chỗ'),
('PT005', N'Xe giường nằm'),
('PT006', N'Tàu hỏa');

INSERT INTO THONGTINTOUR(MaTour, TenTour, MoTaTour, AnhTour, GiaTour, TGBatDau, TGKetThuc, MaLoaiTour, MaPhuongTien, MaXP, MaDDL) VALUES
('T001', N'Tour Hạ Long 3 ngày 2 đêm', N'Tham quan vịnh Hạ Long', 'halong.jpg', 3500000, '2025-06-01', '2025-06-03', 'TN', 'PT001', 'XP001', 'DL001'),
('T002', N'Tour châu Âu – Pháp', N'Tham quan Paris và Versailles', 'paris.jpg', 29000000, '2025-07-10', '2025-07-13', 'NN', 'PT001', 'XP002', 'DL003'),
('T003', N'Tour Singapore', N'Khám phá sự sôi động và hiện đại của Singapore, từ khu vực Merlion đến khu mua sắm Orchard Road.', 'sp1.jpg', 6000000.0, '2025-01-01', '2025-01-06', 'NN', 'PT001', 'XP001', 'DL005'),
('T004', N'Tour Malaysia', 'Trải nghiệm văn hóa đa dạng của Malaysia, từ tháp đôi Petronas đến các đền đài ấn tượng.', 'malaysia1.jpg', 5500000.0, '2025-03-01', '2025-03-06', 'NN', 'PT001', 'XP002', 'DL006'),
('T005', N'Tour Singapore2', 'Khám phá sự sôi động và hiện đại của Singapore, từ khu vực Merlion đến khu mua sắm Orchard Road.', 'sp1.jpg', 6000000.0, '2025-01-01', '2025-01-06', 'NN', 'PT001', 'XP002', 'DL005'),
('T006', N'Tour Hội An', 'Thăm quan khu phố cổ Hội An với những ngôi nhà cổ truyền thống và đèn lồng lung linh.', 'hoian1.jpg', 5500000.0, '2025-01-10', '2025-01-15', 'TN', 'PT001', 'XP001', 'DL008'),
('T007', N'Tour Bali', 'Nghỉ dưỡng tại hòn đảo thiên đàng Bali, khám phá đền Hindu và thưởng thức ẩm thực độc đáo.', 'bali1.jpg', 6500000.0, '2025-02-01', '2025-02-03', 'NN', 'PT001', 'XP002', 'DL009'),
('T008', N'Tour Kyoto', 'Thăm quan Kyoto - thành phố của các đền đài lịch sử và văn hóa truyền thống.', 'kyoto1.jpg', 7500000.0, '2025-04-01', '2025-04-05', 'NN', 'PT001', 'XP001', 'DL010'),
('T009', N'Tour Phú Quốc', N'Nghỉ dưỡng tại resort 5 sao, tham quan những bãi biển tuyệt đẹp và thử các món đặc sản đảo ngọc.', 'phuquoc1.jpg', 4500000.00, '2025-01-10', '2025-01-14', 'TN', N'PT003', N'XP007', N'DL004');
INSERT INTO HOADON (SoHD, MaNV, MaKH, MaTour, SoLuongVe, NgayDangKy, NgayLapHD) VALUES
('HD001', 'NV001', 'KH001', 'T001', 2, '2025-05-01', '2025-05-01'),  
('HD002', 'NV002', 'KH002', 'T002', 1, '2024-06-15', '2024-06-15'),
('HD003', 'NV002', 'KH005', 'T003', 3, '2024-12-20', '2024-12-20'), 
('HD004', 'NV002', 'KH003', 'T007', 2, '2025-02-01', '2025-02-01'), 
('HD005', 'NV001', 'KH004', 'T002', 1, '2025-04-15', '2025-04-15'), 
('HD006', 'NV002', 'KH007', 'T008', 4, '2025-01-15', '2025-01-15'), 
('HD007', 'NV002', 'KH006', 'T009', 5, '2025-01-01', '2025-01-01'),
('HD008', 'NV002', 'KH010', 'T006', 2, '2025-01-05', '2025-01-05'),
('HD009', 'NV001', 'KH009', 'T001', 1, '2025-03-15', '2025-03-15'), 
('HD010', 'NV002', 'KH008', 'T005', 2, '2024-12-15', '2024-12-15'); 
