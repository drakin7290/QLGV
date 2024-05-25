CREATE DATABASE QLGV
GO

USE QLGV
GO

-- FUNCTION
CREATE OR ALTER PROCEDURE CreateAutoGenerateTrigger 
    @TableName NVARCHAR(128),
	@Prefix VARCHAR(2)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)
    DECLARE @Columns NVARCHAR(MAX)
	SELECT @Columns = STRING_AGG(QUOTENAME(name), ', ')
    FROM sys.columns
    WHERE object_id = OBJECT_ID(@TableName) AND name != 'id'
    SET @SQL = '
        CREATE TRIGGER AutoGenerate_' + @TableName + '
        ON ' + @TableName + '
        INSTEAD OF INSERT
        AS
        BEGIN
            DECLARE @ID NVARCHAR(50)
            DECLARE @NextID INT
            
            SELECT @NextID = ISNULL(MAX(CAST(SUBSTRING(id, 3, LEN(id) - 2) AS INT)), 0) + 1
            FROM ' + @TableName + '
            
            SELECT @ID = '''+ @Prefix +''' + RIGHT(''000'' + CAST(@NextID AS NVARCHAR(10)), 2)
            
            INSERT INTO ' + @TableName + '([id], '+@Columns+')
            SELECT @ID, ' + @Columns + '
            FROM inserted
        END;'
    EXEC sp_executesql @SQL
END;
GO
-- FUNCTION

---- CREATE TABLE [CHUCVU]
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'CHUCVU' AND TABLE_SCHEMA = 'dbo')
   DROP TABLE [dbo].[CHUCVU];
GO
CREATE TABLE CHUCVU(
	id varchar(25) not null primary key,
	name nvarchar(50) not null unique,
)
GO

INSERT CHUCVU (id, name) VALUES ('admin',N'Quản trị viên')
INSERT CHUCVU (id, name) VALUES ('gvbm',N'Giáo viên bộ môn')


---- CREATE TABLE [TAIKHOAN]

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TAIKHOAN' AND TABLE_SCHEMA = 'dbo')
   DROP TABLE [dbo].[TAIKHOAN];
GO
CREATE TABLE TAIKHOAN(
	id char(5) not null primary key,
	taikhoan varchar(20) not null unique,
	matkhau varchar(100) not null default 'e10adc3949ba59abbe56e057f20f883e', /* default: 123456 */
	chucvu_id varchar(25) null,
	FOREIGN KEY (chucvu_id) REFERENCES CHUCVU(id)
)
GO
EXEC CreateAutoGenerateTrigger 'TAIKHOAN', 'TK';
GO

INSERT TAIKHOAN (taikhoan, matkhau, chucvu_id) VALUES ('admin', 'e10adc3949ba59abbe56e057f20f883e', 'admin') /*password: 123456*/
INSERT TAIKHOAN (taikhoan, matkhau, chucvu_id) VALUES ('GV01', 'e10adc3949ba59abbe56e057f20f883e', 'gvbm') /*password: 123456*/
INSERT TAIKHOAN (taikhoan, matkhau, chucvu_id) VALUES ('GV02', 'e10adc3949ba59abbe56e057f20f883e', 'gvbm') /*password: 123456*/
INSERT TAIKHOAN (taikhoan, matkhau, chucvu_id) VALUES ('GV03', 'e10adc3949ba59abbe56e057f20f883e', 'gvbm') /*password: 123456*/

---- CREATE TABLE [MONHOC]

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'MONHOC' AND TABLE_SCHEMA = 'dbo')
   DROP TABLE [dbo].[MONHOC];
GO
CREATE TABLE MONHOC(
	id char(5) not null primary key,
	name nvarchar(20) not null unique,
)
GO
EXEC CreateAutoGenerateTrigger 'MONHOC', 'MH';
GO

INSERT MONHOC (name) VALUES (N'Toán')
INSERT MONHOC (name) VALUES (N'Vật lý')
INSERT MONHOC (name) VALUES (N'Hóa học')
INSERT MONHOC (name) VALUES (N'Sinh học')
INSERT MONHOC (name) VALUES (N'Địa lý')
INSERT MONHOC (name) VALUES (N'Tiếng anh')

---- CREATE TABLE [GIAOVIEN]

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'GIAOVIEN' AND TABLE_SCHEMA = 'dbo')
   DROP TABLE [dbo].[GIAOVIEN];
GO
CREATE TABLE GIAOVIEN (
	id char(5) not null primary key,
	name nvarchar(50) not null,
	[gioitinh]  nvarchar (3) NOT NULL CHECK ([gioitinh] IN(N'Nam', N'Nữ')) DEFAULT N'Nam',
	ngaysinh date not null,
	sodienthoai varchar(11) unique not null,
	diachi nvarchar(30),
	luong int default 0,
	id_monhoc char(5),
	FOREIGN KEY (id_monhoc) REFERENCES MONHOC(id)
)
GO
EXEC CreateAutoGenerateTrigger 'GIAOVIEN', 'GV';
GO

INSERT GIAOVIEN (name, ngaysinh, sodienthoai, gioitinh, diachi, luong, id_monhoc) VALUES (N'Nguyễn Văn Thiên', '11/17/2002', '0696278902', N'Nam', N'Đông Xuyên', 5000000, 'MH01')
INSERT GIAOVIEN (name, ngaysinh, sodienthoai, gioitinh, diachi, luong, id_monhoc) VALUES (N'Trần Thị Tĩnh', '03/12/1998', '0793278902', N'Nữ', N'Đông Xuyên', 10000000, 'MH03')
INSERT GIAOVIEN (name, ngaysinh, sodienthoai, gioitinh, diachi, luong, id_monhoc) VALUES (N'Dương Bảo Toàn', '11/23/2000', '0216278902', N'Nam', N'Mỹ Xuyên', 6000000, 'MH02')


IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'THOIKHOABIEU' AND TABLE_SCHEMA = 'dbo')
   DROP TABLE [dbo].[THOIKHOABIEU];
GO

CREATE TABLE THOIKHOABIEU (
	id char(5) not null primary key,
	id_giaovien char(5),
	FOREIGN KEY (id_giaovien) REFERENCES GIAOVIEN(id),
	id_monhoc char(5),
	ngayday date,
	FOREIGN KEY (id_monhoc) REFERENCES MONHOC(id),
	tietbatdau tinyint check (tietbatdau <= 11 AND tietbatdau > 0),
	tietketthuc tinyint check (tietketthuc <= 11 AND tietketthuc > 0),
	ten_lop varchar(10),
	CHECK (tietbatdau <= tietketthuc),
)
GO

EXEC CreateAutoGenerateTrigger 'THOIKHOABIEU', 'TB';
GO

INSERT THOIKHOABIEU (id_giaovien, id_monhoc, ngayday, tietbatdau, tietketthuc, ten_lop) VALUES ('GV01', 'MH01', '05/09/2024', 1, 3, '12A3');
INSERT THOIKHOABIEU (id_giaovien, id_monhoc, ngayday, tietbatdau, tietketthuc, ten_lop) VALUES ('GV01', 'MH01', '05/09/2024', 6, 10, '12A3');
INSERT THOIKHOABIEU (id_giaovien, id_monhoc, ngayday, tietbatdau, tietketthuc, ten_lop) VALUES ('GV01', 'MH02', '05/09/2024', 4, 5, '12A4');
INSERT THOIKHOABIEU (id_giaovien, id_monhoc, ngayday, tietbatdau, tietketthuc, ten_lop) VALUES ('GV01', 'MH01', '05/12/2024', 4, 5, '12A4');
INSERT THOIKHOABIEU (id_giaovien, id_monhoc, ngayday, tietbatdau, tietketthuc, ten_lop) VALUES ('GV01', 'MH02', '05/16/2024', 4, 5, '12A4');
INSERT THOIKHOABIEU (id_giaovien, id_monhoc, ngayday, tietbatdau, tietketthuc, ten_lop) VALUES ('GV02', 'MH02', '06/03/2024', 2, 5, '12A3');
INSERT THOIKHOABIEU (id_giaovien, id_monhoc, ngayday, tietbatdau, tietketthuc, ten_lop) VALUES ('GV02', 'MH02', '06/12/2024', 3, 5, '12A3');
INSERT THOIKHOABIEU (id_giaovien, id_monhoc, ngayday, tietbatdau, tietketthuc, ten_lop) VALUES ('GV02', 'MH02', '06/05/2024', 2, 5, '12A3');
INSERT THOIKHOABIEU (id_giaovien, id_monhoc, ngayday, tietbatdau, tietketthuc, ten_lop) VALUES ('GV02', 'MH02', '05/05/2024', 2, 5, '12A3');


SELECT * FROM GIAOVIEN LEFT JOIN MONHOC ON GIAOVIEN.id_monhoc=MONHOC.id

SELECT GIAOVIEN.*, MONHOC.name as name_monhoc
FROM GIAOVIEN, MONHOC
WHERE GIAOVIEN.id_monhoc = MONHOC.id;

SELECT GIAOVIEN.*, MONHOC.name as name_monhoc FROM GIAOVIEN, MONHOC WHERE GIAOVIEN.id_monhoc = MONHOC.id and GIAOVIEN.name=N'Dương Bảo Toàn'

SELECT TAIKHOAN.*, CHUCVU.name as ten_chucvu FROM TAIKHOAN, CHUCVU WHERE TAIKHOAN.chucvu_id = CHUCVU.id

SELECT ngayday, SUM(tietketthuc - tietbatdau) AS sotiet
FROM THOIKHOABIEU
GROUP BY ngayday;



SELECT 
    GIAOVIEN.id,
	GIAOVIEN.name,
    SUM(tietketthuc - tietbatdau) AS sotiet,
    GIAOVIEN.gioitinh,
    GIAOVIEN.diachi,
	GIAOVIEN.luong,
	GIAOVIEN.sodienthoai,
	GIAOVIEN.id_monhoc,
	MONHOC.name as name_monhoc
FROM 
    THOIKHOABIEU
JOIN 
    GIAOVIEN ON GIAOVIEN.id = THOIKHOABIEU.id_giaovien
JOIN 
    MONHOC ON GIAOVIEN.id_monhoc = MONHOC.id
WHERE  
    MONTH(ngayday) = MONTH(getdate()) 
GROUP BY 
    GIAOVIEN.id, 
	GIAOVIEN.name,
    GIAOVIEN.diachi,
    GIAOVIEN.gioitinh,
	GIAOVIEN.luong,
	GIAOVIEN.sodienthoai,
	GIAOVIEN.id_monhoc,
	MONHOC.name 