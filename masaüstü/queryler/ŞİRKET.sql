create database SirketDB
go
use SirketDB
go
create table KATEGORÝ
(
ID int identity(1,1),
isim nvarchar(50),
constraint pk_KATEGORÝ primary key(ID)
)
go
create table MARKA
(
ID int identity(1,1),
isim nvarchar(50),
constraint pk_MARKA primary key(ID)
)
go
create table URUN
(
ID int identity(1,1),
isim nvarchar(50),
MARKA_ID int,
KATEGORÝ_ID int,
stok int,
constraint pk_URUN primary key(ID),
constraint fk_urunMarka foreign key(MARKA_ID)
references MARKA(ID),
constraint fk_urunKategori foreign key(KATEGORÝ_ID)
references KATEGORÝ(ID)


)
go
create table BÖLUMLER
(
ID int identity(1,1),
isim nvarchar(50),
constraint pk_BÖLUMLER primary key(ID)
)
GO
CREATE TABLE PERSONEL
(
ID int identity(1,1),
isim nvarchar(50),
soyisim nvarchar(50),
Bolum_ID int,
doðum_yili nvarchar(4),
constraint pk_PERSONEL primary key(ID),
CONSTRAINT fk_PersonelBolum foreign key(Bolum_ID)
references BÖLUMLER(ID)



)
go
create table SIPARIS
(
ID int identity(1,1),
personel_ID int,
adres nvarchar(200),
urun_miktarý int,
Urun_ID int,
ülke nvarchar(50),
constraint pk_sipariþ primary key(ID),
constraint fk_sipariþPersonel foreign key(personel_ID)
references PERSONEL(ID),
constraint fk_sipariþUrun foreign key(Urun_ID)
references URUN(ID)


)
