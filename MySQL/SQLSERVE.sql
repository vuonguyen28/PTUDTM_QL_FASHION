-- Tạo cơ sở dữ liệu QLSHOP
CREATE DATABASE QLSHOP;
GO

USE QLSHOP;
GO

-- Tạo bảng danhmuc
CREATE TABLE danhmuc (
    MaDanhMuc INT PRIMARY KEY IDENTITY(1,1),
    TenDanhMuc NVARCHAR(255) NOT NULL
);
GO

-- Tạo bảng kichthuoc
CREATE TABLE kichthuoc (
    MaKichThuoc INT PRIMARY KEY IDENTITY(1,1),
    TenKichThuoc NVARCHAR(20) NULL
);
GO

-- Tạo bảng mausac
CREATE TABLE mausac (
    MaMau INT PRIMARY KEY IDENTITY(1,1),
    TenMau NVARCHAR(20) NULL,
    HEXCODE CHAR(11) NOT NULL
);
GO

-- Tạo bảng sanpham
CREATE TABLE sanpham (
    MaSP INT PRIMARY KEY IDENTITY(1,1),
    TenSP NVARCHAR(255) NOT NULL,
    Gia FLOAT NOT NULL,
    PhanTramGiamGia FLOAT NULL,
    MoTa NVARCHAR(255) NOT NULL,
    MaDanhMuc INT NOT NULL,
    MaNhaCungCap INT NOT NULL,
    TrinhTrang NVARCHAR(40) NOT NULL,
    FOREIGN KEY (MaDanhMuc) REFERENCES danhmuc(MaDanhMuc)
);
GO

-- Tạo bảng chitietsanpham
CREATE TABLE chitietsanpham (
    MaChiTiet INT PRIMARY KEY IDENTITY(1,1),
    MaSP INT NULL,
    MaKichThuoc INT NULL,
    MaMau INT NULL,
    SoLuongTon INT NULL,
    FOREIGN KEY (MaSP) REFERENCES sanpham(MaSP),
    FOREIGN KEY (MaKichThuoc) REFERENCES kichthuoc(MaKichThuoc),
    FOREIGN KEY (MaMau) REFERENCES mausac(MaMau)
);
GO

-- Tạo bảng khachhang
CREATE TABLE khachhang (
    MaKH INT PRIMARY KEY IDENTITY(1,1),
    TenKH NVARCHAR(50) NULL,
    SoDienThoai NVARCHAR(15) NULL,
    Email NVARCHAR(100) NULL,
    DiaChi NVARCHAR(60) NULL,
    Password_hs5 NVARCHAR(100) NULL,
    GioiTinh NVARCHAR(5) NULL,
    TrangThai NVARCHAR(15) NULL,
    avatar NVARCHAR(100) NULL,
    Role NVARCHAR(15) NULL
);
GO

-- Tạo bảng donhang
CREATE TABLE donhang (
    MaDonHang INT PRIMARY KEY IDENTITY(1,1),
    MaKhachHang INT NULL,
    NgayDat DATETIME NULL,
    NgayDuKienGiaoHang DATE NULL,
    TongGia DECIMAL(10,0) NULL,
    TongTienSauKhiGiamGia FLOAT NULL,
    PhiVanChuyen FLOAT NULL,
    TrangThaiThanhToan NVARCHAR(50) NULL,
    HinhThucThanhToan NVARCHAR(70) NULL,
    TrangThaiDonHang NVARCHAR(40) NULL,
    DiaChiGiaoHang NVARCHAR(50) NULL,
    MaVoucher NVARCHAR(20) NULL,
    RecipientPhone NVARCHAR(13) NULL,
    FOREIGN KEY (MaKhachHang) REFERENCES khachhang(MaKH)
);
GO

-- Tạo bảng chitietdonhang
CREATE TABLE chitietdonhang (
    MaChiTiet INT PRIMARY KEY IDENTITY(1,1),
    MaDonHang INT NULL,
    MaChiTietSanPham INT NULL,
    SoLuong INT NULL,
    Gia FLOAT NULL,
    FOREIGN KEY (MaDonHang) REFERENCES donhang(MaDonHang),
    FOREIGN KEY (MaChiTietSanPham) REFERENCES chitietsanpham(MaChiTiet)
);
GO

-- Tạo bảng feedback
CREATE TABLE feedback (
    Mafeedback INT PRIMARY KEY IDENTITY(1,1),
    MaKH INT NULL,
    MaChiTietDH INT NULL,
    NoiDung NVARCHAR(MAX) NULL,
    ThoiGianfeedback DATETIME NULL,
    DanhGia FLOAT NULL,
    FOREIGN KEY (MaKH) REFERENCES khachhang(MaKH),
    FOREIGN KEY (MaChiTietDH) REFERENCES chitietdonhang(MaChiTiet)
);
GO

-- Tạo bảng giohang
CREATE TABLE giohang (
    MaGioHang INT PRIMARY KEY IDENTITY(1,1),
    MaKhachHang INT NULL,
    MaChiTietSanPham INT NULL,
    SoLuong INT NULL,
    FOREIGN KEY (MaKhachHang) REFERENCES khachhang(MaKH),
    FOREIGN KEY (MaChiTietSanPham) REFERENCES chitietsanpham(MaChiTiet)
);
GO

-- Tạo bảng hinhanh
CREATE TABLE hinhanh (
    MaHinhAnh INT PRIMARY KEY IDENTITY(1,1),
    MaSp INT NULL,
    Hinhanh NVARCHAR(200) NULL,
    FOREIGN KEY (MaSp) REFERENCES sanpham(MaSP)
);
GO

-- Tạo bảng voucher
CREATE TABLE voucher (
    MA_VOUCHER CHAR(20) PRIMARY KEY,
    Ten_VOUCHER CHAR(50) NULL,
    PhanTramGiam FLOAT NULL,
    DonToiThieu FLOAT NULL,
    GiamToiDa FLOAT NULL,
    SoLuongVOUCHER INT NULL,
    Ngaybatdau DATETIME NULL,
    Ngayketthuc DATETIME NULL
);
GO

-- Tạo bảng voucher_khachhang
CREATE TABLE voucher_khachhang (
    MaKH INT NOT NULL,
    MA_VOUCHER CHAR(20) NOT NULL,
    note NVARCHAR(15) NULL,
    PRIMARY KEY (MaKH, MA_VOUCHER),
    FOREIGN KEY (MaKH) REFERENCES khachhang(MaKH),
    FOREIGN KEY (MA_VOUCHER) REFERENCES voucher(MA_VOUCHER)
);
GO

-- Tạo trigger update_quantity_on_insert
CREATE TRIGGER update_quantity_on_insert
ON chitietdonhang
AFTER INSERT
AS
BEGIN
    DECLARE @product_quantity INT;
    DECLARE @product_id INT;

    -- Lấy thông tin từ bảng chitietdonhang
    SELECT @product_id = MaChiTietSanPham, @product_quantity = SoLuong 
    FROM inserted;

    -- Cập nhật số lượng tồn trong bảng ChiTietSanPham
    UPDATE chitietsanpham
    SET SoLuongTon = SoLuongTon - @product_quantity
    WHERE MaChiTiet = @product_id;
END;
GO

SET IDENTITY_INSERT danhmuc ON;
INSERT INTO  danhmuc  ( MaDanhMuc ,  TenDanhMuc ) VALUES
(4, 'POLO'),
(8, 'SWE'),
(9, 'Phụ kiện'),
(10, 'Quần'),
(11, 'Giày'),
(12, 'ÁO');
SET IDENTITY_INSERT danhmuc OFF;

SET IDENTITY_INSERT mausac ON;
INSERT INTO  mausac  ( MaMau ,  TenMau ,  HEXCODE ) VALUES
(3, 'Black', '#000000'),
(4, 'Blue', '#11008f'),
(5, 'Green', '#33ff66'),
(6, 'Pink', '#ff99cc'),
(7, 'Yellow', '#e7e00d'),
(8, 'Cream', '#f0efef');
SET IDENTITY_INSERT mausac OFF;


SET IDENTITY_INSERT kichthuoc ON;
INSERT INTO  kichthuoc  ( MaKichThuoc ,  TenKichThuoc ) VALUES
(3, 'S'),
(4, 'L'),
(5, 'M'),
(6, 'XXL'),
(7, 'XL'),
(8, 'over size'),
(545, 'DO NEKK');
SET IDENTITY_INSERT kichthuoc OFF;



SET IDENTITY_INSERT sanpham ON;
INSERT INTO  sanpham  ( MaSP ,  TenSP ,  Gia ,  PhanTramGiamGia ,  MoTa ,  MaDanhMuc ,  MaNhaCungCap ,  TrinhTrang ) VALUES
(424, 'STRAIGHT JEANS - RIPPED BLUE', 300000, 23, 'Chất liệu: Sử dụng vải cotton 100% cao cấp, đảm bảo sự thoải mái và thoáng mát cho người mặc.\r\nMàu sắc: Màu đen cổ điển, dễ dàng kết hợp với nhiều trang phục khác nhau và phù hợp trong nhiều dịp khác nhau.', 8, 2, 'conhang'),
(425, 'STRAIGHT JEANS - RIPPED BLUE', 290000, 23, 'Kiểu dáng: Thiết kế cổ tròn đơn giản nhưng lịch lãm, phù hợp cho cả nam và nữ. Form áo ôm vừa phải, tôn lên vóc dáng và mang lại sự tự tin cho người mặc.', 8, 2, 'conhang'),
(426, 'STRAIGHT JEANS - RIPPED BLUE', 290000, 23, 'Sản xuất: Sản phẩm được sản xuất với công nghệ tiên tiến và quy trình kiểm định chất lượng nghiêm ngặt, đảm bảo độ bền và độ mềm mại sau nhiều lần giặt.', 4, 1, 'conhang'),
(427, 'STRAIGHT JEANS', 290000, 23, 'Sản xuất: Sản phẩm được sản xuất với công nghệ tiên tiến và quy trình kiểm định chất lượng nghiêm ngặt, đảm bảo độ bền và độ mềm mại sau nhiều lần giặt.', 4, 1, 'conhang'),
(428, 'SWEVN TEE - BLACK', 290000, 23, 'Sản xuất: Sản phẩm được sản xuất với công nghệ tiên tiến và quy trình kiểm định chất lượng nghiêm ngặt, đảm bảo độ bền và độ mềm mại sau nhiều lần giặt.', 4, 1, 'conhang'),
(429, 'FLARED CARGO PANTS - BLACK', 290000, 23, 'Giá cả:\r\nGiá cả phải chăng và hợp lý, phản ánh chất lượng cao của sản phẩm.', 8, 1, 'conhang'),
(430, 'BAGGY JEANS - MOSS', 290000, 23, 'Áo thun màu đen \"Black Classic\" không chỉ là một món đồ thời trang cơ bản, mà còn là biểu tượng của phong cách và sự thanh lịch. Với chất liệu tốt và thiết kế đơn giản nhưng không kém phần tinh tế, sản phẩm này chắc chắn sẽ là sự lựa chọn lý tưởng', 4, 1, 'conhang'),
(625, 'SWEVN-TEE', 320000, 21, 'Kiểu dáng: Thiết kế cổ tròn đơn giản nhưng lịch lãm, phù hợp cho cả nam và nữ. Form áo ôm vừa phải, tôn lên vóc dáng và mang lại sự tự tin cho người mặc.', 8, 2, 'conhang'),
(626, 'WIND-TEE', 210000, 11, 'Áo thun màu đen \"Black Classic\" là một sản phẩm thời trang cơ bản nhưng không kém phần tinh tế và sang trọng. Với chất liệu vải cotton cao cấp, áo thun này mang lại cảm giác mềm mại và thoải mái cho người mặc trong mọi hoàn cảnh.', 8, 4, 'conhang'),
(627, 'BOLD TEE', 99000, 11, 'Chất liệu: Sử dụng vải cotton 100% cao cấp, đảm bảo sự thoải mái và thoáng mát cho người mặc.\r\nMàu sắc: Màu đen cổ điển, dễ dàng kết hợp với nhiều trang phục khác nhau và phù hợp trong nhiều dịp khác nhau.', 4, 4, 'conhang'),
(628, 'CHINO PANTS', 222000, 9, 'Giá cả phải chăng và hợp lý, phản ánh chất lượng cao của sản phẩm.Phù hợp cho mọi dịp: từ các buổi dạo phố hàng ngày cho đến các sự kiện thể thao, hội họp bạn bè, hay thậm chí là các buổi tiệc nhẹ.', 10, 1, 'conhang'),
(629, 'Áo babytee', 300000, 0, 'Phù hợp cho mọi dịp: từ các buổi dạo phố hàng ngày cho đến các sự kiện thể thao, hội họp bạn bè, hay thậm chí là các buổi tiệc nhẹ. Thích hợp cho mọi đối tượng: từ các bạn trẻ năng động cho đến những người lớn tuổi yêu thích sự đơn giản và lịch lãm.', 8, 2, 'conhang'),
(630, 'Nón xinh', 99000, 0, 'Màu sắc: Màu đen cổ điển, dễ dàng kết hợp với nhiều trang phục khác nhau và phù hợp trong nhiều dịp khác nhau.', 9, 2, 'conhang');
SET IDENTITY_INSERT sanpham OFF;

SET IDENTITY_INSERT hinhanh ON;
INSERT INTO  hinhanh  ( MaHinhAnh ,  MaSp ,  hinhanh ) VALUES
(346, 425, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717571936/Shop/fmlaewocqikgqj4mtwlq.jpg'),
(347, 425, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717571939/Shop/h2r6glcb0q4respxlvyf.jpg'),
(348, 425, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717571941/Shop/omaxlrgc45mgdduclepo.jpg'),
(349, 425, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717571943/Shop/iyqrllpwt1gt4amkjqhu.jpg'),
(350, 426, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717571967/Shop/ydgimkkewvb9gyq35ej8.jpg'),
(351, 426, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717571969/Shop/b0tii7qkyte6leialx8w.jpg'),
(352, 426, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717571972/Shop/vt9k7ckw7kwwxzfddouw.jpg'),
(353, 426, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717571974/Shop/gytdwodlegi4g8hjdpmn.jpg'),
(354, 427, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572007/Shop/lgdzh2wxxmmvlwgvc62z.jpg'),
(355, 427, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572009/Shop/ugfxqhscnvs0lnh22akz.jpg'),
(356, 427, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572011/Shop/cknuw3rel4kpmaft62za.jpg'),
(357, 427, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572014/Shop/mrsb5zbdibmzimq3zxn8.jpg'),
(358, 428, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572044/Shop/q1sxmtumzlmjikfjhmav.jpg'),
(359, 428, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572047/Shop/gwyhy9tpoiwb0con597n.jpg'),
(360, 428, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572050/Shop/ifzc5lmcgbt781qpmshd.jpg'),
(361, 428, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572055/Shop/k05qejacbh12tckwwht2.jpg'),
(362, 429, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572106/Shop/u7qglxdpgfxsiasm75nr.jpg'),
(363, 429, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572109/Shop/pzfmxigfpbjlyvwz5u63.jpg'),
(364, 429, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572112/Shop/innhwt4m4v2g7evrt6nb.jpg'),
(365, 429, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572116/Shop/zwop0l7xc95qr5ufpuab.jpg'),
(366, 430, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572184/Shop/j9mp8tpzohie4qifzzia.jpg'),
(367, 430, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572187/Shop/jeflov2ddoazhyjdo3pp.jpg'),
(368, 430, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572189/Shop/lhtmbrxuwqrz6wowsyug.jpg'),
(369, 430, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717572192/Shop/jff9fdzmak7uteu38gso.jpg'),
(374, 424, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717602255/Shop/j0weqtsebr1uyghzazpd.jpg'),
(378, 424, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717602361/Shop/iaz4nhnxgl1wy4uxb8mj.jpg'),
(379, 424, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717602365/Shop/q1xs5jau7igf3674x7i8.jpg'),
(380, 424, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717602367/Shop/ue3n13nnlezt3hq4j1b2.jpg'),
(381, 625, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606120/Shop/aoa50o81ie8zwkzmv7fz.jpg'),
(382, 625, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606122/Shop/pzqs6bs8fybovdhp6os0.jpg'),
(383, 625, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606124/Shop/nloiyln260bzbci7cz7o.jpg'),
(384, 625, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606127/Shop/njgw3vbipqaes1bhe32q.jpg'),
(385, 626, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606172/Shop/efqnamy33kygrrphm7nv.jpg'),
(386, 626, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606175/Shop/v7g4mnacnxb2yxaom3cl.jpg'),
(387, 626, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606177/Shop/qw9ornolqv2bneaw8dfq.jpg'),
(388, 626, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606179/Shop/r88dko2zzz4ol2pg7fy3.jpg'),
(389, 627, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606244/Shop/pb7m8zijmrqlkyd2dz1u.jpg'),
(390, 627, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606247/Shop/elrxatztxklmxi9qmxa8.jpg'),
(391, 627, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606249/Shop/yl2uplrvsydj4hdprnba.jpg'),
(392, 627, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606252/Shop/aipornqbxu1urt8xhtd2.jpg'),
(393, 628, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606333/Shop/uhsmmsniakgkb76y2h4c.jpg'),
(394, 628, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606336/Shop/jk9jb3zkfwsiblyqprbf.jpg'),
(395, 628, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606338/Shop/ztcouygmypxaft7dzzb3.jpg'),
(396, 628, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606340/Shop/urypwhbe23lhd3thvx2n.jpg'),
(397, 628, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606342/Shop/fzjzmmzzkxgzmfta155a.jpg'),
(398, 629, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606477/Shop/r8anjuutpntrn9xrp5hp.jpg'),
(399, 629, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606479/Shop/eeeepi0i3jxredjewfiv.jpg'),
(400, 629, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606481/Shop/j53dufwgfxn3i0hnxqys.jpg'),
(401, 629, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606484/Shop/ip7kk5tta4o5ni5sz9hw.jpg'),
(404, 630, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606600/Shop/yk1fqi59wbykq11esdfi.jpg'),
(405, 630, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606602/Shop/i1jdwx7yojbub1wxmh0e.jpg'),
(406, 630, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606648/Shop/uhpyeyogilokbncmh6ur.jpg'),
(407, 630, 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717606651/Shop/fkzp5k37vijikink16ia.jpg');
SET IDENTITY_INSERT hinhanh OFF;

SET IDENTITY_INSERT chitietsanpham ON;
INSERT INTO  chitietsanpham  ( MaChiTiet ,  MaSP ,  MaKichThuoc ,  MaMau ,  SoLuongTon ) VALUES
(18, 424, 3, 6, 9999999),
(19, 424, 3, 6, 9999999),
(22, 424, 3, 6, 1234),
(23, 424, 3, 6, 123),
(24, 424, 3, 6, 789),
(25, 425, 3, 3, 675),
(26, 425, 3, 5, 234),
(27, 425, 3, 4, 0),
(28, 425, 6, 3, 853),
(29, 425, 7, 6, 993),
(30, 430, 3, 3, 123),
(31, 430, 6, 4, 338),
(32, 429, 3, 3, 33),
(33, 426, 6, 6, 99),
(34, 426, 3, 3, 33),
(35, 427, 5, 4, 25),
(36, 427, 5, 5, 33),
(37, 428, 6, 5, 99),
(38, 428, 5, 6, 33),
(39, 429, 5, 6, 99),
(40, 429, 5, 4, 13),
(41, 430, 3, 7, 6767),
(42, 625, 3, 3, 25),
(43, 625, 3, 6, 33),
(44, 625, 3, 8, 99),
(45, 626, 5, 4, 25),
(46, 626, 3, 3, 33),
(47, 626, 7, 5, 99),
(48, 627, 4, 4, 25),
(49, 627, 3, 3, 33),
(50, 627, 3, 8, 25),
(51, 628, 3, 6, 25),
(52, 628, 3, 3, 33),
(53, 628, 3, 5, 99),
(54, 628, 5, 4, 25),
(55, 628, 3, 8, 25),
(56, 629, 3, 3, 25),
(57, 629, 8, 3, 25),
(58, 629, 6, 5, 99),
(59, 629, 3, 7, 99),
(60, 630, 3, 3, 25),
(61, 630, 3, 8, 99),
(62, 630, 3, 6, 33),
(68, 424, 3, 6, 54),
(77, 428, 5, 6, 33);
SET IDENTITY_INSERT chitietsanpham OFF;


SET IDENTITY_INSERT khachhang ON;
INSERT INTO  khachhang  ( MaKH ,  TenKH ,  SoDienThoai ,  Email ,  DiaChi ,  Password_hs5 ,  GioiTinh ,  TrangThai ,  avatar ,  Role ) VALUES
(34, 'Hà Thị Minh Thư', '0842723472', 'admin@gmail.com', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', '539852', 'Nam', '1', 'z4758245898769_69e06c17ad630289fb948cb920ac5c8a_1717086114.jpg', 'admin'),
(36, 'Nguyễn Văn Vương', '0337588301', 'Cr.havaka@gmail.com', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', '936620', 'Nam', '0', 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717593891/Avatar/yk9wovvcpbpurtgr8sa2.jpg', 'user'),
(58, 'Cr.havaka@gmail.com', '0337588301', 'Cr.havaka1@gmail.com', '240 nguyên đỗ cung', '1', 'Nam', '1', 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717593917/Avatar/y7guzxhcs2v87qrdnipm.jpg', 'user'),
(59, 'Cr.havaka@gmail.com', '0856346', 'Cr.havaka2@gmail.com', '44 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', '11', 'Nam', '1', 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717593856/Avatar/hhgvoem4va6zjeshvbms.jpg', 'user'),
(60, 'admin1@gmail.com', '0358622', 'admin1@gmail.com', '140 lê trọng tân', '1', 'Nam', '1', 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717593740/Avatar/e2augd7hdwuzadpuqwb8.jpg', 'user'),
(62, 'vun vun1', '1111111111111', 'Cr.havakavv@gmail.com', '180 Tan Ky Tan Quyvv', '1', 'Nam', '1', 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717593721/Avatar/sriwtzmuhskuqohk6ijn.jpg', 'user'),
(63, 'Xuân bính', '033582146', 'nguyenbinh17062003@gmail.com', '44 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', '210111', 'Nam', '1', 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717593657/Avatar/j5ajb8ke5mdlfqctfajf.jpg', 'user'),
(65, 'Vưn Vưn một hiyusf', '1111111111', 'vun@gmail.com', '140 Lê Trọng Tấn', '123', 'Nam', '0', 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717594828/Avatar/tweyxcokoeqgico9suyl.jpg', 'user'),
(78, NULL, NULL, 'hihi@gmail.com', NULL, NULL, NULL, '1', 'user.png', 'Walk In Cus'),
(79, 'Hà Thị Minh Thư', '0842723472', 'vun451@gmail.com', '44 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', '123', 'Nam', '1', 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717586667/Avatar/pyo3xtiskpn0blnmrkdk.jpg', 'user'),
(80, 'Hà Thị Minh Thư', '0842723472', 'vun451124@gmail.com', '44 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', '123', 'Nam', '1', 'https://res.cloudinary.com/dkcizqsb3/image/upload/v1717586710/Avatar/zyfj4mjkwxtauowkso9z.png', 'user'),
(81, 'demooooooooooooooo@gmail.com', '012345', 'demooooooooooooooo@gmail.com', 'demooooooooooooooo@gmail.com', '12345', NULL, '1', 'user.png', 'user'),
(82, 'demooooooooooooooo1@gmail.com', '012345', 'demooooooooooooooo1@gmail.com', 'demooooooooooooooo1@gmail.com', NULL, NULL, '1', 'user.png', 'Walk In Cus'),
(83, 'demooooooo1@gmail.com', '01234556789', 'defffffffffffffo1@gmail.com', 'demoooo', '1', NULL, '1', 'user.png', 'user');
SET IDENTITY_INSERT khachhang OFF;


INSERT INTO  voucher  ( MA_VOUCHER ,  Ten_VOUCHER ,  PhanTramGiam ,  DonToiThieu ,  GiamToiDa ,  SoLuongVOUCHER ,  Ngaybatdau ,  Ngayketthuc ) VALUES
('DEMO1', 'GIAM 22% cho đơn hàng', 55, 289765, 4423440, 98, '2024-06-03 20:38:00', '2024-06-30 20:38:00'),
('DEMOHHH', 'HHHHDEMOO', 36, 289765, 4423440, 12345, '2024-05-06 08:38:00', '2024-06-04 08:38:00'),
('HIHI', 'GIAM 34 % CHO HIHI', 34, 500000, 100000, 100, '2024-06-03 11:18:00', '2024-06-30 11:18:00'),
('SHOPVBT', 'GIAM 40 SHOP VBT', 30, 500000, 100000, 98, '2023-01-31 02:11:00', '2024-07-27 02:12:00'),
('VBT', 'GROUP_FASHION_VBT_70%', 70, 500000, 100000, 99, '2024-06-01 00:33:00', '2024-06-30 00:34:00'),
('VUNVUN1', 'DEMODOAN', 23, 289765, 4423440, 12344, '2024-06-01 01:55:00', '2024-06-29 01:55:00');

SET IDENTITY_INSERT donhang ON;
INSERT INTO  donhang  ( MaDonHang ,  MaKhachHang ,  NgayDat ,  NgayDuKienGiaoHang ,  TongGia ,  TongTienSauKhiGiamGia ,  PhiVanChuyen ,  TrangThaiThanhToan ,  HinhThucThanhToan ,  TrangThaiDonHang ,  DiaChiGiaoHang ,  MaVoucher ,  RecipientPhone ) VALUES
(191, 65, '2024-05-24 08:08:07', '2024-05-30', 46400, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'ĐÃ GIAO', '666 len trong tan', NULL, '0999999991'),
(192, 65, '2024-05-11 08:09:43', '2024-05-16', 643800, NULL, 30000, 'đã thanh toán', 'momo', 'ĐÃ NHẬN', '666 len trong tan', NULL, '0999999991'),
(193, 78, '2024-06-05 00:00:00', '2024-06-08', 1116500, 0, 30000, 'đã thanh toán', 'momo', 'ĐÃ HỦY', NULL, 'KhongApDung', NULL),
(194, 65, '2024-05-21 08:56:18', '2024-05-31', 223300, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'ĐÃ NHẬN', '180 Tan Ky Tan Quy', NULL, '0334011111'),
(195, 65, '2023-06-06 09:57:38', '2023-06-30', 223300, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'ĐANG GIAO', '180 Tan Ky Tan Quy', NULL, '0334011111'),
(196, 65, '2023-06-24 09:59:33', '2023-06-28', 223300, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '180 Tan Ky Tan Quyvv', NULL, '0334011111'),
(197, 65, '2024-06-01 16:20:07', '2024-06-03', 223300, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', 'FGHJKLKJHGF', NULL, '23456789'),
(198, 65, '2024-04-11 16:24:35', '2024-05-11', 162000, NULL, 30000, 'đã thanh toán', 'momo', 'Đã đặt hàng', 'FGHJKLKJHGF', NULL, '23456789'),
(199, 78, '2024-06-05 16:32:38', '2024-06-08', 223300, 0, 30000, '1', 'on_delivery', 'Đã đặt hàng', '888www', 'KhongApDung', '0987654321'),
(200, 36, '2024-06-05 18:08:08', '2024-06-08', 254500, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'ĐÃ NHẬN', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(201, 36, '2024-06-05 18:33:25', '2024-06-08', 231000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(202, 36, '2024-06-05 18:44:33', '2024-06-08', 1011000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(203, 36, '2024-06-05 18:50:28', '2024-06-08', 1356000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(204, 36, '2024-06-05 18:57:26', '2024-06-08', 987000, 1221990, 30000, 'đã thanh toán', 'momo', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', 'VUNVUN1', '0337588301'),
(205, 36, '2024-06-05 19:00:33', '2024-06-08', 114000, 762300, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '123409 le trong tan', 'DEMO1', '111111'),
(206, 62, '2024-06-05 19:09:01', '2024-06-08', 500022, 346500, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '180 Tan Ky Tan Quyvv', 'SHOPVBT', '1111111111111'),
(207, 62, '2024-06-05 19:15:11', '2024-06-08', 7914100, 19226100, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '180 Tan Ky Tan Quyvv', 'VBT', '1111111111111'),
(208, 62, '2024-06-05 19:18:48', '2024-06-08', 5135900, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'ĐÃ HỦY', '180 Tan Ky Tan Quyvv', NULL, '1111111111111'),
(209, 62, '2024-06-05 19:30:03', '2024-06-08', 669900, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'ĐÃ NHẬN', '140 Le trong tan', NULL, '0123456789'),
(210, 36, '2024-06-06 02:22:12', '2024-06-09', 693000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(211, 36, '2024-06-06 02:27:22', '2024-06-09', 231000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(212, 36, '2024-06-06 02:27:59', '2024-06-09', 462000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(213, 36, '2024-06-06 02:30:08', '2024-06-09', 1386000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(214, 36, '2024-06-06 02:33:03', '2024-06-09', 693000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(215, 36, '2024-06-06 02:36:57', '2024-06-09', 693000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(216, 36, '2024-06-06 02:39:44', '2024-06-09', 231000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(217, 36, '2024-06-06 02:41:14', '2024-06-09', 231000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(218, 36, '2024-06-06 02:47:23', '2024-06-09', 231000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(219, 36, '2024-06-06 02:56:21', '2024-06-09', 231000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(220, 36, '2024-06-06 03:04:09', '2024-06-09', 231000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(221, 36, '2024-06-06 03:07:20', '2024-06-09', 231000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(222, 36, '2024-06-06 03:15:26', '2024-06-09', 1386000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(223, 36, '2024-06-06 03:18:40', '2024-06-09', 231000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(224, 36, '2024-06-06 03:20:01', '2024-06-09', 231000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(225, 36, '2024-06-06 03:22:53', '2024-06-09', 231000, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(226, 36, '2024-06-06 03:31:58', '2024-06-09', 2071300, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(227, 36, '2024-06-06 03:34:06', '2024-06-09', 446600, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(228, 36, '2024-06-06 03:36:35', '2024-06-09', 1570800, NULL, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '29 Nguyễn Đỗ Cung, Tây Thạnh , Tân Phú', NULL, '0337588301'),
(229, 78, '2024-06-06 03:53:15', '2024-06-09', 1155000, 0, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', '28', 'KhongApDung', '0337588301'),
(230, 78, '2024-06-06 03:54:46', '2024-06-09', 1155000, 0, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', 'demooooooooooooooo@gmail.com', 'KhongApDung', '0337588301'),
(231, 81, '2024-06-06 03:57:35', '2024-06-09', 1339800, 0, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', 'demooooooooooooooo@gmail.com', 'KhongApDung', '012345'),
(232, 82, '2024-06-06 04:01:41', '2024-06-09', 231000, 0, 30000, 'chưa thanh toán', 'on_delivery', 'Đã đặt hàng', 'demooooooooooooooo1@gmail.com', 'KhongApDung', '012345'),
(233, 83, '2024-06-06 05:14:42', '2024-06-09', 1563100, 0, 30000, 'chưa thanh toán', 'on_delivery', 'ĐÃ NHẬN', 'demoooo', 'KhongApDung', '01234556789'),
(234, 83, '2024-06-06 05:20:15', '2024-06-09', 1617000, 485100, 30000, 'đã thanh toán', 'momo', 'Đã đặt hàng', 'demoooo', 'SHOPVBT', '01234556789');
SET IDENTITY_INSERT donhang OFF;


INSERT INTO  chitietdonhang  (   MaDonHang ,  MaChiTietSanPham ,  SoLuong ,  Gia ) VALUES
( 191, 23, 1, 223300),
( 192, 24, 14, 3126200),
( 193, 24, 5, 290000),
( 194, 24, 1, 223300),
( 195, 24, 1, 223300),
( 196, 24, 1, 223300),
( 197, 32, 1, 223300),
( 198, 19, 2, 462000),
( 199, 25, 1, 290000),
( 200, 18, 4, 924000),
( 200, 24, 5, 1155000),
( 200, 37, 3, 669900),
( 200, 42, 2, 505600),
( 201, 19, 1, 231000),
( 202, 18, 19, 4389000),
( 203, 18, 24, 5544000),
( 204, 18, 10, 2310000),
( 204, 23, 13, 3003000),
( 205, 18, 6, 1386000),
( 206, 24, 5, 1155000),
( 207, 28, 123, 27465900),
( 208, 28, 23, 5135900),
( 209, 41, 3, 669900),
( 210, 24, 2, 462000),
( 210, 18, 1, 231000),
( 211, 18, 1, 231000),
( 212, 24, 2, 462000),
( 213, 24, 6, 1386000),
( 214, 24, 3, 693000),
( 215, 19, 3, 693000),
( 216, 19, 1, 231000),
( 217, 24, 1, 231000),
( 218, 24, 1, 231000),
( 219, 18, 1, 231000),
( 220, 22, 1, 231000),
( 222, 24, 5, 1155000),
( 222, 22, 1, 231000),
( 223, 24, 1, 231000),
( 224, 24, 1, 231000),
( 225, 23, 1, 231000),
( 226, 23, 8, 1848000),
( 226, 29, 1, 223300),
( 227, 28, 1, 223300),
( 227, 25, 1, 223300),
( 228, 18, 1, 231000),
( 228, 29, 6, 1339800),
( 229, 24, 2, 300000),
( 229, 22, 3, 300000),
( 230, 23, 5, 300000),
( 231, 40, 6, 290000),
( 232, 24, 1, 300000),
( 233, 30, 7, 290000),
( 234, 24, 7, 1617000);
