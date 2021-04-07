Select * from Products

Select ProductId as Id, ProductName as Name from Products

Select p.ProductName, p.UnitsInStock * p.UnitPrice as Total from Products p

Select p.ProductName + ' ' + p.QuantityPerUnit from Products p

Select * from Products where UnitsInStock = 10

Select * from Products where CategoryID = 2 order by UnitPrice asc, UnitsInStock desc

Select * from Products where QuantityPerUnit like '%bot%'

Select * from Products where UnitPrice between 10 and 25 order by UnitPrice

Select * from Products where CategoryId in (1,3)

Select Count(*) as [Urun Sayisi] from Products
Select Count(CustomerID) as [Musteri Sayisi] from Customers
Select count(Fax) as FaxNums from Customers

Select Min(UnitPrice) from Products
Select max(UnitPrice) from Products

Select Avg(UnitsInStock) from Products

Select sum(UnitPrice) from [Order Details] where OrderID = 10248
Select sum(UnitPrice * Quantity) from [Order Details] where OrderID = 10248

Select Rand()

Select Left(ProductName, 3) from Products
Select Right(ProductName, 3) from Products
Select ProductName,LEN(ProductName) as KarakterSayisi from Products
Select Lower('KSDDFK')
Select Upper('ksddfk')

Select TRIM('   Kamer Berat Topal   ')
Select TRIM(ProductName) from Products where TRIM(ProductName) = 'Chai'

Select * from Products where Len(ProductName)> 10

Select reverse(lower('Kam') + upper('er'))

Select CHARINDEX('e', 'Kamer', 1)
Select ProductName from Products where CHARINDEX('biscuit', ProductName,1)>0

Select replace('Kamer Berat Topal',' ', '_')
Select replace(ProductName,' ','_') from Products
Select replace(ProductName,'_',' ') from Products

Select SUBSTRING('Kamer Berat Topal',1,7)
Select Ascii('A')
Select Char(76)

Select distinct(Country) from Customers order by Country

Select Country,City,Count(*) from Customers group by Country,City

Select Country,City,Count(*) as Adet from Customers where City <> 'Nantes' group by Country,City 
having Count(*)>1 order by Country

Select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>20 order by Categories.CategoryID

Select p.ProductName, o.OrderDate, od.Quantity*od.UnitPrice as Total from Products p inner join [Order Details] od 
on p.ProductID = od.ProductID
inner join Orders o 
on o.OrderID = od.OrderID
order by p.ProductName, o.OrderDate

Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID 
where od.ProductID is null

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

Select c.ContactName, c.Phone from Orders o right join Customers c
on o.CustomerID = c.CustomerID
where o.CustomerID is null

Select * from Customers c full join Orders o 
on o.CustomerID = c.CustomerID

Select e.EmployeeID from Employees e left join Orders o on o.EmployeeID = e.EmployeeID
where o.EmployeeID is null

Select p.ProductID, p.ProductName, o.OrderID, od.Quantity from Orders as o inner join [Order Details] as od on o.OrderID = od.OrderID
inner join Products as p on p.ProductID = od.ProductID where p.ProductName = 'Alice Mutton'

Select p.ProductName as Urun, Count(od.Quantity) as adet from Products p 
inner join [Order Details] od 
on p.ProductID = od.ProductID
where od.Discount>0
group by p.ProductName order by p.ProductName

Select c.CategoryName, count(*) as [Satis Adet] from Categories as c inner join Products as p 
on c.CategoryID = p.CategoryID
inner join [Order Details] as od 
on p.ProductID = od.ProductID
group by c.CategoryName

Select e.FirstName + ' ' + e.LastName as Personel, e1.FirstName + ' ' + e1.LastName as [Rapor verdiği kişi] from Employees as e 
left join Employees as e1 on e1.EmployeeID = e.ReportsTo

Insert into Categories (CategoryName, Description) values ('Test Category','Test Category Description')
Insert into [Order Details] values(10248,12,12,10,0)

Update Categories set CategoryName =' Test Category ', Description = 'Test Category 1'
where CategoryID = 12

Update Territories set TerritoryDescription = 'İç Anadolu'

Delete from Categories where CategoryID = 12

Select * from CustomersWork
Insert into CustomersWork (CustomerId, CompanyName, ContactName) Select CustomerId,CompanyName,ContactName from Customers

Delete from CustomersWork

Insert into CustomersWork (CustomerId, CompanyName, ContactName) Select CustomerId,CompanyName,ContactName from Customers
where ContactName like '%en%'

Update Customers set CompanyName = CustomersWork.CompanyName
from Customers inner join CustomersWork on Customers.CustomerID = CustomersWork.CustomerID
where CustomersWork.CompanyName like '%test%'

Select * from Customers

Delete Customers 
from Customers inner join CustomersWork on Customers.CustomerID = CustomersWork.CustomerID
where CustomersWork.CompanyName like '%Test%'

Select CustomerID,CompanyName,ContactName from Customers
union
Select * from CustomersWork

