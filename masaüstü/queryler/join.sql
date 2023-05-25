select * from Categories
select*from Products
select Products.ProductID, Products.ProductName,Products.CategoryID,
Categories.CategoryName
from Products
join Categories on Products.CategoryID = Categories.CategoryID

select Products.ProductID, Products.ProductName, Categories.CategoryName,Products.UnitsInStock, Products.UnitPrice

from Products
join Categories on Products.CategoryID = Categories.CategoryID

select Products.*,Categories.*
from Products
join Categories on Categories.CategoryID = Products.CategoryID

select p.ProductID,p.ProductName,c.CategoryName, p.UnitsInStock, p.ReorderLevel,p.UnitPrice, p.Discontinued
from Products as p
join Categories as c on p.CategoryID = c.CategoryID
--�r�nlerin ID,isim katogori ad� , tedarik�i firma ad� tedarik�i firma yetkilisi,stok miktar� fiyat
select p.ProductID , p.ProductName ,c.CategoryName,s.CompanyName ,s.ContactName ,p.UnitsInStock,p.UnitPrice
from Products as p
join Suppliers as s on s.SupplierID = p.SupplierID
join Categories as c on c.CategoryID = p.CategoryID

--Sipari� vermem gereken sat��taki �r�nlerin
--�r�nlerin ID,isim kategori ad� ,tedarik�i firma ad�,
--Tedarik�i firma yetkilisi,firma telefon numaras�,stok miktar�ig�venlik sto�u g�venlik sto�u ve stok fark�


select Products.ProductID, Products.ProductName, Categories.CategoryName,Suppliers.CompanyName, Suppliers.ContactName, Suppliers.Phone, Products.UnitsInStock,Products.ReorderLevel,Products.ReorderLevel - Products.UnitsInStock as fark

from Products 
join Categories  on Categories.CategoryID = Products.CategoryID
join Suppliers on Suppliers.SupplierID = Products.SupplierID
where Products.UnitsInStock <= Products.ReorderLevel and Products.Discontinued = 0

--Sipari� Detaylar� tablosunu �r�n isimleri ile birlikte yaz�n�z
select ProductName,[Order Details].*
from [Order Details]
join Products on  [Order Details].ProductID = Products.ProductID






