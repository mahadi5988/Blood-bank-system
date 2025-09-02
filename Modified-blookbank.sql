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

create table UserRegistration(
user_pk int NOT NULL IDENTITY(1,1) primary key,
username varchar(250) not null,
userpassword varchar(250) not null
)

select * from UserRegistration;

create table userDetail(
uid int not null IDENTITY(1,1) primary key,
user_fk int not null,
uname varchar(250) not null,
fname varchar(250) not null,
mname varchar(250) not null,
dob varchar(250) not null,
mobile bigint not null,
gender varchar(50) not null
)

user_fk,uname,fname,mname,dob,mobile,gender


insert into userDetail (user_fk,uname,fname,mname,dob,mobile,gender) values (1,'djglkdlkj','fglk','glkj','17-12-2021','123456798','Male')

select * from userDetail;

truncate table userDetail;

create table bloodRequest(
bloodreq_id int not null IDENTITY(1,1) primary key,
user_fk int not null,
bloodgroup varchar(250) not null,
requiredunit varchar(250) not null,
reqdate datetime not null,
status varchar(250),
reason varchar(250)
)



select * from bloodRequest;


select count(*) from stock where blood_group='A+' and quantity>=500;

select * from stock;

update stock set quantity=quantity-5 where blood_group='A+';

select count(*) from stock where blood_group='A+' and quantity>=500


