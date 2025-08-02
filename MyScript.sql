USE TOUR_MANAGEMENT
GO

CREATE PROC uspAddNV
	@MaNV       CHAR(5),
	@HoTen      NVARCHAR(100),
	@GioiTinh   NVARCHAR(10),
	@NgaySinh   DATE,
	@Email      VARCHAR(100),
	@DiaChi     NVARCHAR(200),
	@SDT        VARCHAR(20),
	@maCV       CHAR(2)
AS
BEGIN
	INSERT INTO NhanVien(MaNV,HoTen,GioiTinh,NgaySinh,Email,DiaChi,SDT,MaCV)
		VALUES(@MaNV,@HoTen,@GioiTinh,@NgaySinh,@Email,@DiaChi,@SDT,@MaCV)
END
GO

CREATE PROC uspAddKH
    @MaKH      CHAR(5),
    @HoTen     NVARCHAR(100),
    @GioiTinh  NVARCHAR(5),
    @Sdt       VARCHAR(20),
    @Email     VARCHAR(255)
AS
BEGIN
    INSERT INTO KHACHHANG(MaKH, HoTen, GioiTinh, Sdt, Email)
    VALUES(@MaKH, @HoTen, @GioiTinh, @Sdt, @Email)
END
GO

CREATE PROCEDURE uspAddTour
    @MaTour         CHAR(4),
    @TenTour        NVARCHAR(200),
    @MoTaTour       NVARCHAR(MAX),
    @AnhTour        NVARCHAR(255),
    @GiaTour        DECIMAL(18, 2),
    @TGBatDau       DATE,
    @TGKetThuc      DATE,
    @MaLoaiTour     CHAR(2),
    @MaPhuongTien   CHAR(5),
    @MaXP           CHAR(5),
    @MaDDL          CHAR(5)
AS
BEGIN
    INSERT INTO THONGTINTOUR (MaTour, TenTour, MoTaTour, AnhTour, GiaTour, 
                      TGBatDau, TGKetThuc, MaLoaiTour, MaPhuongTien, MaXP, MaDDL)
    VALUES (@MaTour, @TenTour, @MoTaTour, @AnhTour, @GiaTour, 
            @TGBatDau, @TGKetThuc, @MaLoaiTour, @MaPhuongTien, @MaXP, @MaDDL);
END
GO

CREATE PROCEDURE uspAddHoaDon
    @SoHD        CHAR(5),
    @MaNV        CHAR(5),
    @MaKH        CHAR(5),
    @MaTour      CHAR(4),
    @SoLuongVe   INT,
    @NgayDangKy  DATETIME,
    @NgayLapHD   DATETIME,
    @ThanhTien   DECIMAL(18, 2)
AS
BEGIN
    INSERT INTO HOADON (SoHD, MaNV, MaKH, MaTour, SoLuongVe, NgayDangKy, NgayLapHD, ThanhTien)
    VALUES (@SoHD, @MaNV, @MaKH, @MaTour, @SoLuongVe, @NgayDangKy, @NgayLapHD, @ThanhTien)
END
GO

CREATE PROCEDURE uspUpdateTour
    @MaTour         CHAR(4),
    @TenTour        NVARCHAR(200),
    @MoTaTour       NVARCHAR(MAX),
    @AnhTour        NVARCHAR(255),
    @GiaTour        DECIMAL(18, 2),
    @TGBatDau       DATE,
    @TGKetThuc      DATE,
    @MaLoaiTour     CHAR(2),
    @MaPhuongTien   CHAR(5),
    @MaXP           CHAR(5),
    @MaDDL          CHAR(5)
AS
BEGIN
    UPDATE THONGTINTOUR
    SET TenTour = @TenTour,
        MoTaTour = @MoTaTour,
        AnhTour = @AnhTour,
        GiaTour = @GiaTour,
        TGBatDau = @TGBatDau,
        TGKetThuc = @TGKetThuc,
        MaLoaiTour = @MaLoaiTour,
        MaPhuongTien = @MaPhuongTien,
        MaXP = @MaXP,
        MaDDL = @MaDDL
    WHERE MaTour = @MaTour;
END
GO

CREATE PROC uspUpdateKH
    @maKH           CHAR(5),
    @hoTen          NVARCHAR(100),
    @gioiTinh       NVARCHAR(5),
    @sdt            VARCHAR(20),
    @email          VARCHAR(255)
AS
BEGIN
    UPDATE KHACHHANG 
    SET HoTen = @hoTen, 
        Sdt = @sdt, 
        Email = @email, 
        GioiTinh = @gioiTinh 
    WHERE MaKH = @maKH
END
GO

CREATE PROC uspUpdateNV
    @MaNV CHAR(5),
    @HoTen NVARCHAR(100),
    @GioiTinh NVARCHAR(5),
    @NgaySinh DATE,
    @Email NVARCHAR(255),
    @DiaChi NVARCHAR(200),
    @SDT NVARCHAR(20),
    @MaCV CHAR(2)
AS
BEGIN
    UPDATE NhanVien
    SET 
        HoTen = @HoTen,
        GioiTinh = @GioiTinh,
        NgaySinh = @NgaySinh,
        Email = @Email,
        DiaChi = @DiaChi,
        SDT = @SDT,
        MaCV = @MaCV
    WHERE MaNV = @MaNV
END
GO

CREATE PROC uspAddAccount
    @TenDangNhap    VARCHAR(50),
    @MatKhau        VARCHAR(50),
    @MaNV           CHAR(5)
AS
BEGIN
    INSERT INTO TaiKhoan
    VALUES(@TenDangNhap, @MatKhau, @MaNV)
END
GO

CREATE PROCEDURE uspDeleteKhachHang
    @MaKH CHAR(5)
AS
BEGIN
    DELETE FROM KHACHHANG WHERE MaKH = @MaKH
END
GO

CREATE PROC uspDeleteTour
    @MaTour CHAR(4)
AS
BEGIN
    DELETE FROM THONGTINTOUR
    WHERE MaTour = @MaTour
END
GO

CREATE PROCEDURE uspDeleteHoaDon
    @SoHD CHAR(5)
AS
BEGIN
    DELETE FROM HOADON WHERE SoHD = @SoHD
END
GO
