USE QLSinhVien;
GO

CREATE TABLE Diem
(
    MaSinhVien VARCHAR(20) NOT NULL,
    MaMonHoc VARCHAR(20) NOT NULL,
    Diem FLOAT NOT NULL,

    PRIMARY KEY (MaSinhVien, MaMonHoc)
);
GO