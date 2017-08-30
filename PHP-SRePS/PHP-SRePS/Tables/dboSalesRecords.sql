CREATE TABLE [dbo].[SaleRecords]
(
	[SaleID] INT NOT NULL , 
    [ProductID] INT NOT NULL, 
    [Employee] NCHAR(10) NOT NULL, 
    [SaleDate] DATE NOT NULL, 
    [Quantity] INT NOT NULL, 
    PRIMARY KEY ([SaleID], [ProductID])
)
