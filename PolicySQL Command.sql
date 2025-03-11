create database InsuranceDB

create table Policies(
PolicyId int identity(101,1) primary key,
PolicyHolderName nvarchar(50) not null,
Type int not null,
StartDate datetime not null,
EndDate datetime not null
);

drop table Policies




select * from Policies