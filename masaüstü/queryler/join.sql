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
--ürünlerin ID,isim katogori adý , tedarikçi firma adý tedarikçi firma yetkilisi,stok miktarý fiyat
select p.ProductID , p.ProductName ,c.CategoryName,s.CompanyName ,s.ContactName ,p.UnitsInStock,p.UnitPrice
from Products as p
join Suppliers as s on s.SupplierID = p.SupplierID
join Categories as c on c.CategoryID = p.CategoryID

--Sipariþ vermem gereken satýþtaki ürünlerin
--ürünlerin ID,isim kategori adý ,tedarikçi firma adý,
--Tedarikçi firma yetkilisi,firma telefon numarasý,stok miktarýigüvenlik stoðu güvenlik stoðu ve stok farký


select Products.ProductID, Products.ProductName, Categories.CategoryName,Suppliers.CompanyName, Suppliers.ContactName, Suppliers.Phone, Products.UnitsInStock,Products.ReorderLevel,Products.ReorderLevel - Products.UnitsInStock as fark

from Products 
join Categories  on Categories.CategoryID = Products.CategoryID
join Suppliers on Suppliers.SupplierID = Products.SupplierID
where Products.UnitsInStock <= Products.ReorderLevel and Products.Discontinued = 0

--Sipariþ Detaylarý tablosunu ürün isimleri ile birlikte yazýnýz
select ProductName,[Order Details].*
from [Order Details]
join Products on  [Order Details].ProductID = Products.ProductID






