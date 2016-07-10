/*drop table tbl_employmentHistory
drop table tbl_abnormality
drop table tbl_audiometry
drop table tbl_bloodPressure
drop table tbl_consumption
drop table tbl_lungFuction
drop table tbl_physical
drop table tbl_recommendation 
drop table tbl_restriction
drop table tbl_urinalysis
drop table tbl_visualExaminiation
drop table tbl_healthRecord 
drop table tbl_assessment
drop table tbl_patient

*/
create table tbl_patient
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
create table tbl_employmentHistory
(
empHistory_ID int primary key,
pat_ID dec foreign key references tbl_patient(pat_ID),
cl_ID int foreign key references tbl_clients(cl_ID),
empHistory_company varchar(100),
empHistory_occupation varchar(50),
empHistory_jobDescription varchar(50),
empHistory_dateFromTo date,
)

create table tbl_assessment
(
ass_ID int primary key,
ass_duration int,
ass_expiryDate date,
ass_fitness varchar(20),
ass_note varchar(255),
ass_medicalType varchar(50),
ass_dateTime datetime NOT NULL DEFAULT GETDATE(),
)
create table tbl_recommendation
(
ass_ID int foreign key references tbl_assessment(ass_ID),
rec_hearingProtection varchar(50),
rec_approptiateMask varchar(50),
)
create table tbl_restriction
(
ass_ID int foreign key references tbl_assessment(ass_ID),
res_heart varchar(25),
res_height varchar(25),
res_noise varchar(25),
res_dust varchar(25),
res_movingMachinery varchar(25),
)
create table tbl_bloodPressure
(
ass_ID int foreign key references tbl_assessment(ass_ID),
BP_systolic dec,
BP_diastolic dec,
BP_pulse dec,
BP_HGT dec,
)
create table tbl_audiometry
(
ass_ID int foreign key references tbl_assessment(ass_ID),
aud_PLH dec,
aud_PLHShift dec,
aud_ABHL dec,
)
create table tbl_consumption
(
ass_ID int foreign key references tbl_assessment(ass_ID),
con_alcohol varchar(10),
con_alcoholTypeDrink varchar(25),
con_alcoholFrequency varchar(25),
con_smoke varchar(10) null,
con_smokeTye varchar(25),
con_somkeFrequecny int,
)
create table tbl_physical 
(
ass_ID int foreign key references tbl_assessment(ass_ID),
psy_datetime datetime NOT NULL DEFAULT GETDATE(),
psy_height dec,
psy_weight dec,
psy_cannabis varchar(10) null,
psy_chestXray varchar(255),
)
create table tbl_lungFuction 
(
ass_ID int foreign key references tbl_assessment(ass_ID),
LF_FVCPredicted dec,
LF_FVCBest dec,
LF_FVCPercentPredicted varchar(10),
LF_FEV1Predicted dec,
LF_FEV1Best dec,
LF_FEV1PercentPredicted varchar(10),
LF_FVCbyFEV1Predicted dec,
LF_FVCbyFEV1Best dec,
LF_FVCbyFEV1PercentPredicted varchar(10),
) 
create table tbl_abnormality 
(
ass_ID int foreign key references tbl_assessment(ass_ID),
ABN_HeadFaceHandNeck varchar(10),
ABN_GITSystem varchar(10),
ABN_peripheralSystem varchar(10),
ABN_vascularSystem varchar(10),
ABN_lymphaticSystem varchar(10),
ABN_chest varchar(10),
ABN_lungs varchar(10),
ABN_breast varchar(10),
ABN_cardiovascularSystem varchar(10),
ABN_ear varchar(10),
ABN_nose varchar(10),
ABN_throat varchar(10),
ABN_genitoUrinarySystem varchar(10),
ABN_backAndSpine varchar(10),
ABN_musculoskeletalSystem varchar(10),
ABN_skinAndAppendages varchar(10),
ABN_neurologicalSystem varchar(10),
ABN_psychologicalEvaluation varchar(10),
)
create table tbl_visualExaminiation
(
ass_ID int foreign key references tbl_assessment(ass_ID),
ve_nearRight int,
ve_nearLeft int,
ve_nearBoth int,
ve_farRight int,
ve_farLeft int,
ve_farBoth int,
ve_visual varchar(10),
ve_visualNote varchar(255),
ve_vision varchar(10),
ve_visionNote varchar(255),
ve_perception varchar(10),
ve_perceptionNote varchar(255),
)
create table tbl_urinalysis
(
ass_ID int foreign key references tbl_assessment(ass_ID),
uri_blood varchar(10),
uri_bloodNote varchar(255),
uri_protein varchar(10),
uri_proteinNote varchar(255),
uri_sugar varchar(10),
uri_sugarNote varchar(255),
uri_PH int,
uri_PHNote varchar(255),
uri_appearanceNote varchar(255),
)
create table tbl_healthRecord
(
HR_ID int primary key, 
HR_OtherMedication varchar(100),
HR_OtherMedicationNote varchar(255),
HR_DateTime datetime NOT NULL DEFAULT GETDATE(),
ass_ID int foreign key references tbl_assessment(ass_ID),
pat_ID dec foreign key references tbl_patient(pat_ID),
)
create table tbl_headCNS
(
HR_ID int foreign key references tbl_healthRecord(HR_ID),
HRHead_epilepsyFits varchar(10), 
HRHead_fainting varchar(10),
HRHead_injury varchar(10),
HRHead_diziness varchar(10),
)
create table tbl_ears
(
HR_ID int foreign key references tbl_healthRecord(HR_ID),
HREars_deafness varchar(10),
HREars_injury varchar(10),
)
create table tbl_gastrointestinal
(
HR_ID int foreign key references tbl_healthRecord(HR_ID),
HRGastroUri_haematurial varchar(10),
HRGastroUri_kidneyStones varchar(10),
HRGastroUri_prostate varchar(10),
HRGastroUri_gynecologicalProblems varchar(10),
)
create table tbl_psychiatry
(
HR_ID int foreign key references tbl_healthRecord(HR_ID),
HRPsyc_schizophrenia varchar(10),
HRPsyc_psychosis varchar(10),
HRPsyc_depression varchar(10),
HRPsyc_anxiety varchar(10),
HRPsyc_panicAttack varchar(10),
HRPsyc_suicideAttempt varchar(10),
)
create table tbl_musculoskeletal
(
HR_ID int foreign key references tbl_healthRecord(HR_ID),
HRMus_backProblem varchar(10),
HRMus_weakness varchar(10),
HRMus_deformities varchar(10),
HRMus_cancer varchar(10),
HRMus_boneInjuries varchar(10),
HRMus_jointProblem varchar(10),
)
create table tbl_noseThroat
(
HR_ID int foreign key references tbl_healthRecord(HR_ID),
HRNoseThroat_speechDisorder varchar(10),
HRNoseThroat_thyroidism varchar(10),
)
create table tbl_cardiovascular
(
HR_ID int foreign key references tbl_healthRecord(HR_ID),
HRCardio_lowBloodPressure varchar(10),
HRCardio_highBloodPressure varchar(10),
HRCardio_chestPain varchar(10),
HRCardio_angina varchar(10),
HRCardio_heartAttack varchar(10),
HRCardio_palpitations varchar(10),
HRCardio_circulationDisorder varchar(10),
)
create table tbl_respiratory
(
HR_ID int foreign key references tbl_healthRecord(HR_ID),
HRRep_asthma varchar(10),
HRRep_pneumonia varchar(10),
HRRep_emphysema varchar(10),
HRRep_lungCancer varchar(10),
)
create table tbl_skin
(
HR_ID int foreign key references tbl_healthRecord(HR_ID),
HRSkin_allergicConditions varchar(10),
HRSkin_dermatitis varchar(10),
HRSkin_disorders varchar(10),
)