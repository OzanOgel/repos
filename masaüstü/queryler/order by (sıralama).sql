select * from Products order by UnitPrice
--�r�n fiyat�na g�re k���kten b�y��e do�ru s�rala
 
select *from Products order by UnitPrice desc --B�y�kten k����e s�ralama
select  * from Products order by ProductName

--�r�n fiyat� 20 ile 50 aras�nda olan �r�nleri fiyatlar�na g�re b�y�kten k����e g�re s�ralayak getiriniz
select * from Products where UnitPrice >= 20 and UnitPrice <= 50 order by UnitPrice desc
select * from Products where UnitPrice between 20 and 50 order by UnitPrice desc
--Fiyat� en pahal� 10 �r�n
select top(10) * from Products order by UnitPrice desc
