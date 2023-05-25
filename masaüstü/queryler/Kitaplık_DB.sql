create database Kitapl�kDB
go
use kitapl�kDB
go
create table kitapl�k
(
ID int identity(897986,7),
�sim nvarchar(150) not null,
Yazar nvarchar(150) not null,
T�r nvarchar(150) not null,
Yay�nEvi nvarchar(150) not null
constraint pk_kitapl�k primary key(ID)

)

insert into Kitapl�k(�sim,Yazar,T�r,Yay�nEvi)
values('Mekanik Melek','Cassandra Clare','Fanastik','Artemis yay�nlar�')
--EXECUTELADIN!!!!!!!
insert into Kitapl�k(�sim,Yazar,T�r,Yay�nEvi)
values('Mekanik Prens','Cassandra Clare','Fanastik','Artemis yay�nlar�')
insert into Kitapl�k(�sim,Yazar,T�r,Yay�nEvi)
values('Mekanik Prenses','Cassandra Clare','Fanastik','Artemis yay�nlar�')
insert into Kitapl�k(�sim,Yazar,T�r,Yay�nEvi)
values('Kemikler �ehri','Cassandra Clare','Fanastik','Artemis yay�nlar�')
insert into Kitapl�k(�sim,Yazar,T�r,Yay�nEvi)
values('K�ller �ehri','Cassandra Clare','Fanastik','Artemis yay�nlar�')
insert into Kitapl�k(�sim,Yazar,T�r,Yay�nEvi)
values('Camlar �ehri','Cassandra Clare','Fanastik','Artemis yay�nlar�')
insert into Kitapl�k(�sim,Yazar,T�r,Yay�nEvi)
values('D��m�� Melekler �ehri','Cassandra Clare','Fanastik','Artemis yay�nlar�')
insert into Kitapl�k(�sim,Yazar,T�r,Yay�nEvi)
values('kay�p Ruhlar �ehri','Cassandra Clare','Fanastik','Artemis yay�nlar�')
insert into Kitapl�k(�sim,Yazar,T�r,Yay�nEvi)
values('Cennet Ate�i �ehri','Cassandra Clare','Fanastik','Artemis yay�nlar�')
insert into Kitapl�k(�sim,Yazar,T�r,Yay�nEvi)
values('G�lge Avc�s�n�n El Kitab�','Cassandra Clare','Fanastik','Artemis yay�nlar�')
insert into Kitapl�k(�sim,Yazar,T�r,Yay�nEvi)
values('D�nyalar Sava��','H. G. Wells','Bilim Kurgu','�thaki yay�nlar�')
insert into Kitapl�k(�sim,Yazar,T�r,Yay�nEvi)
values('Senin Su�un De�il','Beyhan Budak','Psikoloji','�nk�lap kitabevi')
insert into Kitapl�k(�sim,Yazar,T�r,Yay�nEvi)
values('G��ebe','Altu� G�mr�k��','fantastik ',' �kinci Adam Yay�nlar�')
--EXECUTE YAPTIN !!!!!!
create table �evirmenler
(
ID int identity(1,1),
Kitapl�k_ID int,
�evirmen nvarchar(70)

constraint pk_�evirmen primary key(ID)
constraint fk_kitapl�k_�evirmen FOREIGN KEY(Kitapl�k_ID)
references kitapl�k(ID)

)
insert into �evirmenler(Kitapl�k_ID,�evirmen)
values(897986,'Zeynep Heyzen Ate�')
--Execute yapt�n!!!!!
insert into �evirmenler(Kitapl�k_ID,�evirmen)
values(897993,'Selim Yeni�eri')
insert into �evirmenler(Kitapl�k_ID,�evirmen)
values(898000,'Bilge G�nd�z')
insert into �evirmenler(Kitapl�k_ID,�evirmen)
values(898007,'Selim Yeni�eri')
insert into �evirmenler(Kitapl�k_ID,�evirmen)
values(898014,'Selim Yeni�eri')
insert into �evirmenler(Kitapl�k_ID,�evirmen)
values(898021,'Selim Yeni�eri')
insert into �evirmenler(Kitapl�k_ID,�evirmen)
values(898028,'Zeynep Heyzen Ate�')
insert into �evirmenler(Kitapl�k_ID,�evirmen)
values(898035,'U�ur Mehter')
insert into �evirmenler(Kitapl�k_ID,�evirmen)
values(898042,'Zeynep Ar�kan')
insert into �evirmenler(Kitapl�k_ID,�evirmen)
values(898049,'Zeynep Ar�kan')
insert into �evirmenler(Kitapl�k_ID,�evirmen)
values(898056,'Ali Kaftan')









