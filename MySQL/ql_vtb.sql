-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th9 10, 2024 lúc 04:56 PM
-- Phiên bản máy phục vụ: 10.4.32-MariaDB
-- Phiên bản PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `ql_vtb`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `cache`
--

CREATE TABLE `cache` (
  `key` varchar(255) NOT NULL,
  `value` mediumtext NOT NULL,
  `expiration` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `cache_locks`
--

CREATE TABLE `cache_locks` (
  `key` varchar(255) NOT NULL,
  `owner` varchar(255) NOT NULL,
  `expiration` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chitietdonhang`
--

CREATE TABLE `chitietdonhang` (
  `MaChiTiet` int(11) NOT NULL,
  `MaDonHang` int(11) DEFAULT NULL,
  `MaChiTietSanPham` int(11) DEFAULT NULL,
  `SoLuong` int(11) DEFAULT NULL,
  `Gia` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `chitietdonhang`
--

INSERT INTO `chitietdonhang` (`MaChiTiet`, `MaDonHang`, `MaChiTietSanPham`, `SoLuong`, `Gia`) VALUES
(151, 191, 18, 7, 1563100),
(152, 191, 23, 1, 223300),
(153, 192, 24, 14, 3126200),
(154, 193, 24, 5, 290000),
(155, 194, 24, 1, 223300),
(156, 195, 24, 1, 223300),
(157, 196, 24, 1, 223300),
(158, 197, 32, 1, 223300),
(159, 198, 19, 2, 462000),
(160, 199, 25, 1, 290000),
(161, 200, 18, 4, 924000),
(162, 200, 24, 5, 1155000),
(163, 200, 37, 3, 669900),
(164, 200, 42, 2, 505600),
(165, 201, 19, 1, 231000),
(166, 202, 18, 19, 4389000),
(167, 203, 18, 24, 5544000),
(168, 204, 18, 10, 2310000),
(169, 204, 23, 13, 3003000),
(170, 205, 18, 6, 1386000),
(171, 206, 24, 5, 1155000),
(172, 207, 28, 123, 27465900),
(173, 208, 28, 23, 5135900),
(174, 209, 41, 3, 669900),
(175, 210, 24, 2, 462000),
(176, 210, 18, 1, 231000),
(177, 211, 18, 1, 231000),
(178, 212, 24, 2, 462000),
(179, 213, 24, 6, 1386000),
(180, 214, 24, 3, 693000),
(181, 215, 19, 3, 693000),
(182, 216, 19, 1, 231000),
(183, 217, 24, 1, 231000),
(184, 218, 24, 1, 231000),
(185, 219, 18, 1, 231000),
(186, 220, 22, 1, 231000),
(187, 222, 24, 5, 1155000),
(188, 222, 22, 1, 231000),
(189, 223, 24, 1, 231000),
(190, 224, 24, 1, 231000),
(191, 225, 23, 1, 231000),
(192, 226, 23, 8, 1848000),
(193, 226, 29, 1, 223300),
(194, 227, 28, 1, 223300),
(195, 227, 25, 1, 223300),
(196, 228, 18, 1, 231000),
(197, 228, 29, 6, 1339800),
(198, 229, 24, 2, 300000),
(199, 229, 22, 3, 300000),
(200, 230, 23, 5, 300000),
(201, 231, 40, 6, 290000),
(202, 232, 24, 1, 300000),
(203, 233, 30, 7, 290000),
(204, 234, 24, 7, 1617000);

--
-- Bẫy `chitietdonhang`
--
DELIMITER $$
CREATE TRIGGER `update_quantity_on_insert` AFTER INSERT ON `chitietdonhang` FOR EACH ROW BEGIN
    DECLARE product_quantity INT;
    DECLARE product_id INT;
    
    -- Get the product details ID and quantity from the inserted order detail
    SELECT MaChiTietSanPham, SoLuong INTO product_id, product_quantity
    FROM chitietdonhang
    WHERE MaChiTiet = NEW.MaChiTiet;

    -- Update the quantity on hand in the product details table
    UPDATE ChiTietSanPham
    SET SoLuongTon = SoLuongTon - product_quantity
    WHERE MaChiTiet = product_id;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chitietsanpham`
--

CREATE TABLE `chitietsanpham` (
  `MaChiTiet` int(11) NOT NULL,
  `MaSP` int(11) DEFAULT NULL,
  `MaKichThuoc` int(11) DEFAULT NULL,
  `MaMau` int(11) DEFAULT NULL,
  `SoLuongTon` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `chitietsanpham`
--

INSERT INTO `chitietsanpham` (`MaChiTiet`, `MaSP`, `MaKichThuoc`, `MaMau`, `SoLuongTon`) VALUES
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

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `danhmuc`
--

CREATE TABLE `danhmuc` (
  `MaDanhMuc` int(11) NOT NULL,
  `TenDanhMuc` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `danhmuc`
--

INSERT INTO `danhmuc` (`MaDanhMuc`, `TenDanhMuc`) VALUES
(4, 'POLO'),
(8, 'SWE'),
(9, 'Phụ kiện'),
(10, 'Quần'),
(11, 'Giày'),
(12, 'ÁO');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `donhang`
--

CREATE TABLE `donhang` (
  `MaDonHang` int(11) NOT NULL,
  `MaKhachHang` int(11) DEFAULT NULL,
  `NgayDat` datetime DEFAULT NULL,
  `NgayDuKienGiaoHang` date DEFAULT NULL,
  `TongGia` decimal(10,0) DEFAULT NULL,
  `TongTienSauKhiGiamGia` float DEFAULT NULL,
  `PhiVanChuyen` float DEFAULT NULL,
  `TrangThaiThanhToan` varchar(50) DEFAULT NULL,
  `HinhThucThanhToan` varchar(70) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `TrangThaiDonHang` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `DiaChiGiaoHang` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `MaVoucher` char(20) DEFAULT NULL,
  `RecipientPhone` varchar(13) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `donhang`
--

INSERT INTO `donhang` (`MaDonHang`, `MaKhachHang`, `NgayDat`, `NgayDuKienGiaoHang`, `TongGia`, `TongTienSauKhiGiamGia`, `PhiVanChuyen`, `TrangThaiThanhToan`, `HinhThucThanhToan`, `TrangThaiDonHang`, `DiaChiGiaoHang`, `MaVoucher`, `RecipientPhone`) VALUES
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

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `failed_jobs`
--

CREATE TABLE `failed_jobs` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `uuid` varchar(255) NOT NULL,
  `connection` text NOT NULL,
  `queue` text NOT NULL,
  `payload` longtext NOT NULL,
  `exception` longtext NOT NULL,
  `failed_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `feedback`
--

CREATE TABLE `feedback` (
  `Mafeedback` int(11) NOT NULL,
  `MaKH` int(11) DEFAULT NULL,
  `MaChiTietDH` int(11) DEFAULT NULL,
  `NoiDung` text DEFAULT NULL,
  `ThoiGianfeedback` datetime DEFAULT NULL,
  `DanhGia` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `feedback`
--

INSERT INTO `feedback` (`Mafeedback`, `MaKH`, `MaChiTietDH`, `NoiDung`, `ThoiGianfeedback`, `DanhGia`) VALUES
(13, 65, 153, 'hihihihi', '2005-06-24 13:58:41', 5),
(14, 36, 161, '4', '2005-06-24 18:31:45', 4),
(15, 36, 161, '3', '2005-06-24 18:31:57', 3),
(16, 36, 161, '2', '2005-06-24 18:32:07', 2),
(17, 62, 174, '3', '2005-06-24 19:32:55', 3),
(18, 83, 203, 'sản phẩm đẹp đóng gói chất lượng . đánh giá 4saodstgsdyhseysrysxeyhhhhhhhhhhhhhhhh', '2006-06-24 05:23:54', 5);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `giohang`
--

CREATE TABLE `giohang` (
  `MaGioHang` int(11) NOT NULL,
  `MaKhachHang` int(11) DEFAULT NULL,
  `MaChiTietSanPham` int(11) DEFAULT NULL,
  `SoLuong` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `hinhanh`
--

CREATE TABLE `hinhanh` (
  `MaHinhAnh` int(11) NOT NULL,
  `MaSp` int(11) DEFAULT NULL,
  `hinhanh` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `hinhanh`
--

INSERT INTO `hinhanh` (`MaHinhAnh`, `MaSp`, `hinhanh`) VALUES
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

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `jobs`
--

CREATE TABLE `jobs` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `queue` varchar(255) NOT NULL,
  `payload` longtext NOT NULL,
  `attempts` tinyint(3) UNSIGNED NOT NULL,
  `reserved_at` int(10) UNSIGNED DEFAULT NULL,
  `available_at` int(10) UNSIGNED NOT NULL,
  `created_at` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `job_batches`
--

CREATE TABLE `job_batches` (
  `id` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `total_jobs` int(11) NOT NULL,
  `pending_jobs` int(11) NOT NULL,
  `failed_jobs` int(11) NOT NULL,
  `failed_job_ids` longtext NOT NULL,
  `options` mediumtext DEFAULT NULL,
  `cancelled_at` int(11) DEFAULT NULL,
  `created_at` int(11) NOT NULL,
  `finished_at` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `khachhang`
--

CREATE TABLE `khachhang` (
  `MaKH` int(11) NOT NULL,
  `TenKH` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `SoDienThoai` varchar(15) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `DiaChi` varchar(60) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `Password_hs5` varchar(100) DEFAULT NULL,
  `GioiTinh` varchar(5) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `TrangThai` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `avatar` char(100) DEFAULT NULL,
  `Role` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `khachhang`
--

INSERT INTO `khachhang` (`MaKH`, `TenKH`, `SoDienThoai`, `Email`, `DiaChi`, `Password_hs5`, `GioiTinh`, `TrangThai`, `avatar`, `Role`) VALUES
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

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `kichthuoc`
--

CREATE TABLE `kichthuoc` (
  `MaKichThuoc` int(11) NOT NULL,
  `TenKichThuoc` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `kichthuoc`
--

INSERT INTO `kichthuoc` (`MaKichThuoc`, `TenKichThuoc`) VALUES
(3, 'S'),
(4, 'L'),
(5, 'M'),
(6, 'XXL'),
(7, 'XL'),
(8, 'over size'),
(545, 'DO NEKK');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `mausac`
--

CREATE TABLE `mausac` (
  `MaMau` int(11) NOT NULL,
  `TenMau` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `HEXCODE` char(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `mausac`
--

INSERT INTO `mausac` (`MaMau`, `TenMau`, `HEXCODE`) VALUES
(3, 'Black', '#000000'),
(4, 'Blue', '#11008f'),
(5, 'Green', '#33ff66'),
(6, 'Pink', '#ff99cc'),
(7, 'Yellow', '#e7e00d'),
(8, 'Cream', '#f0efef');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `migrations`
--

CREATE TABLE `migrations` (
  `id` int(10) UNSIGNED NOT NULL,
  `migration` varchar(255) NOT NULL,
  `batch` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `migrations`
--

INSERT INTO `migrations` (`id`, `migration`, `batch`) VALUES
(1, '0001_01_01_000000_create_users_table', 1),
(2, '0001_01_01_000001_create_cache_table', 1),
(3, '0001_01_01_000002_create_jobs_table', 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `nhacungcap`
--

CREATE TABLE `nhacungcap` (
  `MaNhaCungCap` int(11) NOT NULL,
  `TenNhaCungCap` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `DiaChi` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `SoDienThoai` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `nhacungcap`
--

INSERT INTO `nhacungcap` (`MaNhaCungCap`, `TenNhaCungCap`, `DiaChi`, `SoDienThoai`) VALUES
(1, 'Forever 2111', '140  lê trọng tấn', '0337588310'),
(2, 'H&M', '180 Tan Ky Tan Quy', '0337588301'),
(4, 'Ananas', '170 Hoang Hoa Tham', '0337588310');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `password_reset_tokens`
--

CREATE TABLE `password_reset_tokens` (
  `email` varchar(255) NOT NULL,
  `token` varchar(255) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sanpham`
--

CREATE TABLE `sanpham` (
  `MaSP` int(11) NOT NULL,
  `TenSP` varchar(255) NOT NULL,
  `Gia` double NOT NULL,
  `PhanTramGiamGia` double DEFAULT NULL,
  `MoTa` varchar(255) NOT NULL,
  `MaDanhMuc` int(11) NOT NULL,
  `MaNhaCungCap` int(11) NOT NULL,
  `TrinhTrang` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `sanpham`
--

INSERT INTO `sanpham` (`MaSP`, `TenSP`, `Gia`, `PhanTramGiamGia`, `MoTa`, `MaDanhMuc`, `MaNhaCungCap`, `TrinhTrang`) VALUES
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

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sessions`
--

CREATE TABLE `sessions` (
  `id` varchar(255) NOT NULL,
  `user_id` bigint(20) UNSIGNED DEFAULT NULL,
  `ip_address` varchar(45) DEFAULT NULL,
  `user_agent` text DEFAULT NULL,
  `payload` longtext NOT NULL,
  `last_activity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `sessions`
--

INSERT INTO `sessions` (`id`, `user_id`, `ip_address`, `user_agent`, `payload`, `last_activity`) VALUES
('hmt5tM6ZLcVCs9fHZbu9kHTSosgmSMZYoXRJdRsq', NULL, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/128.0.0.0 Safari/537.36 Edg/128.0.0.0', 'YTozOntzOjY6Il90b2tlbiI7czo0MDoiNklrOWxjRk9wM3RTOGw4U0pKTkFHdG9Jb3VmSTlHdjFZRWFlUXcyUyI7czo5OiJfcHJldmlvdXMiO2E6MTp7czozOiJ1cmwiO3M6Mjc6Imh0dHA6Ly8xMjcuMC4wLjE6ODAwMC9hZG1pbiI7fXM6NjoiX2ZsYXNoIjthOjI6e3M6Mzoib2xkIjthOjA6e31zOjM6Im5ldyI7YTowOnt9fX0=', 1724779082),
('XyhEdM9FG6e5qYeNclxdmXbjMzdCdeCqrSYzTdki', NULL, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/128.0.0.0 Safari/537.36 Edg/128.0.0.0', 'YToxMDp7czo2OiJfdG9rZW4iO3M6NDA6Imt2VVAxYUFIVFNXbllkenFjM0szVWF4MWIxdDVEVm5CRGxWQW9PRDIiO3M6OToiX3ByZXZpb3VzIjthOjE6e3M6MzoidXJsIjtzOjI3OiJodHRwOi8vMTI3LjAuMC4xOjgwMDAvYWRtaW4iO31zOjY6Il9mbGFzaCI7YToyOntzOjM6Im9sZCI7YTowOnt9czozOiJuZXciO2E6MDp7fX1zOjQ6ImNhcnQiO2E6MTp7aTowO2E6ODp7czo0OiJNYVNQIjtzOjM6IjQyNCI7czo1OiJUZW5TUCI7czoyODoiU1RSQUlHSFQgSkVBTlMgLSBSSVBQRUQgQkxVRSI7czo1OiJJbWFnZSI7czo5MToiaHR0cHM6Ly9yZXMuY2xvdWRpbmFyeS5jb20vZGtjaXpxc2IzL2ltYWdlL3VwbG9hZC92MTcxNzYwMjI1NS9TaG9wL2owd2VxdHNlYnIxdXlnaHphenBkLmpwZyI7czoxMToiTWFLaWNoVGh1b2MiO3M6MToiUyI7czo1OiJNYU1hdSI7czo3OiIjMTEwMDhmIjtzOjc6IlNvTHVvbmciO3M6MToiMSI7czozOiJHaWEiO3M6NjoiMzAwMDAwIjtzOjc6IkdpYVNhbGUiO3M6NjoiMjMxMDAwIjt9fXM6MjM6IkxvZ2dlZEFkZHJlc3NfV2Fsa0luQ3VzIjtzOjI6IjI4IjtzOjIxOiJMb2dnZWRQaG9uZV9XYWxrSW5DdXMiO3M6MTA6IjAzMzc1ODgzMDEiO3M6MjA6IkxvZ2dlZE5hbWVfV2Fsa0luQ3VzIjtzOjIxOiJOZ3V54buFbiBWxINuIFbGsMahbmciO3M6MjE6IkxvZ2dlZEVtYWlsX1dhbGtJbkN1cyI7czoyMToiY3IuaGF2YWthc0BnbWFpbC5jb21hIjtzOjE1OiJwcmljcl90b3RhbF9jdXMiO2Q6MjMxMDAwO3M6MTE6IlByb2R1Y3ROYW1lIjtzOjM6IlNXRSI7fQ==', 1724609877);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `users`
--

CREATE TABLE `users` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `name` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `email_verified_at` timestamp NULL DEFAULT NULL,
  `password` varchar(255) NOT NULL,
  `remember_token` varchar(100) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `voucher`
--

CREATE TABLE `voucher` (
  `MA_VOUCHER` char(20) NOT NULL,
  `Ten_VOUCHER` char(50) DEFAULT NULL,
  `PhanTramGiam` float DEFAULT NULL,
  `DonToiThieu` float DEFAULT NULL,
  `GiamToiDa` float DEFAULT NULL,
  `SoLuongVOUCHER` int(11) DEFAULT NULL,
  `Ngaybatdau` datetime DEFAULT NULL,
  `Ngayketthuc` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `voucher`
--

INSERT INTO `voucher` (`MA_VOUCHER`, `Ten_VOUCHER`, `PhanTramGiam`, `DonToiThieu`, `GiamToiDa`, `SoLuongVOUCHER`, `Ngaybatdau`, `Ngayketthuc`) VALUES
('DEMO1', 'GIAM 22% cho đơn hàng', 55, 289765, 4423440, 98, '2024-06-03 20:38:00', '2024-06-30 20:38:00'),
('DEMOHHH', 'HHHHDEMOO', 36, 289765, 4423440, 12345, '2024-05-06 08:38:00', '2024-06-04 08:38:00'),
('HIHI', 'GIAM 34 % CHO HIHI', 34, 500000, 100000, 100, '2024-06-03 11:18:00', '2024-06-30 11:18:00'),
('SHOPVBT', 'GIAM 40 SHOP VBT', 30, 500000, 100000, 98, '2023-01-31 02:11:00', '2024-07-27 02:12:00'),
('VBT', 'GROUP_FASHION_VBT_70%', 70, 500000, 100000, 99, '2024-06-01 00:33:00', '2024-06-30 00:34:00'),
('VUNVUN1', 'DEMODOAN', 23, 289765, 4423440, 12344, '2024-06-01 01:55:00', '2024-06-29 01:55:00');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `voucher_khachhang`
--

CREATE TABLE `voucher_khachhang` (
  `MaKH` int(11) NOT NULL,
  `MA_VOUCHER` char(20) NOT NULL,
  `note` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `voucher_khachhang`
--

INSERT INTO `voucher_khachhang` (`MaKH`, `MA_VOUCHER`, `note`) VALUES
(36, 'DEMO1', 'done'),
(36, 'HIHI', 'done'),
(36, 'SHOPVBT', 'done'),
(36, 'VBT', 'done'),
(36, 'VUNVUN1', 'done'),
(58, 'SHOPVBT', 'chưa áp dụng'),
(58, 'VBT', 'chưa áp dụng'),
(62, 'DEMO1', 'chưa áp dụng'),
(62, 'SHOPVBT', 'done'),
(62, 'VBT', 'done'),
(62, 'VUNVUN1', 'chưa áp dụng'),
(65, 'DEMO1', 'done'),
(65, 'HIHI', 'done'),
(65, 'SHOPVBT', 'done'),
(65, 'VBT', 'done'),
(83, 'DEMOHHH', 'chưa áp dụng'),
(83, 'SHOPVBT', 'done'),
(83, 'VUNVUN1', 'chưa áp dụng');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `cache`
--
ALTER TABLE `cache`
  ADD PRIMARY KEY (`key`);

--
-- Chỉ mục cho bảng `cache_locks`
--
ALTER TABLE `cache_locks`
  ADD PRIMARY KEY (`key`);

--
-- Chỉ mục cho bảng `chitietdonhang`
--
ALTER TABLE `chitietdonhang`
  ADD PRIMARY KEY (`MaChiTiet`),
  ADD KEY `FK_ChiTietDonHang_DonHang` (`MaDonHang`),
  ADD KEY `FK_ChiTietDonHang_ChiTietSanPham` (`MaChiTietSanPham`);

--
-- Chỉ mục cho bảng `chitietsanpham`
--
ALTER TABLE `chitietsanpham`
  ADD PRIMARY KEY (`MaChiTiet`),
  ADD KEY `FK_ChiTietSanPham_SanPham` (`MaSP`),
  ADD KEY `FK_ChiTietSanPham_KichThuoc` (`MaKichThuoc`),
  ADD KEY `FK_ChiTietSanPham_MauSac` (`MaMau`);

--
-- Chỉ mục cho bảng `danhmuc`
--
ALTER TABLE `danhmuc`
  ADD PRIMARY KEY (`MaDanhMuc`);

--
-- Chỉ mục cho bảng `donhang`
--
ALTER TABLE `donhang`
  ADD PRIMARY KEY (`MaDonHang`),
  ADD KEY `FK_DonHang_KhachHang` (`MaKhachHang`);

--
-- Chỉ mục cho bảng `failed_jobs`
--
ALTER TABLE `failed_jobs`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `failed_jobs_uuid_unique` (`uuid`);

--
-- Chỉ mục cho bảng `feedback`
--
ALTER TABLE `feedback`
  ADD PRIMARY KEY (`Mafeedback`),
  ADD KEY `FK_FeedBack_ChiTietDonHang` (`MaChiTietDH`),
  ADD KEY `FK_FeedBack_KhachHang` (`MaKH`);

--
-- Chỉ mục cho bảng `giohang`
--
ALTER TABLE `giohang`
  ADD PRIMARY KEY (`MaGioHang`),
  ADD KEY `FK_GioHang_KhachHang` (`MaKhachHang`),
  ADD KEY `FK_GioHang_ChiTietSanPham` (`MaChiTietSanPham`);

--
-- Chỉ mục cho bảng `hinhanh`
--
ALTER TABLE `hinhanh`
  ADD PRIMARY KEY (`MaHinhAnh`),
  ADD KEY `FK_HinhAnh_SanPham` (`MaSp`);

--
-- Chỉ mục cho bảng `jobs`
--
ALTER TABLE `jobs`
  ADD PRIMARY KEY (`id`),
  ADD KEY `jobs_queue_index` (`queue`);

--
-- Chỉ mục cho bảng `job_batches`
--
ALTER TABLE `job_batches`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `khachhang`
--
ALTER TABLE `khachhang`
  ADD PRIMARY KEY (`MaKH`);

--
-- Chỉ mục cho bảng `kichthuoc`
--
ALTER TABLE `kichthuoc`
  ADD PRIMARY KEY (`MaKichThuoc`);

--
-- Chỉ mục cho bảng `mausac`
--
ALTER TABLE `mausac`
  ADD PRIMARY KEY (`MaMau`);

--
-- Chỉ mục cho bảng `migrations`
--
ALTER TABLE `migrations`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `nhacungcap`
--
ALTER TABLE `nhacungcap`
  ADD PRIMARY KEY (`MaNhaCungCap`);

--
-- Chỉ mục cho bảng `password_reset_tokens`
--
ALTER TABLE `password_reset_tokens`
  ADD PRIMARY KEY (`email`);

--
-- Chỉ mục cho bảng `sanpham`
--
ALTER TABLE `sanpham`
  ADD PRIMARY KEY (`MaSP`),
  ADD KEY `MaDanhMuc` (`MaDanhMuc`),
  ADD KEY `MaNhaCungCap` (`MaNhaCungCap`);

--
-- Chỉ mục cho bảng `sessions`
--
ALTER TABLE `sessions`
  ADD PRIMARY KEY (`id`),
  ADD KEY `sessions_user_id_index` (`user_id`),
  ADD KEY `sessions_last_activity_index` (`last_activity`);

--
-- Chỉ mục cho bảng `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `users_email_unique` (`email`);

--
-- Chỉ mục cho bảng `voucher`
--
ALTER TABLE `voucher`
  ADD PRIMARY KEY (`MA_VOUCHER`);

--
-- Chỉ mục cho bảng `voucher_khachhang`
--
ALTER TABLE `voucher_khachhang`
  ADD PRIMARY KEY (`MaKH`,`MA_VOUCHER`),
  ADD KEY `FK_VOUCHER_KHACHHANG_VOUCHER` (`MA_VOUCHER`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `chitietdonhang`
--
ALTER TABLE `chitietdonhang`
  MODIFY `MaChiTiet` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=205;

--
-- AUTO_INCREMENT cho bảng `chitietsanpham`
--
ALTER TABLE `chitietsanpham`
  MODIFY `MaChiTiet` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=81;

--
-- AUTO_INCREMENT cho bảng `danhmuc`
--
ALTER TABLE `danhmuc`
  MODIFY `MaDanhMuc` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT cho bảng `donhang`
--
ALTER TABLE `donhang`
  MODIFY `MaDonHang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=235;

--
-- AUTO_INCREMENT cho bảng `failed_jobs`
--
ALTER TABLE `failed_jobs`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `feedback`
--
ALTER TABLE `feedback`
  MODIFY `Mafeedback` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT cho bảng `giohang`
--
ALTER TABLE `giohang`
  MODIFY `MaGioHang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=157;

--
-- AUTO_INCREMENT cho bảng `hinhanh`
--
ALTER TABLE `hinhanh`
  MODIFY `MaHinhAnh` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=426;

--
-- AUTO_INCREMENT cho bảng `jobs`
--
ALTER TABLE `jobs`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `khachhang`
--
ALTER TABLE `khachhang`
  MODIFY `MaKH` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=84;

--
-- AUTO_INCREMENT cho bảng `kichthuoc`
--
ALTER TABLE `kichthuoc`
  MODIFY `MaKichThuoc` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=546;

--
-- AUTO_INCREMENT cho bảng `mausac`
--
ALTER TABLE `mausac`
  MODIFY `MaMau` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `nhacungcap`
--
ALTER TABLE `nhacungcap`
  MODIFY `MaNhaCungCap` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT cho bảng `sanpham`
--
ALTER TABLE `sanpham`
  MODIFY `MaSP` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=631;

--
-- AUTO_INCREMENT cho bảng `users`
--
ALTER TABLE `users`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `chitietdonhang`
--
ALTER TABLE `chitietdonhang`
  ADD CONSTRAINT `FK_ChiTietDonHang_ChiTietSanPham` FOREIGN KEY (`MaChiTietSanPham`) REFERENCES `chitietsanpham` (`MaChiTiet`),
  ADD CONSTRAINT `FK_ChiTietDonHang_DonHang` FOREIGN KEY (`MaDonHang`) REFERENCES `donhang` (`MaDonHang`);

--
-- Các ràng buộc cho bảng `chitietsanpham`
--
ALTER TABLE `chitietsanpham`
  ADD CONSTRAINT `FK_ChiTietSanPham_KichThuoc` FOREIGN KEY (`MaKichThuoc`) REFERENCES `kichthuoc` (`MaKichThuoc`),
  ADD CONSTRAINT `FK_ChiTietSanPham_MauSac` FOREIGN KEY (`MaMau`) REFERENCES `mausac` (`MaMau`),
  ADD CONSTRAINT `FK_ChiTietSanPham_SanPham` FOREIGN KEY (`MaSP`) REFERENCES `sanpham` (`MaSP`);

--
-- Các ràng buộc cho bảng `donhang`
--
ALTER TABLE `donhang`
  ADD CONSTRAINT `FK_DonHang_KhachHang` FOREIGN KEY (`MaKhachHang`) REFERENCES `khachhang` (`MaKH`);

--
-- Các ràng buộc cho bảng `feedback`
--
ALTER TABLE `feedback`
  ADD CONSTRAINT `FK_FeedBack_ChiTietDonHang` FOREIGN KEY (`MaChiTietDH`) REFERENCES `chitietdonhang` (`MaChiTiet`),
  ADD CONSTRAINT `FK_FeedBack_KhachHang` FOREIGN KEY (`MaKH`) REFERENCES `khachhang` (`MaKH`);

--
-- Các ràng buộc cho bảng `giohang`
--
ALTER TABLE `giohang`
  ADD CONSTRAINT `FK_GioHang_ChiTietSanPham` FOREIGN KEY (`MaChiTietSanPham`) REFERENCES `chitietsanpham` (`MaChiTiet`),
  ADD CONSTRAINT `FK_GioHang_KhachHang` FOREIGN KEY (`MaKhachHang`) REFERENCES `khachhang` (`MaKH`);

--
-- Các ràng buộc cho bảng `hinhanh`
--
ALTER TABLE `hinhanh`
  ADD CONSTRAINT `FK_HinhAnh_SanPham` FOREIGN KEY (`MaSp`) REFERENCES `sanpham` (`MaSP`);

--
-- Các ràng buộc cho bảng `sanpham`
--
ALTER TABLE `sanpham`
  ADD CONSTRAINT `sanpham_ibfk_1` FOREIGN KEY (`MaDanhMuc`) REFERENCES `danhmuc` (`MaDanhMuc`),
  ADD CONSTRAINT `sanpham_ibfk_2` FOREIGN KEY (`MaNhaCungCap`) REFERENCES `nhacungcap` (`MaNhaCungCap`);

--
-- Các ràng buộc cho bảng `voucher_khachhang`
--
ALTER TABLE `voucher_khachhang`
  ADD CONSTRAINT `FK_VOUCHER_KHACHHANG_KHACHHANG` FOREIGN KEY (`MaKH`) REFERENCES `khachhang` (`MaKH`),
  ADD CONSTRAINT `FK_VOUCHER_KHACHHANG_VOUCHER` FOREIGN KEY (`MA_VOUCHER`) REFERENCES `voucher` (`MA_VOUCHER`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
