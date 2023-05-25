create database Kitapl�k_DB
go
use Kitapl�k_DB
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
create table �ehirler
(
ID int IDENTITY(1,1),
isim nvarchar(50) not null,
constraint pk_Sehir primary key(ID)
)
go
create table il�eler
(
ID int IDENTITY(1,1),
�ehir_ID int,
isim nvarchar(50) not null,
constraint pk_ilce primary key(ID),
constraint fk_ilce�ehir foreign key(�ehir_ID)
references �ehirler(ID)
)
go
create table YayinEvleri
(
ID int IDENTITY(1,1),
�ehir_ID int,
Ilce_ID int ,
isim nvarchar(50) not null,
telefon nvarchar(11),
YetkiliAd� nvarchar(100),
constraint pk_YayinEvi primary key(ID),
constraint fk_Yay�nEvi�ehir foreign key(�ehir_ID)
references �ehirler(ID),
constraint fk_YayinEvi�l�e foreign key(Ilce_ID)
REFERENCES il�eler(ID)
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
