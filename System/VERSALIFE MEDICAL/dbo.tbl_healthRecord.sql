CREATE TABLE [dbo].[tbl_healthRecord] (
    [HR_ID]                  INT           NOT NULL,
    [HR_OtherMedication]     VARCHAR (100) NULL,
    [HR_OtherMedicationNote] VARCHAR (255) NULL,
    [HR_DateTime]            DATETIME      DEFAULT (curdate()) NOT NULL,
    [ass_ID]                 INT           NULL,
    [pat_ID]                 DECIMAL (18)  NULL,
    PRIMARY KEY CLUSTERED ([HR_ID] ASC),
    FOREIGN KEY ([ass_ID]) REFERENCES [dbo].[tbl_assessment] ([ass_ID]),
    FOREIGN KEY ([pat_ID]) REFERENCES [dbo].[tbl_patient] ([pat_ID])
);

