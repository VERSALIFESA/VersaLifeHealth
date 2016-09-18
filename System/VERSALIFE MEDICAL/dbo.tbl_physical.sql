CREATE TABLE [dbo].[tbl_physical] (
    [ass_ID]        INT           NULL,
    [psy_datetime]  DATETIME      DEFAULT (curdate()) NOT NULL,
    [psy_height]    DECIMAL (18)  NULL,
    [psy_weight]    DECIMAL (18)  NULL,
    [psy_cannabis]  VARCHAR (10)  NULL,
    [psy_chestXray] VARCHAR (255) NULL,
    FOREIGN KEY ([ass_ID]) REFERENCES [dbo].[tbl_assessment] ([ass_ID])
);

