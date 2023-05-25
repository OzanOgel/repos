create database Kitaplýk_DB
go
use Kitaplýk_DB
go
create table Kategoriler
(
ID int IDENTITY(1,1),
isim nvarchar(50) not null,
constraint pk_katagori primary key(ID)
)
GO
create table Turler
(
ID int IDENTITY(1,1),
isim nvarchar(50) not null
constraint pk_tur primary key(ID)

)
go
create table Yazarlar
(
ID int IDENTITY(1,1),
isim nvarchar(50) not null,
soyisim nvarchar(50),
constraint pk_yazar primary key(ID)


)
go
create table þehirler
(
ID int IDENTITY(1,1),
isim nvarchar(50) not null,
constraint pk_Sehir primary key(ID)
)
go
create table ilçeler
(
ID int IDENTITY(1,1),
þehir_ID int,
isim nvarchar(50) not null,
constraint pk_ilce primary key(ID),
constraint fk_ilceþehir foreign key(þehir_ID)
references þehirler(ID)
)
go
create table YayinEvleri
(
ID int IDENTITY(1,1),
þehir_ID int,
Ilce_ID int ,
isim nvarchar(50) not null,
telefon nvarchar(11),
YetkiliAdý nvarchar(100),
constraint pk_YayinEvi primary key(ID),
constraint fk_YayýnEviÞehir foreign key(þehir_ID)
references þehirler(ID),
constraint fk_YayinEviÝlçe foreign key(Ilce_ID)
REFERENCES ilçeler(ID)
)
go
create table kitaplar 
(
ID int IDENTITY(1,1),
Yazar_ID int,
Tur_ID int,
YayinEvi_ID int,
kategori_ID int,
isim nvarchar(75) not null,
Sayfasayisi smallint,
BasimYili nvarchar(4),
Baskisayisi tinyint
constraint pk_kitap primary key(ID),
constraint fk_kitapyazar foreign key(Yazar_ID)
references Yazarlar(ID),
constraint fk_kitapTur  foreign key(Tur_ID)
references Turler(ID),
constraint fk_kitapYayinEvi  foreign key(YayinEvi_ID)
references YayinEvleri(ID),
constraint fk_kitapkatagori  foreign key(kategori_ID)
references Kategoriler(ID)




)
