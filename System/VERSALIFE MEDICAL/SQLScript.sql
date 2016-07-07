drop table tbl_patients

create table tbl_patients
(
pat_ID dec primary key,
pat_number int identity(00,1),
pat_firstname varchar(100),
pat_middlename varchar(100),
pat_lastname varchar(100),
pat_title varchar(10),
pat_gender varchar(10),
pat_DOB date,
pat_age int,
pat_race varchar(10),
pat_tel dec,
pat_mobile dec,
pat_email varchar(150),
pat_address varchar(255),
pat_city varchar(255),
pat_province varchar(100),
pat_postalCode int,
pat_date datetime NOT NULL DEFAULT GETDATE(),
pat_notes varchar(255),
pat_attachment varchar(255),
)