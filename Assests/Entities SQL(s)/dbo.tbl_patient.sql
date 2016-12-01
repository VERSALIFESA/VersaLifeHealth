use versaDB;

CREATE TABLE tbl_patient (
    pat_ID         DECIMAL (18)  NOT NULL, -- cannot be primary key since pat_number is auto_incremented, hence primary by default
    pat_number     INT           auto_increment NOT NULL primary key,
    pat_firstname  VARCHAR (100) NULL NOT NULL,
    pat_middlename VARCHAR (100) NULL,
    pat_lastname   VARCHAR (100) NOT NULL,
    pat_title      VARCHAR (10)  NOT NULL,
    pat_gender     VARCHAR (10)  NOT NULL,
    pat_DOB        DATE          NOT NULL,
    pat_age        INT           NULL,
    pat_race       VARCHAR (10)  NULL,
    pat_tel        DECIMAL (18)  NULL,
    pat_mobile     DECIMAL (18)  NULL,
    pat_email      VARCHAR (150) NULL,
    pat_address    VARCHAR (255) NULL,
    pat_city       VARCHAR (255) NULL,
    pat_province   VARCHAR (100) NULL,
    pat_postalCode INT           NULL,
    pat_date       TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    pat_notes      VARCHAR (255) NULL,
    pat_attachment VARCHAR (255) NULL
);
