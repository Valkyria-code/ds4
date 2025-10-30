use northwind;

-- ejemplo 1
select * from Products;

-- ejemplo 2
select ProductID, ProductName, UnitPrice
from Products;


-- ejemplo 3
select ProductID, ProductName, UnitPrice
from Products
where UnitPrice > 15;

-- ejemplo 4
select ProductID, ProductName, UnitPrice
from Products
where UnitPrice >= 15 and UnitPrice <= 50;

--ejemplo 5
select ProductID, ProductName, UnitPrice
from Products
where UnitPrice between 15 and 50;

-- ejemplo 6
select ProductID, ProductName, UnitPrice
from Products
where not UnitPrice > 15;

-- ejemplo 7
select ProductID, ProductName, UnitPrice
from Products
where UnitPrice > 15 or UnitPrice < 10;

-- ejemplo 8
select EmployeeID, LastName
from Employees
where LastName like 'D%';

-- ejemplo 9
select EmployeeID, LastName
from Employees
where LastName like '%N';

-- ejemplo 10
select EmployeeID, LastName, Title
from Employees
where LastName like '%SALES%';

-- ejemplo 11
select EmployeeID, LastName
from Employees
where LastName not like 'D%';

-- ejemplo 12
select ProductID, ProductName, UnitPrice
from Products
order by ProductID asc;

-- ejemplo 13
select ProductID, ProductName, UnitPrice
from Products
order by ProductID desc;

-- ejemplo 14
select distinct OrderID
from [Order Details];

-- ejemplo 15
select top 5 OrderID, ProductID, Quantity
from [Order Details];

-- ejemplo 16
select top 10 percent OrderID, ProductID, Quantity
from [Order Details];

-- ejemplo 17
select CategoryName
as [Nombre de Categoría]
from Categories

-- ejemplo 18
select OrderID, OrderDate, ShippedDate, ShippedDate + 5
as RetrasoEnvio
from Orders;

-- ejemplo 19
select OrderID, P.ProductID, ProductName
from Products P
inner join [Order DEtails] OD
on P.ProductID = OD.ProductID;

-- ejemplo 20
select ProductName, CompanyName, ContactName
from Products P
full join Suppliers S
on P.SupplierID = S.SupplierID;
