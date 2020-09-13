
CREATE TABLE tblFilePath (
    FileID int NOT NULL,
    FullPath Nvarchar(255) NOT NULL,
    FileName Nvarchar(255) NOT NULL,
    ReadOnly bit,
	Size Nvarchar(50),
	CreatedDate DateTime,
    CONSTRAINT PK_tblFilePath PRIMARY KEY (FileID)
);