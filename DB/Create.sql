USE master;
GO
IF EXISTS(select * from sys.databases where name='group8b')
Begin
	drop database group8b;
End

create database group8b;

USE group8b
Go
create table dbo.Users
(
ID int identity(1,1) primary key,
Name nvarchar(50) not null,
Password nvarchar(25) not null,
ConfirmPassword nvarchar(25) not null
)

create table dbo.Members
(
	ID int identity(1,1) primary key,
	Name nvarchar(50) not null,
	Address nvarchar(255), 
	PostalCode nvarchar(10),
	PhoneNumber nvarchar(10) not null,
	Email nvarchar(20),
)

create table dbo.Sports
(
	ID int identity(1,1) primary key,
	Name nvarchar(50) not null,
	Description nvarchar(255),
	SportType nvarchar(10),
)

create table dbo.Facility
(
	ID int identity(1,1) primary key,
	SportID int not null,
	CourtCode nvarchar(15) not null,
	CourtName nvarchar(50) not null,
	Size int,
	Description nvarchar(255),
	constraint Facility_Sport_FK foreign key(SportID) references Sports(ID) on delete cascade
)

create table dbo.Slots
(
	ID int identity(1,1) primary key,
	FacilityID int,
	TimeFrom time(0) not null,
	TimeTo time(0) not null
	constraint Slots_Facility_FK foreign key(FacilityID) references Facility(ID) on delete cascade
)

create table dbo.BookingInfo
(
	ID int identity(1,1) primary key,
	MemberID int not null,
	SportID int not null,
	FacilityID int not null,
	SlotID int not null,
	DateIssue datetime not null,
	Status nvarchar(15),
	constraint BookingInfo_Members_FK foreign key(MemberID) references Members(ID),
	constraint BookingInfo_Sports_FK foreign key(SportID) references Sports(ID),
	constraint BookingInfo_Facitliy_FK foreign key(FacilityID) references Facility(ID),
	constraint BookingInfo_Slots_FK foreign key(SlotID) references Slots(ID),
)
Go