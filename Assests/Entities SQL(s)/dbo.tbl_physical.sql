use versaDB;

CREATE TABLE tbl_physical (
	ass_ID        INT           PRIMARY KEY,
    psy_datetime  TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    psy_height    DECIMAL (18)  NULL,
    psy_weight    DECIMAL (18)  NULL,
    psy_cannabis  VARCHAR (10)  NULL,
    psy_chestXray VARCHAR (255) NULL,
    FOREIGN KEY (ass_ID) REFERENCES tbl_assessment (ass_ID)
);