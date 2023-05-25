Create Database Decentraland
go
use Decentraland

create table Category
(
ID int identity(1,1),
CategoryName nvarchar(100),
constraint pk_category primary key (ID)

)
go
create table Users
(
ID int identity(1,1),
mail nvarchar(100),
_password nvarchar(100),
_Name nvarchar(100),
_Surname nvarchar(100),
constraint pk_Users primary key(ID)

)
go
create Table Products
(
CategoryID int,
ID int identity(1,1),
_name nvarchar(100),
stocks int,
constraint pk_Products primary key(ID),
constraint fk_Products foreign key(CategoryID) references Category(ID)
)


