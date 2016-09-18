CREATE TABLE [dbo].[tbl_assessment] (
    [ass_ID]          INT           NOT NULL,
    [ass_duration]    INT           NULL,
    [ass_expiryDate]  DATE          NULL,
    [ass_fitness]     VARCHAR (20)  NULL,
    [ass_note]        VARCHAR (255) NULL,
    [ass_medicalType] VARCHAR (50)  NULL,
    [ass_dateTime]    DATETIME      DEFAULT (curdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ass_ID] ASC)
);

