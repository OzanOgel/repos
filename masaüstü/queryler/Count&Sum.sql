--Count 
--ka� adet kolon var
select COUNT(*) from Products

select COUNT(*) from Categories

select * from Products
--SUM
--kolon i�indeki say�lar� topla
select SUM(UnitsInStock) from Products


--Sto�umda toplam ne kadarl�k �r�n var
select SUM(UnitsInStock*UnitPrice) as TotalPrice from Products

--Toplam Ka� adet sat��
select COUNT(*) from Orders

--Toplam Ne kadarl�k sat�� yap�lm��
select SUM(UnitPrice * Quantity) from [Order Details]
