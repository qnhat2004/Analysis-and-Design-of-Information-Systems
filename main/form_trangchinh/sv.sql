create database sinhvien
use sinhvien

create table sv (
	stt int,
	madd nvarchar(50),
	hoten nvarchar(100),
	ngaysinh date,
	gioitinh nvarchar(10),
	diemrl int,
	diemtb float,
	masv int, 
	malop char(10),
	quequan nvarchar(100),
)

drop table sv

select * from sv
select masv, hoten, malop, ngaysinh, quequan, gioitinh from sv
-- Chèn dữ liệu cho 30 bản ghi
INSERT INTO sv (stt, madd, hoten, ngaysinh, gioitinh, diemrl, diemtb, masv, malop, quequan) VALUES
(1, '0012345678', N'Nguyễn Văn An', '2004-12-12', N'Nam', 90, 4, 101, 'A01', N'Hà Nội'),
(2, '0012345679', N'Trần Thị Bình', '2003-05-20', N'Nữ', 85, 3.5, 102, 'A02', N'Hồ Chí Minh'),
(3, '0012345680', N'Lê Văn Cường', '2002-08-15', N'Nam', 92, 4.2, 103, 'A03', N'Hà Nội'),
(4, '0012345681', N'Phạm Thị Dung', '2005-01-10', N'Nữ', 88, 3.8, 104, 'A04', N'Hải Phòng'),
(5, '0012345682', N'Hoàng Văn Đức', '2003-11-30', N'Nam', 87, 3.7, 105, 'A05', N'Đà Nẵng'),
(6, '0012345683', N'Nguyễn Thị Hà', '2004-07-25', N'Nữ', 91, 4.3, 106, 'A06', N'Nghệ An'),
(7, '0012345684', N'Trần Văn Hải', '2002-03-18', N'Nam', 84, 3.4, 107, 'A07', N'Hà Tĩnh'),
(8, '0012345685', N'Lê Thị Lan', '2005-09-05', N'Nữ', 89, 3.9, 108, 'A08', N'Hải Dương'),
(9, '0012345686', N'Nguyễn Văn Long', '2003-02-28', N'Nam', 86, 3.6, 109, 'A09', N'Thanh Hóa'),
(10, '0012345687', N'Phạm Thị Mai', '2004-06-17', N'Nữ', 90, 4, 110, 'A10', N'Hà Nam'),
(11, '0012345688', N'Hoàng Văn Nam', '2002-12-22', N'Nam', 93, 4.5, 111, 'A11', N'Quảng Ninh'),
(12, '0012345689', N'Nguyễn Thị Ngọc', '2005-08-09', N'Nữ', 87, 3.7, 112, 'A12', N'Nam Định'),
(13, '0012345690', N'Trần Văn Phong', '2003-04-03', N'Nam', 94, 4.7, 113, 'A13', N'Thái Bình'),
(14, '0012345691', N'Lê Thị Quỳnh', '2004-01-28', N'Nữ', 89, 3.9, 114, 'A14', N'Hưng Yên'),
(15, '0012345692', N'Nguyễn Văn Sơn', '2002-06-14', N'Nam', 85, 3.5, 115, 'A15', N'Tây Ninh'),
(16, '0012345693', N'Trần Thị Thu', '2005-10-31', N'Nữ', 91, 4.3, 116, 'A16', N'Vĩnh Long'),
(17, '0012345694', N'Phạm Văn Tú', '2003-07-26', N'Nam', 82, 3.2, 117, 'A17', N'Bắc Ninh'),
(18, '0012345695', N'Lê Thị Út', '2004-02-19', N'Nữ', 88, 3.8, 118, 'A18', N'Hà Giang'),
(19, '0012345696', N'Nguyễn Văn Vượng', '2002-09-14', N'Nam', 90, 4, 119, 'A19', N'Bình Định'),
(20, '0012345697', N'Trần Thị Xuân', '2005-04-09', N'Nữ', 86, 3.6, 120, 'A20', N'Thái Nguyên'),
(21, '0012345698', N'Phạm Văn Yên', '2003-01-04', N'Nam', 95, 4.9, 121, 'A21', N'Lào Cai'),
(22, '0012345699', N'Lê Thị Anh', '2004-07-21', N'Nữ', 87, 3.7, 122, 'A22', N'Điện Biên'),
(23, '0012345700', N'Nguyễn Văn Bảo', '2002-03-15', N'Nam', 84, 3.4, 123, 'A23', N'Cà Mau'),
(24, '0012345701', N'Trần Thị Chi', '2005-09-02', N'Nữ', 89, 3.9, 124, 'A24', N'Đồng Nai'),
(25, '0012345702', N'Phạm Văn Đạt', '2003-02-25', N'Nam', 88, 3.8, 125, 'A25', N'Kiên Giang'),
(26, '0012345703', N'Lê Thị Dung', '2004-06-12', N'Nữ', 91, 4.3, 126, 'A26', N'Bà Rịa - Vũng Tàu'),
(27, '0012345704', N'Nguyễn Văn Hải', '2002-12-27', N'Nam', 83, 3.3, 127, 'A27', N'Lâm Đồng'),
(28, '0012345705', N'Trần Thị Hoa', '2005-08-14', N'Nữ', 92, 4.2, 128, 'A28', N'Sóc Trăng'),
(29, '0012345706', N'Phạm Văn Kiên', '2003-04-09', N'Nam', 89, 3.9, 129, 'A29', N'Bình Thuận'),
(30, '0012345707', N'Lê Thị Lan', '2004-01-02', N'Nữ', 86, 3.6, 130, 'A30', N'Cần Thơ');
