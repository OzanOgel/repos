select * from Products
--Fiyatý 20 üstü olan ürünler
select * from Products where UnitPrice > 50
select ProductID,ProductName,UnitPrice
from Products  where UnitPrice>50

--Seafood(8) kategorisindeki ürünler
select * from Categories
select * from Products

select * from Products where CategoryID = 8
--Satýþý devam eden ürünler
select * from Products where Discontinued = 0

--Satýþý devam eden fiyatý 50 lira üstü ürünler
select * from Products where Discontinued =0 and UnitPrice >50
--sipariþ vermem gereken ürünler
select * from Products where UnitsInStock<=ReorderLevel and Discontinued = 0

--Stoðumda Ne kadarlýk ürün var
select ProductID, ProductName,UnitPrice * UnitsInStock as totalprice from Products
--Fransa almanya ve brezilya gönderilen sipariþler
select* from Orders where ShipCountry = 'Germany' or ShipCountry = 'France' or ShipCountry = 'Brazil' 

--Fax Numarasý olmayan müþteriler
select * from Customers where Fax is null
select CustomerID , CompanyName, Fax from Customers where Fax is not null

--ismi A ile baþlayan ürünler
select* from Products where ProductName like 'A%'
S

