create database bloodbank;

create table newDonor(
did int NOT NULL IDENTITY(1,1) primary key,
dname varchar(250) not null,
fname varchar(250) not null,
mname varchar(250) not null,
dob varchar(50) not null,
mobile bigint not null,
gender varchar(25) not null,
email varchar(250) not null,
bloodgroup varchar(250) not null,
city varchar(150) not null,
daddress varchar(550) not null
)


select * from newDonor


select max(did) from newDonor



create table stock(
bid int NOT NULL IDENTITY(1,1) primary key,
blood_group varchar(50) not null,
quantity varchar(50) not null
)

select * from stock

insert into stock (blood_group,quantity) values ('A+',100);
insert into stock (blood_group,quantity) values ('O+',100);
insert into stock (blood_group,quantity) values ('B+',100);
insert into stock (blood_group,quantity) values ('AB+',100);
insert into stock (blood_group,quantity) values ('A-',100);