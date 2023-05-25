create database KitaplýkDB
go
use kitaplýkDB
go
create table kitaplýk
(
ID int identity(897986,7),
Ýsim nvarchar(150) not null,
Yazar nvarchar(150) not null,
Tür nvarchar(150) not null,
YayýnEvi nvarchar(150) not null
constraint pk_kitaplýk primary key(ID)

)

insert into Kitaplýk(Ýsim,Yazar,Tür,YayýnEvi)
values('Mekanik Melek','Cassandra Clare','Fanastik','Artemis yayýnlarý')
--EXECUTELADIN!!!!!!!
insert into Kitaplýk(Ýsim,Yazar,Tür,YayýnEvi)
values('Mekanik Prens','Cassandra Clare','Fanastik','Artemis yayýnlarý')
insert into Kitaplýk(Ýsim,Yazar,Tür,YayýnEvi)
values('Mekanik Prenses','Cassandra Clare','Fanastik','Artemis yayýnlarý')
insert into Kitaplýk(Ýsim,Yazar,Tür,YayýnEvi)
values('Kemikler Þehri','Cassandra Clare','Fanastik','Artemis yayýnlarý')
insert into Kitaplýk(Ýsim,Yazar,Tür,YayýnEvi)
values('Küller Þehri','Cassandra Clare','Fanastik','Artemis yayýnlarý')
insert into Kitaplýk(Ýsim,Yazar,Tür,YayýnEvi)
values('Camlar Þehri','Cassandra Clare','Fanastik','Artemis yayýnlarý')
insert into Kitaplýk(Ýsim,Yazar,Tür,YayýnEvi)
values('Düþmüþ Melekler Þehri','Cassandra Clare','Fanastik','Artemis yayýnlarý')
insert into Kitaplýk(Ýsim,Yazar,Tür,YayýnEvi)
values('kayýp Ruhlar Þehri','Cassandra Clare','Fanastik','Artemis yayýnlarý')
insert into Kitaplýk(Ýsim,Yazar,Tür,YayýnEvi)
values('Cennet Ateþi Þehri','Cassandra Clare','Fanastik','Artemis yayýnlarý')
insert into Kitaplýk(Ýsim,Yazar,Tür,YayýnEvi)
values('Gölge Avcýsýnýn El Kitabý','Cassandra Clare','Fanastik','Artemis yayýnlarý')
insert into Kitaplýk(Ýsim,Yazar,Tür,YayýnEvi)
values('Dünyalar Savaþý','H. G. Wells','Bilim Kurgu','Ýthaki yayýnlarý')
insert into Kitaplýk(Ýsim,Yazar,Tür,YayýnEvi)
values('Senin Suçun Deðil','Beyhan Budak','Psikoloji','Ýnkýlap kitabevi')
insert into Kitaplýk(Ýsim,Yazar,Tür,YayýnEvi)
values('Göçebe','Altuð Gümrükçü','fantastik ',' Ýkinci Adam Yayýnlarý')
--EXECUTE YAPTIN !!!!!!
create table Çevirmenler
(
ID int identity(1,1),
Kitaplýk_ID int,
Çevirmen nvarchar(70)

constraint pk_Çevirmen primary key(ID)
constraint fk_kitaplýk_çevirmen FOREIGN KEY(Kitaplýk_ID)
references kitaplýk(ID)

)
insert into Çevirmenler(Kitaplýk_ID,Çevirmen)
values(897986,'Zeynep Heyzen Ateþ')
--Execute yaptýn!!!!!
insert into Çevirmenler(Kitaplýk_ID,Çevirmen)
values(897993,'Selim Yeniçeri')
insert into Çevirmenler(Kitaplýk_ID,Çevirmen)
values(898000,'Bilge Gündüz')
insert into Çevirmenler(Kitaplýk_ID,Çevirmen)
values(898007,'Selim Yeniçeri')
insert into Çevirmenler(Kitaplýk_ID,Çevirmen)
values(898014,'Selim Yeniçeri')
insert into Çevirmenler(Kitaplýk_ID,Çevirmen)
values(898021,'Selim Yeniçeri')
insert into Çevirmenler(Kitaplýk_ID,Çevirmen)
values(898028,'Zeynep Heyzen Ateþ')
insert into Çevirmenler(Kitaplýk_ID,Çevirmen)
values(898035,'Uður Mehter')
insert into Çevirmenler(Kitaplýk_ID,Çevirmen)
values(898042,'Zeynep Arýkan')
insert into Çevirmenler(Kitaplýk_ID,Çevirmen)
values(898049,'Zeynep Arýkan')
insert into Çevirmenler(Kitaplýk_ID,Çevirmen)
values(898056,'Ali Kaftan')









