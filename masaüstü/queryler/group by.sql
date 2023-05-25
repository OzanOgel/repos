--Hangi Kategoride Ka� adet �r�n var 
select COUNT(*) from Products

select CategoryID,COUNT(*) from Products
group by CategoryID
--kategori ad�na g�re hangi kategoride ka� adet �r�n var
select c.CategoryName,COUNT(*) as adet
from Products as p
join Categories as c on p.CategoryID=c.CategoryID
group by c.CategoryName

select c.CategoryName,COUNT(*) as adet
from Products as p
join Categories as c on p.CategoryID=c.CategoryID
where p.Discontinued = 0
group by c.CategoryName

--hangi personelim ka� adet sat�� yapm��

select Employees.FirstName,Employees.LastName, COUNT(*) as total from Orders
join Employees on Employees.EmployeeID = Orders.EmployeeID

group by Employees.FirstName,Employees.LastName
order by total desc

select e.TitleOfCourtesy + ' ' + e.FirstName + ' ' + e.LastName as employee , COUNT(*) as total
FROM Orders as o
join Employees as e on o.EmployeeID = e.EmployeeID
group by e.TitleOfCourtesy + ' ' + e.FirstName + ' ' + e.LastName
order by total desc

--hangi �r�n�mden Ne kadarl�k sat�� yap�lm��
select ProductName,SUM(od.Quantity * od.Quantity) as Total
from Products as p
join [Order Details] as od on od.ProductID = p.ProductID
group by ProductName order by Total desc

--Hangi persolelim ne kadarl�k sat�� yap�lm��
select e.FirstName + ' ' + e.LastName as employee, SUM(od.Quantity*od.UnitPrice) as total
from [Order Details] as od
join Orders as o on od.OrderID = o.OrderID
join Employees as e on o.EmployeeID =e.EmployeeID
group by e.FirstName + ' ' + e.LastName order by total desc


