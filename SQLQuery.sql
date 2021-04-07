--Select
--ANSII
Select * from Customers
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers
select * from Customers where City = 'London'
select * from Products where categoryId=1 or categoryId=3
select * from Products where CategoryID=1 and UnitPrice>=10
select * from Products order by ProductName
select * from Products where categoryId=1 order by UnitPrice asc

select count(*) from Products
select count(*) from Products where categoryId=2 
select count(*) Adet from Products

select categoryId from Products group by CategoryID
select categoryId, count(*) from Products group by CategoryID
select categoryId, count(*) from Products group by CategoryID having count(*)<10
select categoryId, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select * from Products inner join Categories on Products.CategoryID=Categories.CategoryID
select Products.ProductID, Products.ProductName, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID

--Data Transformation Object DTO

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID 
where o.CustomerID is null

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID 
inner join Orders o 
on o.OrderID = od.OrderID








