create database SirketDB
go
use SirketDB
go
create table KATEGOR�
(
ID int identity(1,1),
isim nvarchar(50),
constraint pk_KATEGOR� primary key(ID)
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
KATEGOR�_ID int,
stok int,
constraint pk_URUN primary key(ID),
constraint fk_urunMarka foreign key(MARKA_ID)
references MARKA(ID),
constraint fk_urunKategori foreign key(KATEGOR�_ID)
references KATEGOR�(ID)


)
go
create table B�LUMLER
(
ID int identity(1,1),
isim nvarchar(50),
constraint pk_B�LUMLER primary key(ID)
)
GO
CREATE TABLE PERSONEL
(
ID int identity(1,1),
isim nvarchar(50),
soyisim nvarchar(50),
Bolum_ID int,
do�um_yili nvarchar(4),
constraint pk_PERSONEL primary key(ID),
CONSTRAINT fk_PersonelBolum foreign key(Bolum_ID)
references B�LUMLER(ID)



)
go
create table SIPARIS
(
ID int identity(1,1),
personel_ID int,
adres nvarchar(200),
urun_miktar� int,
Urun_ID int,
�lke nvarchar(50),
constraint pk_sipari� primary key(ID),
constraint fk_sipari�Personel foreign key(personel_ID)
references PERSONEL(ID),
constraint fk_sipari�Urun foreign key(Urun_ID)
references URUN(ID)


)
