using Assignment2.Models;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

/*use Dontnet10Assignment1;

--Departments
create table Departments(
	DepartmentId int primary key,
    DepartmentName varchar(50)
);

insert into Departments (DepartmentId, DepartmentName)
values(1, 'Cardiology'),
	   (2, 'Neurology'),
	   (3, 'Orthopedics');



--Doctors
create table Doctors(
	DoctorId int primary key,
    DoctorName varchar(50),
	DoctorGender varchar(10),
	DepartmentId int foreign key references Departments(DepartmentId)
);

insert into Doctors(DoctorId, DoctorName, DoctorGender, DepartmentId)
values(1, 'Dr. Smit', 'Male', 1),
	   (2, 'Dr. Mihir', 'Male', 2),
	   (3, 'Dr. Rahul', 'Male', 3);


--Patients
create table Patients(
	PatientId int primary key,
    PatientName varchar(50),
	PatientGender varchar(10)
	
);

insert into Patients(PatientId, PatientName, PatientGender)
values(1, 'Darshan Goswami', 'Male'),
	   (2, 'Vasu patel', 'Male'),
	   (3, 'Krishna Bhadaniya', 'Female');


--HealthcareAssistants
create table HealthcareAssistants(
	HealthcareAssistantsID int primary key,
    HealthcareAssistantsName varchar(50),
	DepartmentId int foreign key references Departments(DepartmentId),
	PatientId int foreign key references Patients(PatientId)
);

insert into HealthcareAssistants(HealthcareAssistantsID, HealthcareAssistantsName, DepartmentId, PatientId)
values(1, 'Rahul sign', 1, 1),
	   (2, 'Milan Parmar', 2, 2),
	   (3, 'Nandini Gupta', 3, 3),
	   (4, 'Jeet Sutariya', 3, 2);

--Drugs
create table Drugs(
	DrugsId int primary key,
    DrugsName varchar(50)
);

insert into Drugs(DrugsId, DrugsName)
values(1, 'Drug A'),
	   (2, 'Drug B'),
	   (3, 'Drug C');



--TreatmentSchedule
create table TreatmentSchedule(
	TreatmentScheduleId int primary key,
    PatientId int foreign key references Patients(PatientId),
	DoctorId int foreign key references Doctors(DoctorId)
);

insert into TreatmentSchedule(TreatmentScheduleId, PatientId, DoctorId)
values(1, 1, 1),
	   (2, 2, 2),
	   (3, 3, 3),
	   (4, 2, 1),
	   (5, 3, 1);

--Multiple Medicine case
create table Multimedicine(
	MultimedicineId int primary key,
    TreatmentScheduleId int foreign key references TreatmentSchedule(TreatmentScheduleId),
	DrugsId int foreign key references Drugs(DrugsId),
	MultimedicineEattime varchar(15)
);

insert into Multimedicine(MultimedicineId, TreatmentScheduleId, DrugsId, MultimedicineEattime)
values(1, 1, 1, 'Morning'),
	   (2, 2, 3, 'Afternoon'),
	   (3, 3, 2, 'Evening'),
	   (4, 4, 3, 'Morning'),
	   (5, 5, 1, 'Afternoon'),
	   (6, 5, 2, 'Evening');

select* from Departments;
select* from Doctors;
select* from Patients;
select* from HealthcareAssistants;
select* from Drugs;
select* from TreatmentSchedule;
select* from Multimedicine;

drop table Multimedicine;
drop table Departments;
drop table Doctors;
drop table Patients;
drop table HealthcareAssistants;
drop table Drugs;
drop table TreatmentSchedule;




alter PROCEDURE query1 @pi int
AS
select p.PatientName, d.DoctorName from Patients p inner join  TreatmentSchedule t on p.PatientId=t.PatientId join Doctors d on t.DoctorId=d.DoctorId where p.PatientId=@pi;

exec query1 @pi=3;




alter PROCEDURE query2 @pi int
AS
select p.PatientId, p.PatientName,do.DoctorName, d.DrugsName, m.MultimedicineEattime, de.DepartmentName from Multimedicine m join Drugs d on m.DrugsId=d.DrugsId 
join TreatmentSchedule t on m.TreatmentScheduleId=t.TreatmentScheduleId
 join Patients p on p.PatientId=t.PatientId 
 join Doctors do on do.DoctorId=t.DoctorId 
 join Departments de on de.DepartmentId=do.DepartmentId
where p.PatientId=@pi;

exec query2 @pi=2;
*/