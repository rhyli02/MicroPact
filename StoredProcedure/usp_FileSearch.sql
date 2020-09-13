CREATE PROCEDURE usp_FileSearch @criteria nvarchar(225)
AS
SELECT * FROM tblFilePath WHERE FileName LIKE('%'+@criteria +'%')
GO