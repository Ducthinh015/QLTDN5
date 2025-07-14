CREATE DATABASE QLTDN5;
GO
USE QLTDN5;
GO

    CREATE TABLE NhanVien (
        Id INT PRIMARY KEY IDENTITY(1,1),
        MaNV NVARCHAR(20) NOT NULL,
        TenNV NVARCHAR(100) NOT NULL,
        DienThoai NVARCHAR(20),
        Email NVARCHAR(100),
        TaiKhoan NVARCHAR(50) NOT NULL,
        MatKhau NVARCHAR(100) NOT NULL,
        VaiTro NVARCHAR(20) NOT NULL
    );
    
GO

    CREATE TABLE KhachHang (
        Id INT PRIMARY KEY IDENTITY(1,1),
        KhachHangId INT,
        MaKH NVARCHAR(MAX),
        TenKhachHang NVARCHAR(MAX),
        DiaChi NVARCHAR(MAX),
        SoDienThoai NVARCHAR(MAX),
        CCCD NVARCHAR(MAX),
        Email NVARCHAR(MAX),
        MaSoThue NVARCHAR(MAX),
        GhiChu NVARCHAR(MAX)
    );
    
GO

    CREATE TABLE HoaDon (
        Id INT PRIMARY KEY IDENTITY(1,1),
        KhachHangId INT NOT NULL,
        NgayLap DATETIME NOT NULL,
        
        SoTien DECIMAL(18, 2) NOT NULL,
        FOREIGN KEY (KhachHangId) REFERENCES KhachHang(Id)
    );
    
GO

    CREATE TABLE BangGia (
        Id INT PRIMARY KEY IDENTITY(1,1),
        MaBac NVARCHAR(MAX),
        TenBac NVARCHAR(MAX),
        MaGia INT,
        MoTa NVARCHAR(MAX),
        MucDien NVARCHAR(MAX) NOT NULL,
        DonGia DECIMAL(18, 2) NOT NULL
    );
    
GO

    CREATE TABLE TramDien (
        Id INT PRIMARY KEY IDENTITY(1,1),
        MaTram NVARCHAR(MAX),
        TenTram NVARCHAR(MAX),
        ViTri NVARCHAR(MAX),
        GhiChu NVARCHAR(MAX)
    );
    
GO

    CREATE TABLE CongToDien (
        Id INT PRIMARY KEY IDENTITY(1,1),
        SoSerial NVARCHAR(MAX),
        MaCongTo NVARCHAR(MAX),
        KhachHangId INT NOT NULL,
        TrangThai BIT NOT NULL,
        FOREIGN KEY (KhachHangId) REFERENCES KhachHang(Id)
    );
    
GO

    CREATE TABLE ChiSoDien (
        Id INT PRIMARY KEY IDENTITY(1,1),
        CongToDienId INT NOT NULL,
        NgayGhi DATETIME NOT NULL,
        ChiSoCu INT NOT NULL,
        ChiSoMoi INT NOT NULL,
        ThangNam DATETIME NOT NULL,
        FOREIGN KEY (CongToDienId) REFERENCES CongToDien(Id)
    );
    
INSERT INTO NhanVien (MaNV, TenNV, DienThoai, Email, TaiKhoan, MatKhau, VaiTro) VALUES ('NV01', N'Nhân viên 1', '0900000001', 'nv1@mail.com', 'nv1', '123', 'NhanVien');
INSERT INTO NhanVien (MaNV, TenNV, DienThoai, Email, TaiKhoan, MatKhau, VaiTro) VALUES ('NV02', N'Nhân viên 2', '0900000002', 'nv2@mail.com', 'nv2', '123', 'NhanVien');
INSERT INTO NhanVien (MaNV, TenNV, DienThoai, Email, TaiKhoan, MatKhau, VaiTro) VALUES ('NV03', N'Nhân viên 3', '0900000003', 'nv3@mail.com', 'nv3', '123', 'NhanVien');
INSERT INTO NhanVien (MaNV, TenNV, DienThoai, Email, TaiKhoan, MatKhau, VaiTro) VALUES ('NV04', N'Nhân viên 4', '0900000004', 'nv4@mail.com', 'nv4', '123', 'NhanVien');
INSERT INTO NhanVien (MaNV, TenNV, DienThoai, Email, TaiKhoan, MatKhau, VaiTro) VALUES ('NV05', N'Nhân viên 5', '0900000005', 'nv5@mail.com', 'nv5', '123', 'NhanVien');
INSERT INTO NhanVien (MaNV, TenNV, DienThoai, Email, TaiKhoan, MatKhau, VaiTro) VALUES ('NV06', N'Nhân viên 6', '0900000006', 'nv6@mail.com', 'nv6', '123', 'NhanVien');
INSERT INTO NhanVien (MaNV, TenNV, DienThoai, Email, TaiKhoan, MatKhau, VaiTro) VALUES ('NV07', N'Nhân viên 7', '0900000007', 'nv7@mail.com', 'nv7', '123', 'NhanVien');
INSERT INTO NhanVien (MaNV, TenNV, DienThoai, Email, TaiKhoan, MatKhau, VaiTro) VALUES ('NV08', N'Nhân viên 8', '0900000008', 'nv8@mail.com', 'nv8', '123', 'NhanVien');
INSERT INTO NhanVien (MaNV, TenNV, DienThoai, Email, TaiKhoan, MatKhau, VaiTro) VALUES ('NV09', N'Nhân viên 9', '0900000009', 'nv9@mail.com', 'nv9', '123', 'NhanVien');
INSERT INTO NhanVien (MaNV, TenNV, DienThoai, Email, TaiKhoan, MatKhau, VaiTro) VALUES ('NV010', N'Nhân viên 10', '09000000010', 'nv10@mail.com', 'nv10', '123', 'NhanVien');
INSERT INTO KhachHang (KhachHangId, MaKH, TenKhachHang, DiaChi, SoDienThoai, CCCD, Email, MaSoThue, GhiChu) VALUES (1, 'KH01', N'Khách hàng 1', N'Địa chỉ 1', '0980000001', '12345678901', 'kh1@mail.com', 'MST001', '');
INSERT INTO KhachHang (KhachHangId, MaKH, TenKhachHang, DiaChi, SoDienThoai, CCCD, Email, MaSoThue, GhiChu) VALUES (2, 'KH02', N'Khách hàng 2', N'Địa chỉ 2', '0980000002', '12345678902', 'kh2@mail.com', 'MST002', '');
INSERT INTO KhachHang (KhachHangId, MaKH, TenKhachHang, DiaChi, SoDienThoai, CCCD, Email, MaSoThue, GhiChu) VALUES (3, 'KH03', N'Khách hàng 3', N'Địa chỉ 3', '0980000003', '12345678903', 'kh3@mail.com', 'MST003', '');
INSERT INTO KhachHang (KhachHangId, MaKH, TenKhachHang, DiaChi, SoDienThoai, CCCD, Email, MaSoThue, GhiChu) VALUES (4, 'KH04', N'Khách hàng 4', N'Địa chỉ 4', '0980000004', '12345678904', 'kh4@mail.com', 'MST004', '');
INSERT INTO KhachHang (KhachHangId, MaKH, TenKhachHang, DiaChi, SoDienThoai, CCCD, Email, MaSoThue, GhiChu) VALUES (5, 'KH05', N'Khách hàng 5', N'Địa chỉ 5', '0980000005', '12345678905', 'kh5@mail.com', 'MST005', '');
INSERT INTO KhachHang (KhachHangId, MaKH, TenKhachHang, DiaChi, SoDienThoai, CCCD, Email, MaSoThue, GhiChu) VALUES (6, 'KH06', N'Khách hàng 6', N'Địa chỉ 6', '0980000006', '12345678906', 'kh6@mail.com', 'MST006', '');
INSERT INTO KhachHang (KhachHangId, MaKH, TenKhachHang, DiaChi, SoDienThoai, CCCD, Email, MaSoThue, GhiChu) VALUES (7, 'KH07', N'Khách hàng 7', N'Địa chỉ 7', '0980000007', '12345678907', 'kh7@mail.com', 'MST007', '');
INSERT INTO KhachHang (KhachHangId, MaKH, TenKhachHang, DiaChi, SoDienThoai, CCCD, Email, MaSoThue, GhiChu) VALUES (8, 'KH08', N'Khách hàng 8', N'Địa chỉ 8', '0980000008', '12345678908', 'kh8@mail.com', 'MST008', '');
INSERT INTO KhachHang (KhachHangId, MaKH, TenKhachHang, DiaChi, SoDienThoai, CCCD, Email, MaSoThue, GhiChu) VALUES (9, 'KH09', N'Khách hàng 9', N'Địa chỉ 9', '0980000009', '12345678909', 'kh9@mail.com', 'MST009', '');
INSERT INTO KhachHang (KhachHangId, MaKH, TenKhachHang, DiaChi, SoDienThoai, CCCD, Email, MaSoThue, GhiChu) VALUES (10, 'KH010', N'Khách hàng 10', N'Địa chỉ 10', '09800000010', '123456789010', 'kh10@mail.com', 'MST0010', '');
INSERT INTO HoaDon (KhachHangId, NgayLap, SoTien) VALUES (1, '2024-06-01', 101000);
INSERT INTO HoaDon (KhachHangId, NgayLap, SoTien) VALUES (2, '2024-06-02', 102000);
INSERT INTO HoaDon (KhachHangId, NgayLap, SoTien) VALUES (3, '2024-06-03', 103000);
INSERT INTO HoaDon (KhachHangId, NgayLap, SoTien) VALUES (4, '2024-06-04', 104000);
INSERT INTO HoaDon (KhachHangId, NgayLap, SoTien) VALUES (5, '2024-06-05', 105000);
INSERT INTO HoaDon (KhachHangId, NgayLap, SoTien) VALUES (6, '2024-06-06', 106000);
INSERT INTO HoaDon (KhachHangId, NgayLap, SoTien) VALUES (7, '2024-06-07', 107000);
INSERT INTO HoaDon (KhachHangId, NgayLap, SoTien) VALUES (8, '2024-06-08', 108000);
INSERT INTO HoaDon (KhachHangId, NgayLap, SoTien) VALUES (9, '2024-06-09', 109000);
INSERT INTO HoaDon (KhachHangId, NgayLap, SoTien) VALUES (10, '2024-06-010', 110000);
INSERT INTO BangGia (MaBac, TenBac, MaGia, MoTa, MucDien, DonGia) VALUES ('B1', N'Bậc 1', 1, N'Mô tả 1', N'1-50kWh', 1600);
INSERT INTO BangGia (MaBac, TenBac, MaGia, MoTa, MucDien, DonGia) VALUES ('B2', N'Bậc 2', 2, N'Mô tả 2', N'51-100kWh', 1700);
INSERT INTO BangGia (MaBac, TenBac, MaGia, MoTa, MucDien, DonGia) VALUES ('B3', N'Bậc 3', 3, N'Mô tả 3', N'101-150kWh', 1800);
INSERT INTO BangGia (MaBac, TenBac, MaGia, MoTa, MucDien, DonGia) VALUES ('B4', N'Bậc 4', 4, N'Mô tả 4', N'151-200kWh', 1900);
INSERT INTO BangGia (MaBac, TenBac, MaGia, MoTa, MucDien, DonGia) VALUES ('B5', N'Bậc 5', 5, N'Mô tả 5', N'201-250kWh', 2000);
INSERT INTO BangGia (MaBac, TenBac, MaGia, MoTa, MucDien, DonGia) VALUES ('B6', N'Bậc 6', 6, N'Mô tả 6', N'251-300kWh', 2100);
INSERT INTO BangGia (MaBac, TenBac, MaGia, MoTa, MucDien, DonGia) VALUES ('B7', N'Bậc 7', 7, N'Mô tả 7', N'301-350kWh', 2200);
INSERT INTO BangGia (MaBac, TenBac, MaGia, MoTa, MucDien, DonGia) VALUES ('B8', N'Bậc 8', 8, N'Mô tả 8', N'351-400kWh', 2300);
INSERT INTO BangGia (MaBac, TenBac, MaGia, MoTa, MucDien, DonGia) VALUES ('B9', N'Bậc 9', 9, N'Mô tả 9', N'401-450kWh', 2400);
INSERT INTO BangGia (MaBac, TenBac, MaGia, MoTa, MucDien, DonGia) VALUES ('B10', N'Bậc 10', 10, N'Mô tả 10', N'451-500kWh', 2500);
INSERT INTO TramDien (MaTram, TenTram, ViTri, GhiChu) VALUES ('T1', N'Trạm 1', N'Vị trí 1', N'');
INSERT INTO TramDien (MaTram, TenTram, ViTri, GhiChu) VALUES ('T2', N'Trạm 2', N'Vị trí 2', N'');
INSERT INTO TramDien (MaTram, TenTram, ViTri, GhiChu) VALUES ('T3', N'Trạm 3', N'Vị trí 3', N'');
INSERT INTO TramDien (MaTram, TenTram, ViTri, GhiChu) VALUES ('T4', N'Trạm 4', N'Vị trí 4', N'');
INSERT INTO TramDien (MaTram, TenTram, ViTri, GhiChu) VALUES ('T5', N'Trạm 5', N'Vị trí 5', N'');
INSERT INTO TramDien (MaTram, TenTram, ViTri, GhiChu) VALUES ('T6', N'Trạm 6', N'Vị trí 6', N'');
INSERT INTO TramDien (MaTram, TenTram, ViTri, GhiChu) VALUES ('T7', N'Trạm 7', N'Vị trí 7', N'');
INSERT INTO TramDien (MaTram, TenTram, ViTri, GhiChu) VALUES ('T8', N'Trạm 8', N'Vị trí 8', N'');
INSERT INTO TramDien (MaTram, TenTram, ViTri, GhiChu) VALUES ('T9', N'Trạm 9', N'Vị trí 9', N'');
INSERT INTO TramDien (MaTram, TenTram, ViTri, GhiChu) VALUES ('T10', N'Trạm 10', N'Vị trí 10', N'');
INSERT INTO CongToDien (SoSerial, MaCongTo, KhachHangId, TrangThai) VALUES ('S100', 'CT1', 1, 1);
INSERT INTO CongToDien (SoSerial, MaCongTo, KhachHangId, TrangThai) VALUES ('S200', 'CT2', 2, 0);
INSERT INTO CongToDien (SoSerial, MaCongTo, KhachHangId, TrangThai) VALUES ('S300', 'CT3', 3, 1);
INSERT INTO CongToDien (SoSerial, MaCongTo, KhachHangId, TrangThai) VALUES ('S400', 'CT4', 4, 0);
INSERT INTO CongToDien (SoSerial, MaCongTo, KhachHangId, TrangThai) VALUES ('S500', 'CT5', 5, 1);
INSERT INTO CongToDien (SoSerial, MaCongTo, KhachHangId, TrangThai) VALUES ('S600', 'CT6', 6, 0);
INSERT INTO CongToDien (SoSerial, MaCongTo, KhachHangId, TrangThai) VALUES ('S700', 'CT7', 7, 1);
INSERT INTO CongToDien (SoSerial, MaCongTo, KhachHangId, TrangThai) VALUES ('S800', 'CT8', 8, 0);
INSERT INTO CongToDien (SoSerial, MaCongTo, KhachHangId, TrangThai) VALUES ('S900', 'CT9', 9, 1);
INSERT INTO CongToDien (SoSerial, MaCongTo, KhachHangId, TrangThai) VALUES ('S1000', 'CT10', 10, 0);
INSERT INTO ChiSoDien (CongToDienId, NgayGhi, ChiSoCu, ChiSoMoi, ThangNam) VALUES (1, '2024-06-01', 101, 121, '2024-06-01');
INSERT INTO ChiSoDien (CongToDienId, NgayGhi, ChiSoCu, ChiSoMoi, ThangNam) VALUES (2, '2024-06-02', 102, 122, '2024-06-01');
INSERT INTO ChiSoDien (CongToDienId, NgayGhi, ChiSoCu, ChiSoMoi, ThangNam) VALUES (3, '2024-06-03', 103, 123, '2024-06-01');
INSERT INTO ChiSoDien (CongToDienId, NgayGhi, ChiSoCu, ChiSoMoi, ThangNam) VALUES (4, '2024-06-04', 104, 124, '2024-06-01');
INSERT INTO ChiSoDien (CongToDienId, NgayGhi, ChiSoCu, ChiSoMoi, ThangNam) VALUES (5, '2024-06-05', 105, 125, '2024-06-01');
INSERT INTO ChiSoDien (CongToDienId, NgayGhi, ChiSoCu, ChiSoMoi, ThangNam) VALUES (6, '2024-06-06', 106, 126, '2024-06-01');
INSERT INTO ChiSoDien (CongToDienId, NgayGhi, ChiSoCu, ChiSoMoi, ThangNam) VALUES (7, '2024-06-07', 107, 127, '2024-06-01');
INSERT INTO ChiSoDien (CongToDienId, NgayGhi, ChiSoCu, ChiSoMoi, ThangNam) VALUES (8, '2024-06-08', 108, 128, '2024-06-01');
INSERT INTO ChiSoDien (CongToDienId, NgayGhi, ChiSoCu, ChiSoMoi, ThangNam) VALUES (9, '2024-06-09', 109, 129, '2024-06-01');
INSERT INTO ChiSoDien (CongToDienId, NgayGhi, ChiSoCu, ChiSoMoi, ThangNam) VALUES (10, '2024-06-010', 110, 130, '2024-06-01');

-- Thêm cột BangGiaId vào bảng CongToDien
ALTER TABLE CongToDien
ADD BangGiaId INT;

-- Tạo khóa ngoại từ CongToDien -> BangGia
ALTER TABLE CongToDien
ADD CONSTRAINT FK_CongToDien_BangGia
FOREIGN KEY (BangGiaId) REFERENCES BangGia(Id);

-- Gán dữ liệu mẫu cho 10 công tơ (Id từ 1 đến 10)
UPDATE CongToDien SET BangGiaId = 1 WHERE Id = 1;
UPDATE CongToDien SET BangGiaId = 2 WHERE Id = 2;
UPDATE CongToDien SET BangGiaId = 3 WHERE Id = 3;
UPDATE CongToDien SET BangGiaId = 4 WHERE Id = 4;
UPDATE CongToDien SET BangGiaId = 5 WHERE Id = 5;
UPDATE CongToDien SET BangGiaId = 6 WHERE Id = 6;
UPDATE CongToDien SET BangGiaId = 7 WHERE Id = 7;
UPDATE CongToDien SET BangGiaId = 8 WHERE Id = 8;
UPDATE CongToDien SET BangGiaId = 9 WHERE Id = 9;
UPDATE CongToDien SET BangGiaId = 10 WHERE Id = 10;