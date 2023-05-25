--Count 
--kaç adet kolon var
select COUNT(*) from Products

select COUNT(*) from Categories

select * from Products
--SUM
--kolon içindeki sayýlarý topla
select SUM(UnitsInStock) from Products


--Stoðumda toplam ne kadarlýk ürün var
select SUM(UnitsInStock*UnitPrice) as TotalPrice from Products

--Toplam Kaç adet satýþ
select COUNT(*) from Orders

--Toplam Ne kadarlýk satýþ yapýlmýþ
select SUM(UnitPrice * Quantity) from [Order Details]
