use UniversiteDB
go
INSERT INTO Fakulteler(Isim,Dekan)
values('Edebiyat fakultesi','Prof.Dr. Mehmet Erol ALTINSAPAN')
INSERT INTO Fakulteler(Isim,Dekan)
values('E�itim fakultesi','Prof.Dr Erkan D�N�')
INSERT INTO Fakulteler(Isim,Dekan)
values('M�hendislik fakultesi','Prof.Dr. R.Tuna Balkan')
INSERT INTO Fakulteler(Isim,Dekan)
values('Hukuk fakultesi','Prof. Dr. Recai D�NMEZ')
INSERT INTO Fakulteler(Isim,Dekan)
values('Sa�l�k Bilimleri Fakultesi','Prof. Dr. Merdiye �END�R')
--Executeledin!!!!!!!!!!!!!!!!
--
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('Arkeoloji B�l�m�',11 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('Felsefe B�l�m�',11 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('Psikoloji B�l�m�',11 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('Sanat Tarihi B�l�m�',11 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('Sosyoloji B�l�m�',11 )
--
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('E�itim Bilimleri B�l�m�',12 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('Bilgisayar ve ��retim teknolojileri B�l�m�',12 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('G�zel sanatlar e�itimi B�l�m�',12 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('Matematik ve Fen bilimleri e�itimi B�l�m�',12 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('yabanc� diller e�itimi B�l�m�',12 )
--
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('Bilgisayar m�hendisli�i B�l�m�',13 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('Biyom�hendislik B�l�m�',13 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('Makine M�hendisli�i B�l�m�',13 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('�n�aat m�hendisli�i B�l�m�',13 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('end�stri m�hendisli�i  B�l�m�',13 )
--
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('Hukuk B�l�m�',14 )
--
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('Beslenme ve Diyetetik B�l�m�',15 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('�ocuk geli�imi B�l�m�',15 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('Dil ve konu�ma terapisi b�l�m�',15 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('Hem�irelik B�l�m�',15 )
INSERT INTO Bolumler(Isim,Fakulte_ID)
values('i� sa�l��� ve g�venli�i B�l�m�',15 )
--EXECUTELED�NN!!!!!!!!!!!!!
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('10102363422','Ozan','�gel','Mesut',105)
--EXECUTELED�NN!!!!!!!!!!!!!
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('47635787543','Zafer','��can','Murat',106)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('98765432112','Ya�mur','k�rm�z�','abdurrahman',107)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('10102363427','�layda','Demir','Ahmet',108)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('98765432122','�layda','Kele�','Mehmet',109)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('10102363232','�lke','Aslan','Mehmet',110)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('20102363422','Mehmet','Demir','Mehmet',111)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('30202363422','ahmet','ye�il','rezzak',112)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('40102363422','Buket','Sararan','casut',113)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('50102363422','polat','bak�r','jayce',114)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('60102363422','�a�r� Talha','Yener','fuzuli',115)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('70102363422','melih','u�ar','tekin',116)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('80102363422','ye�im','ye�eren','yal�n',117)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('90102363422','yal�n','kal�n','dal�n',118)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('91102363422','Bark�n','Kark�n','H�seyin',119)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('92102363422','suayip','k�zaran','G�d�g�d�rahman',120)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('93102363422','Recep Tayyip','Erdo�an','Keldo�an',121)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('94102363422','Emine','Erdo�an','Recep',122)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('96102363422','fatmag�l','alan','ahmet',123)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('97102363422','o�uzhan','utku','tutku',124)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('98102363422','Mutlu','Polat','Alemdar',125)
INSERT INTO Ogrenciler(OkulNo,Isim,Soyad,BabaAdi,Bolum_ID)
VALUES('99102363422','Batuhan','Uymaz','Mehmet',126)












