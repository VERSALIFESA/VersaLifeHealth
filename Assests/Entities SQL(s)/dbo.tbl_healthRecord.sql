use versaDB;

CREATE TABLE tbl_healthRecord (
	HR_ID                  INT           NOT NULL,
    HR_OtherMedication     VARCHAR (100) NULL,
    HR_OtherMedicationNote VARCHAR (255) NULL,
    HR_DateTime            TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    ass_ID                 INT           NULL,
    pat_number             INT,
    PRIMARY KEY CLUSTERED (HR_ID ASC),
    FOREIGN KEY (ass_ID) REFERENCES tbl_assessment (ass_ID),
    FOREIGN KEY (pat_number) REFERENCES tbl_patient (pat_number) -- changed from pat_ID to pat_number since pat_ID is not a primary key anymore
);