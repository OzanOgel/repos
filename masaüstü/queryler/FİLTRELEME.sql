select * from Products
--Fiyat� 20 �st� olan �r�nler
select * from Products where UnitPrice > 50
select ProductID,ProductName,UnitPrice
from Products  where UnitPrice>50

--Seafood(8) kategorisindeki �r�nler
select * from Categories
select * from Products

select * from Products where CategoryID = 8
--Sat��� devam eden �r�nler
select * from Products where Discontinued = 0

--Sat��� devam eden fiyat� 50 lira �st� �r�nler
select * from Products where Discontinued =0 and UnitPrice >50
--sipari� vermem gereken �r�nler
select * from Products where UnitsInStock<=ReorderLevel and Discontinued = 0

--Sto�umda Ne kadarl�k �r�n var
select ProductID, ProductName,UnitPrice * UnitsInStock as totalprice from Products
--Fransa almanya ve brezilya g�nderilen sipari�ler
select* from Orders where ShipCountry = 'Germany' or ShipCountry = 'France' or ShipCountry = 'Brazil' 

--Fax Numaras� olmayan m��teriler
select * from Customers where Fax is null
select CustomerID , CompanyName, Fax from Customers where Fax is not null

--ismi A ile ba�layan �r�nler
select* from Products where ProductName like 'A%'
S

