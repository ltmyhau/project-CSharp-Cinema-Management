CREATE DATABASE QuanLyRapPhim
GO

USE QuanLyRapPhim
GO

-- Phim
-- Thể loại
-- Đồ ăn
-- Ghế
-- Phòng
-- Xuất chiếu
-- Tài khoản
-- Hóa đơn
-- Chi tiết hóa đơn


CREATE TABLE PhanLoai
(
	MaPL NVARCHAR(10) CONSTRAINT PK_PL_MaPL PRIMARY KEY(MaPL),
	MoTa NVARCHAR(100) NOT NULL,
	BieuTuongPL IMAGE
)
GO

INSERT INTO PhanLoai (MaPL, MoTa, BieuTuongPL) VALUES 
(N'P', N'Phim được phép phổ biến đến người xem ở mọi độ tuổi', NULL),
(N'K', N'Phim được phổ biến đến người xem dưới 13 tuổi với điều kiện xem cùng cha, mẹ hoặc người giám hộ', NULL),
(N'T13', N'Phim được phổ biến đến người xem từ đủ 13 tuổi trở lên', NULL),
(N'T16', N'Phim được phổ biến đến người xem từ đủ 16 tuổi trở lên', NULL),
(N'T18', N'Phim được phổ biến đến người xem từ đủ 18 tuổi trở lên', NULL),
(N'C', N'Phim không được phép phổ biến', NULL)
GO

CREATE TABLE TheLoai
(
	MaTL NVARCHAR(10) CONSTRAINT PK_TL_MaTL PRIMARY KEY(MaTL),
	TenTheLoai NVARCHAR(50) NOT NULL
)
GO

INSERT INTO TheLoai (MaTL, TenTheLoai) VALUES
(N'TL001', N'Tâm lý'),
(N'TL002', N'Tình cảm'),
(N'TL003', N'Hài hước'),
(N'TL004', N'Hành động'),
(N'TL005', N'Phiêu lưu'),
(N'TL006', N'Hoạt hình')
GO

CREATE TABLE Phim
(
	MaPhim NVARCHAR(10) CONSTRAINT PK_P_MaPhim PRIMARY KEY(MaPhim),
	TenPhim NVARCHAR(100) NOT NULL,
	MaPL NVARCHAR(10) CONSTRAINT FK_P_MaDP FOREIGN KEY(MaPL) REFERENCES PhanLoai(MaPL),
	DaoDien NVARCHAR(100),
	QuocGia NVARCHAR(100),
	ThoiLuong INT NOT NULL,
	NgayKhoiChieu DATE NOT NULL,
	MoTa NTEXT,
	Poster IMAGE,
	Trailer NVARCHAR(100)
)
GO

INSERT INTO Phim (MaPhim, TenPhim, MaPL, DaoDien, QuocGia, ThoiLuong, NgayKhoiChieu, Poster, Trailer, MoTa) VALUES
(N'P001', N'Mai', N'T18', N'Trấn Thành', N'Việt Nam', N'131', CONVERT(DATETIME, '02/10/2024'), NULL, N'https://youtu.be/EX6clvId19s', N'MAI xoay quanh câu chuyện về cuộc đời của một người phụ nữ cùng tên với bộ phim. Trên First-look Poster, Phương Anh Đào tạo ấn tượng mạnh với cái nhìn tĩnh lặng, xuyên thấu, đặc biệt, trên bờ môi nữ diễn viên là hình ảnh cô đang nằm nghiêng trên mặt nước. Được phủ một màn sương mờ ảo, poster đậm chất nghệ thuật của Mai gây tò mò với lời tựa: “Quá khứ chưa ngủ yên, ngày mai liệu sẽ đến?”.'),
(N'P002', N'Gặp Lại Chị Bầu', N'T13', N'Nhất Trung', N'Việt Nam', N'114', CONVERT(DATETIME, '02/10/2024'), NULL, N'https://youtu.be/sJ0rRhTK84', N'Một chàng trai với với niềm đam mê diễn xuất nhưng lại có một quá khứ không bình yên, cùng cuộc gặp gỡ định mệnh với một cô giáo hơi " lố tuổi" , với câu chào đầu đầy ấn tượng " Em có ý gì với chị không?"'),
(N'P003', N'Madame Web', N'T13', N'S.J. Clarkson', N'Mỹ', N'116', CONVERT(DATETIME, '02/14/2024'), NULL, NULL, N'Bộ phim kể về nguồn gốc của một đồng minh Người Nhện, một nhân vật trong truyện tranh Marvel có sức mạnh liên kết đa vũ trụ - Madame Web. Sở hữu khả năng và giác quan nhạy bén của loài nhện, Cassandra có khả năng thấu thị, thần giao cách cảm và nhìn trước tương lai.'),
(N'P004', N'Gia Đình x Điệp Viên Mã: Trắng', N'T13', N'Kazuhiro Furuhashi', N'Nhật Bản', N'111', CONVERT(DATETIME, '02/10/2024'), NULL, N'https://youtu.be/Vl7fCN5nuZ8', N'Bộ phim là phần phim điện ảnh của series anime nổi tiếng Spy x Family. Trong bộ phim lần này, sau khi nhận được yêu cầu thay thế mình trong Chiến dịch Strix, Loid Forger quyết định giúp con gái Anya chiến thắng trong cuộc thi nấu ăn tại Học viện Eden bằng cách nấu bữa ăn yêu thích của hiệu trưởng để tránh bị thay thế khỏi nhiệm vụ mật. Nhưng từ đây, gia đình Forger phát hiện ra bí mật kinh hoàng ảnh hưởng đến hòa bình thế giới.'),
(N'P005', N'Nàng Thơ Của Miller', N'T18', N'Jade Halley Bartlett', N'Mỹ', N'93', CONVERT(DATETIME, '02/16/2024'), NULL, N'https://youtu.be/vk2OJZHutBM', N'Chuyện phim kể về 1 nữ sinh học giỏi nhưng đầy bí ẩn (Jenna Ortega) phải hoàn thành 1 dự án với giáo sư của mình (Martin Freeman). Giữa họ dần hình thành mối quan hệ phức tạp buộc cả 2 phải đấu tranh nhằm giữ vững những gì họ yêu quý khỏi trước những hành động sai lầm của bản thân.'),
(N'P006', N'Argylle Siêu Điệp Viên', N'T16', N'Matthew Vaughn', N'Mỹ', N'139', CONVERT(DATETIME, '02/10/2024'), NULL, N'https://youtu.be/Qn4oyEnfo1U', N'Elly một tiểu thuyết gia nổi tiếng, trở thành một điệp viên bất đắc dĩ khi bị lôi kéo vào các hoạt động của một tập đoàn ngầm nham hiểm.'),
(N'P007', N'Gấu Đỏ Biến Hình', N'P', N'Domee Shi', N'Mỹ', N'99', CONVERT(DATETIME, '02/10/2024'), NULL, N'https://youtu.be/gkTVd7X-iLk', N'"Turning Red - Gấu Đỏ Biến Hình" từ Disney và Pixar kể về Mei Lee, cô bé 13 tuổi tự tin và ngổ ngáo với những sự hỗn loạn của tuổi mới lớn. Mẹ của Mei luôn cố gắng bảo bọc và ở bên cạnh con gái mọi lúc mọi nơi, khiến cô bé cảm thấy như một thảm hoạ vậy. Và cứ như thể những thay đổi về sở thích, các mối quan hệ và thể chất còn chưa đủ, mỗi khi Mei trở nên quá phấn khích (mà thật ra lúc nào cũng vậy), "bùm", cô bé sẽ biến hình thành một chú gấu đỏ siêu cute khổng lồ luôn!'),
(N'P008', N'Cún Cưng Đại Náo Nhà Hát', N'P', N'Vasiliy Rovenskiy', N'Nga', N'75', CONVERT(DATETIME, '02/16/2024'), NULL, N'https://youtu.be/awMUW5_AlFY', N'Chú chó lang tham Samson vô tình lạc vào nhà hát opera Bolshoi nổi tiếng bậc nhất thủ đô Moscow hoa lệ. Vướng vào vụ trộm chiếc vương miện kim cương của nữ diễn viên Anastasia; Samson cùng nàng cún Margot xinh đẹp của Anastasia dấn thân vào cuộc phiêu lưu đại náo nhà hát, truy lùng bọn cướp và giành lại món nữ trang quý giá.'),
(N'P009', N'Pororo: Hành Trình Siêu Sao Âm Nhạc', N'P', N'Yoon Je-wan', N'Hàn Quốc', N'77', CONVERT(DATETIME, '02/23/2024'), NULL, N'https://youtu.be/c5zapDM66P8', N'Pororo và những người bạn của anh ấy sắp sửa chiến thắng trong một cuộc thi ca hát mà họ tham gia cho vui. Liệu Pororo và những người bạn của anh ấy có thoát khỏi sự phiền nhiễu của Big Ben và cuối cùng giành chiến thắng trong cuộc thi siêu sao âm nhạc?')

INSERT INTO Phim (MaPhim, TenPhim, MaPL, DaoDien, QuocGia, ThoiLuong, NgayKhoiChieu, Poster, Trailer, MoTa) VALUES
(dbo.f_AutoMaPhim(), N'Test test test', 'P', NULL, NULL, 99, CONVERT(DATETIME, '02/28/2024'), NULL, NULL, NULL)

SELECT * FROM Phim

CREATE FUNCTION f_AutoMaPhim()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @MaPhim VARCHAR(10)

    IF NOT EXISTS (SELECT * FROM Phim)
		BEGIN
			SET @MaPhim = 'P001'
		END
    ELSE
		BEGIN
			DECLARE @MaxMaPhim INT
			SELECT @MaxMaPhim = MAX(RIGHT(MaPhim, 3)) FROM Phim
			SET @MaPhim = 'P' + RIGHT('000' + CAST(@MaxMaPhim + 1 AS VARCHAR(3)), 3)
		END

    RETURN @MaPhim
END

SELECT 'P' + RIGHT('000' + CAST(MAX(RIGHT(MaPhim, 3)) + 1 AS VARCHAR(3)), 3)
FROM Phim


CREATE TABLE TheLoai_Phim
(
	MaPhim NVARCHAR(10) CONSTRAINT FK_TLP_MaPhim FOREIGN KEY(MaPhim) REFERENCES Phim(MaPhim),
	MaTL NVARCHAR(10) CONSTRAINT FK_TLP_MaTL FOREIGN KEY(MaTL) REFERENCES TheLoai(MaTL),
	CONSTRAINT PK_TLP_MaPhim_MaTL PRIMARY KEY(MaPhim, MaTL)
)
GO

INSERT INTO TheLoai_Phim (MaPhim, MaTL) VALUES
(N'P001', N'TL001'),
(N'P001', N'TL002'),
(N'P002', N'TL002'),
(N'P002', N'TL003'),
(N'P003', N'TL004'),
(N'P003', N'TL005'),
(N'P004', N'TL003'),
(N'P004', N'TL006'),
(N'P005', N'TL002'),
(N'P005', N'TL003'),
(N'P006', N'TL003'),
(N'P006', N'TL004'),
(N'P007', N'TL006'),
(N'P008', N'TL006'),
(N'P008', N'TL005'),
(N'P009', N'TL006'),
(N'P009', N'TL005')
GO

SELECT STRING_AGG(TheLoai.TenTheLoai, ', ') AS 'TheLoaiPhim'
FROM TheLoai_Phim INNER JOIN TheLoai ON TheLoai_Phim.MaTL = TheLoai.MaTL
WHERE TheLoai_Phim.MaPhim = 'P001'

SELECT * FROM Phim

--SELECT Phim.*
--FROM Phim
--INNER JOIN TheLoai_Phim ON Phim.MaPhim = TheLoai_Phim.MaPhim
--INNER JOIN TheLoai ON TheLoai_Phim.MaTL = TheLoai.MaTL
--GROUP BY Phim.MaPhim, Phim.TenPhim, MaPL, DaoDien, QuocGia, ThoiLuong, NgayKhoiChieu, Poster, Trailer, MoTa;

--SELECT Phim.*, PhanLoai.BieuTuong,
--    (
--        SELECT STRING_AGG(TheLoai.TheLoai, ', ')
--        FROM TheLoai_Phim INNER JOIN TheLoai ON TheLoai_Phim.MaTL = TheLoai.MaTL
--        WHERE TheLoai_Phim.MaPhim = Phim.MaPhim
--    ) AS 'TheLoaiPhim'
--FROM Phim INNER JOIN PhanLoai ON Phim.MaPL = PhanLoai.MaPL

SELECT p.MaPhim, p.TenPhim, p.MaPL,	pl.BieuTuong, p.DaoDien, p.QuocGia, p.ThoiLuong, p.NgayKhoiChieu, p.MoTa, p.Poster, p.Trailer,
(SELECT STRING_AGG(tl.TheLoai, ', ')
FROM TheLoai_Phim AS tlp INNER JOIN TheLoai AS tl ON tlp.MaTL = tl.MaTL
WHERE tlp.MaPhim = p.MaPhim) AS 'TheLoaiPhim'
FROM Phim AS p LEFT JOIN PhanLoai AS pl ON p.MaPL = pl.MaPL


CREATE TABLE LoaiTaiKhoan
(
	MaLTK NVARCHAR(10) CONSTRAINT PK_LTK_MaLTK PRIMARY KEY(MaLTK),
	LoaiTK NVARCHAR(10) NOT NULL -- quản lý, nhân viên, khách hàng
)
GO

INSERT INTO LoaiTaiKhoan (MaLTK, LoaiTK) VALUES
(N'QL', N'Quản lý'),
(N'NV', N'Nhân viên'),
(N'KH', N'Khách hàng')
GO

CREATE TABLE TaiKhoan
(
	MaTK NVARCHAR(10) CONSTRAINT PK_TK_MaTK PRIMARY KEY(MaTK),
	UserName NVARCHAR(100) NOT NULL,
	PassWord NVARCHAR(1000) NOT NULL,
	MaLTK NVARCHAR(10) CONSTRAINT FK_TK_MaLTK FOREIGN KEY(MaLTK) REFERENCES LoaiTaiKhoan(MaLTK)
)
GO

INSERT INTO TaiKhoan (MaTK, UserName, PassWord, MaLTK) VALUES
(N'TK001', N'admin', N'123', N'QL'),
(N'TK002', N'nhanvien', N'123', N'NV'),
(N'TK003', N'khachhang', N'123', N'KH')
GO

CREATE PROC sp_Login @userName NVARCHAR(10), @passWord NVARCHAR(10)
AS
BEGIN
	SELECT * FROM TaiKhoan WHERE UserName = @userName AND PassWord = @passWord
END
GO

EXEC sp_Login 'admin', '123'

--CREATE TABLE NhanVien
--(
--	MaNV NVARCHAR(10) CONSTRAINT PK_NV_MaNV PRIMARY KEY(MaNV),
--	HoNV NVARCHAR(50) NOT NULL,
--	TenNV NVARCHAR(50) NOT NULL,
--	NgaySinh DATE,
--	GioiTinh nvarchar(10) CONSTRAINT CK_NV_GioiTinh CHECK (GioiTinh IN(N'Nam', N'Nữ', N'Khác')),
--	NgayVaoLam NVARCHAR NOT NULL,
--	DienThoai NVARCHAR(15),
--	Email NVARCHAR(50),
--	DiaChi NVARCHAR(100)
--)
--GO

--CREATE TABLE KhachHang
--(
--	MaKH NVARCHAR(10) CONSTRAINT PK_KH_MaKH PRIMARY KEY(MaKH),
--	TenKH NVARCHAR(50) NOT NULL,
--	DienThoai NVARCHAR(15),
--	Email NVARCHAR(50)
--)
--GO

--CREATE TABLE LoaiVe
--(
--	MaLV NVARCHAR(10) CONSTRAINT PK_LV_MaLV PRIMARY KEY(MaLV),
--	TenLV NVARCHAR(100) NOT NULL, -- VIP, thường, khuyến mãi
--	Gia INT NOT NULL
--)
--GO

--CREATE TABLE Ve
--(
--	MaVe NVARCHAR(10) CONSTRAINT PK_Ve_MaVe PRIMARY KEY(MaVe),
--	MaLV NVARCHAR(10) CONSTRAINT FK_Ve_MaLV FOREIGN KEY(MaLV) REFERENCES LoaiVe(MaLV),
--	MaNV NVARCHAR(10) CONSTRAINT FK_Ve_MaNV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV),
--	MaKH NVARCHAR(10) CONSTRAINT FK_Ve_MaKH FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH),
--	Ghe NVARCHAR(10) NOT NULL,
--	NgayBanVe DATE
--)
--GO

--CREATE TABLE DangPhim
--(
--	MaDP NVARCHAR(10) CONSTRAINT PK_DP_MaDP PRIMARY KEY(MaDP),
--	DangPhim NVARCHAR(20) NOT NULL, -- 2D, 3D,...
--)
--GO

--CREATE TABLE PhongChieu
--(
--	MaPhong NVARCHAR(10) CONSTRAINT PK_PC_MaPhong PRIMARY KEY(MaPhong),
--	TenPhong NVARCHAR(100) NOT NULL,
--	SoLuongGhe INT NOT NULL
--)
--GO

--CREATE TABLE Ghe
--(
--	MaGhe NVARCHAR(10) CONSTRAINT PK_G_MaGhe PRIMARY KEY(MaGhe),
--	SoGhe INT NOT NULL,
--	Hang NVARCHAR(10) NOT NULL,
--	MaPhong NVARCHAR(10) CONSTRAINT FK_G_MaPhong FOREIGN KEY(MaPhong) REFERENCES PhongChieu(MaPhong)
--)
--GO

--CREATE TABLE ThongTinVe
--(
--	MaVe NVARCHAR(10) CONSTRAINT FK_TTV_MaVe FOREIGN KEY(MaVe) REFERENCES Ve(MaVe),
--	MaPhong NVARCHAR(10) CONSTRAINT FK_TTV_MaPhong FOREIGN KEY(MaPhong) REFERENCES PhongChieu(MaPhong),
--	MaPhim NVARCHAR(10) CONSTRAINT FK_TTV_MaPhim FOREIGN KEY(MaVe) REFERENCES Phim(MaPhim),
--	XuatChieu DATETIME NOT NULL,
--	CONSTRAINT PK_TTV_MaVe_MaPhong_MaPhim PRIMARY KEY(MaVe, MaPhong, MaPhim),
--)
--GO

CREATE TABLE PhimIDTuDong
(
	MaPhim NVARCHAR(10) CONSTRAINT PK_PTD_MaPhim PRIMARY KEY(MaPhim),
	TenPhim NVARCHAR(100) NOT NULL,
	DaoDien NVARCHAR(100),
	QuocGia NVARCHAR(100),
	ThoiLuong INT NOT NULL
)
GO

INSERT INTO Phim (MaPhim, TenPhim, MaPL, DaoDien, QuocGia, ThoiLuong, NgayKhoiChieu, Poster, Trailer, MoTa) VALUES
(N'P001', N'Mai', N'T18', N'Trấn Thành', N'Việt Nam', N'131', CONVERT(DATETIME, '02/10/2024'), NULL, N'https://youtu.be/EX6clvId19s', N'MAI xoay quanh câu chuyện về cuộc đời của một người phụ nữ cùng tên với bộ phim. Trên First-look Poster, Phương Anh Đào tạo ấn tượng mạnh với cái nhìn tĩnh lặng, xuyên thấu, đặc biệt, trên bờ môi nữ diễn viên là hình ảnh cô đang nằm nghiêng trên mặt nước. Được phủ một màn sương mờ ảo, poster đậm chất nghệ thuật của Mai gây tò mò với lời tựa: “Quá khứ chưa ngủ yên, ngày mai liệu sẽ đến?”.'),
(N'P002', N'Gặp Lại Chị Bầu', N'T13', N'Nhất Trung', N'Việt Nam', N'114', CONVERT(DATETIME, '02/10/2024'), NULL, N'https://youtu.be/sJ0rRhTK84', N'Một chàng trai với với niềm đam mê diễn xuất nhưng lại có một quá khứ không bình yên, cùng cuộc gặp gỡ định mệnh với một cô giáo hơi " lố tuổi" , với câu chào đầu đầy ấn tượng " Em có ý gì với chị không?"'),
(N'P003', N'Madame Web', N'T13', N'S.J. Clarkson', N'Mỹ', N'116', CONVERT(DATETIME, '02/14/2024'), NULL, NULL, N'Bộ phim kể về nguồn gốc của một đồng minh Người Nhện, một nhân vật trong truyện tranh Marvel có sức mạnh liên kết đa vũ trụ - Madame Web. Sở hữu khả năng và giác quan nhạy bén của loài nhện, Cassandra có khả năng thấu thị, thần giao cách cảm và nhìn trước tương lai.'),
(N'P004', N'Gia Đình x Điệp Viên Mã: Trắng', N'T13', N'Kazuhiro Furuhashi', N'Nhật Bản', N'111', CONVERT(DATETIME, '02/10/2024'), NULL, N'https://youtu.be/Vl7fCN5nuZ8', N'Bộ phim là phần phim điện ảnh của series anime nổi tiếng Spy x Family. Trong bộ phim lần này, sau khi nhận được yêu cầu thay thế mình trong Chiến dịch Strix, Loid Forger quyết định giúp con gái Anya chiến thắng trong cuộc thi nấu ăn tại Học viện Eden bằng cách nấu bữa ăn yêu thích của hiệu trưởng để tránh bị thay thế khỏi nhiệm vụ mật. Nhưng từ đây, gia đình Forger phát hiện ra bí mật kinh hoàng ảnh hưởng đến hòa bình thế giới.'),
(N'P005', N'Nàng Thơ Của Miller', N'T18', N'Jade Halley Bartlett', N'Mỹ', N'93', CONVERT(DATETIME, '02/16/2024'), NULL, N'https://youtu.be/vk2OJZHutBM', N'Chuyện phim kể về 1 nữ sinh học giỏi nhưng đầy bí ẩn (Jenna Ortega) phải hoàn thành 1 dự án với giáo sư của mình (Martin Freeman). Giữa họ dần hình thành mối quan hệ phức tạp buộc cả 2 phải đấu tranh nhằm giữ vững những gì họ yêu quý khỏi trước những hành động sai lầm của bản thân.'),
(N'P006', N'Argylle Siêu Điệp Viên', N'T16', N'Matthew Vaughn', N'Mỹ', N'139', CONVERT(DATETIME, '02/10/2024'), NULL, N'https://youtu.be/Qn4oyEnfo1U', N'Elly một tiểu thuyết gia nổi tiếng, trở thành một điệp viên bất đắc dĩ khi bị lôi kéo vào các hoạt động của một tập đoàn ngầm nham hiểm.'),
(N'P007', N'Gấu Đỏ Biến Hình', N'P', N'Domee Shi', N'Mỹ', N'99', CONVERT(DATETIME, '02/10/2024'), NULL, N'https://youtu.be/gkTVd7X-iLk', N'"Turning Red - Gấu Đỏ Biến Hình" từ Disney và Pixar kể về Mei Lee, cô bé 13 tuổi tự tin và ngổ ngáo với những sự hỗn loạn của tuổi mới lớn. Mẹ của Mei luôn cố gắng bảo bọc và ở bên cạnh con gái mọi lúc mọi nơi, khiến cô bé cảm thấy như một thảm hoạ vậy. Và cứ như thể những thay đổi về sở thích, các mối quan hệ và thể chất còn chưa đủ, mỗi khi Mei trở nên quá phấn khích (mà thật ra lúc nào cũng vậy), "bùm", cô bé sẽ biến hình thành một chú gấu đỏ siêu cute khổng lồ luôn!'),
(N'P008', N'Cún Cưng Đại Náo Nhà Hát', N'P', N'Vasiliy Rovenskiy', N'Nga', N'75', CONVERT(DATETIME, '02/16/2024'), NULL, N'https://youtu.be/awMUW5_AlFY', N'Chú chó lang tham Samson vô tình lạc vào nhà hát opera Bolshoi nổi tiếng bậc nhất thủ đô Moscow hoa lệ. Vướng vào vụ trộm chiếc vương miện kim cương của nữ diễn viên Anastasia; Samson cùng nàng cún Margot xinh đẹp của Anastasia dấn thân vào cuộc phiêu lưu đại náo nhà hát, truy lùng bọn cướp và giành lại món nữ trang quý giá.'),
(N'P009', N'Pororo: Hành Trình Siêu Sao Âm Nhạc', N'P', N'Yoon Je-wan', N'Hàn Quốc', N'77', CONVERT(DATETIME, '02/23/2024'), NULL, N'https://youtu.be/c5zapDM66P8', N'Pororo và những người bạn của anh ấy sắp sửa chiến thắng trong một cuộc thi ca hát mà họ tham gia cho vui. Liệu Pororo và những người bạn của anh ấy có thoát khỏi sự phiền nhiễu của Big Ben và cuối cùng giành chiến thắng trong cuộc thi siêu sao âm nhạc?')
