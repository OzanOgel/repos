select * from Products order by UnitPrice
--Ürün fiyatýna göre küçükten büyüðe doðru sýrala
 
select *from Products order by UnitPrice desc --Büyükten küçüðe sýralama
select  * from Products order by ProductName

--Ürün fiyatý 20 ile 50 arasýnda olan ürünleri fiyatlarýna göre büyükten küçüðe göre sýralayak getiriniz
select * from Products where UnitPrice >= 20 and UnitPrice <= 50 order by UnitPrice desc
select * from Products where UnitPrice between 20 and 50 order by UnitPrice desc
--Fiyatý en pahalý 10 ürün
select top(10) * from Products order by UnitPrice desc
