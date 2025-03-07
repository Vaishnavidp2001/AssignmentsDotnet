create database BookStoreDB


--Author Table ---
create table Authors (
AuthorID int primary key,
Name varchar(30)not null,
Country varchar(20) not null
)


--Books Table
create table Books(
BookID int primary key,
Title varchar(20) not null,
AuthorID int foreign key (AuthorID) references Authors (AuthorID),
Price int not null,
PublishedYear date not null
)


-- Customers Table
create table Customers (
CustomerID int primary key,
Name varchar(30) not null,
Email varchar(50)unique not null,
PhoneNumber varchar(15) unique not null
)


--Orders Table
create table Orders (
OrderID int primary key,
CustomerID int foreign key (CustomerID) references Customers (CustomerID),
OrderDate datetime,
TotalAmount decimal(10,2) not null
)


--OrderItems Table
create table OrderItems (
OrderItemID int primary key,
OrderID int foreign key (OrderID) references Orders(OrderID),
BookID int foreign key (BookId) references Books(BookID),
Quantity int not null,
SubTotal decimal(10,2)
)


--1. Insert at least 5 records into each table. 
--Authors Table
insert into Authors (Name, Country) values
('John Deo','UK'),
('Vaish Patil','USA'),
('Vai Stone','Canada'),
('Maria Gree','Mexico'),
('Emily Smith','Spain');


--Books table
insert into Books (Title, AuthorID, Price, PublishedYear) values
('SQL Mastery', 101, 49.99, 2020),
('Learning Python', 102, 39.99, 2019),
('Web Development 101', 103, 29.99, 2021),
('Database Fundamentals', 104, 34.99, 2018),
('Advanced Algorithms', 105, 59.99, 2022);


--Customers Table
insert into Customers(Name, Email, PhoneNumber) values
('Alice Johnson', 'alice@example.com', '1234567890'),
('Bob Brown', 'bob@example.com', '2345678901'),
('Vaish Davis', 'vaish@example.com', '3456789012'),
('Diana Evans', 'diana@example.com', '4567890123'),
('Ethan Foster', 'ethan@example.com', '5678901234');


--Order Table
insert into Orders(CustomerID, OrderDate,TotalAmount) values
(1, '2025-02-28 10:30:00', 99.98),
(2, '2025-03-01 11:45:00', 39.99),
(3, '2025-03-02 09:15:00', 59.98),
(4, '2025-03-02 15:00:00', 35.99),
(2, '2025-03-03 12:00:00', 100.00);


--orderItems Table
insert into OrderItems(OrderID,BookID, Quantity,SubTotal)values
(1, 1, 2, 99.98),      -- 2 copies of "SQL Mastery"
(2, 2, 1, 39.99),      -- 1 copy of "Learning Python"
(3, 3, 2, 59.98),      -- 2 copies of "Web Development 101"
(4, 4, 1, 35.99),      -- 1 copy of "Database Fundamentals"
(5, 5, 1, 59.99);      -- 1 copy of "Advanced Algorithms"



--2. Update the Price of "SQL Mastery" by Increasing It by 10%
update Books
set Price = Price * 1.10
where Title = 'SQL Master';



--3.Delete a customer who has not placed any orders. 
delete from Customers
where CustomerID not in (select CustomerID from Orders)


--Operators----------
--1. Retrieve all books with a price greater than 2000. 
select *
from Books
where Price > 2000;

--2. Find the total number of books available. 
select count(*) As TotalBooks
from Books;

--3. Find books published between 2015 and 2023. 
select *
from Books
where PublishedYear between 2015 And 2023;

--4. Find all customers who have placed at least one order. 
select *
from Customers
where CustomerID in (
select CustomerID
from Orders
);

--5. Retrieve books where the title contains the word "SQL".
select *
from Books
where Title like '%SQL%';


--6.Find the most expensive book in the store:
select *
from Books
where Price = (select max(Price) from Books);


--7. Retrieve customers whose name starts with "A" or "J". 
select *
from Customers
where Name like 'A%' or Name like 'j%';


--8. Calculate the total revenue from all orders.
select sum(TotalAmount) as TotalRevenue
from Orders;



--Joins
--1. Retrieve all book titles along with their respective author names. 
select b.Title, a.Name as AuthorName
from Books b
join Authors a on b.AuthorID = a.AuthorID;

--2. List all customers and their orders (if any). 
select c.CustomerID, c.Name, o.OrderID, o.OrderDate, o.TotalAmount
from Customers c
left join Orders o on c.CustomerID = o.CustomerID;

--3. Find all books that have never been ordered.
select b.Title
from Books b
LEFT JOIN OrderItems oi on b.BookID = oi.BookID
where oi.BookID IS NULL;

--4. Retrieve the total number of orders placed by each customer.
select c.CustomerID, c.Name, COUNT(o.OrderID) as OrderCount
from Customers c
left join Orders o on c.CustomerID = o.CustomerID
group by c.CustomerID, c.Name;

--5. Find the books ordered along with the quantity for each order. 
select o.OrderID, b.Title, oi.Quantity
from OrderItems oi
join Books b on oi.BookID = b.BookID
join Orders o on oi.OrderID = o.OrderID;


--6. Display all customers, even those who haven’t placed any orders.
select c.CustomerID, c.Name, o.OrderID, o.OrderDate, o.TotalAmount
from Customers c
left join Orders o on c.CustomerID = o.CustomerID;


--7. Find authors who have not written any books.
select a.AuthorID, a.Name
from Authors a
left join Books b on a.AuthorID = b.AuthorID
where b.BookID is null;







