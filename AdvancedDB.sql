DROP DATABASE AdvancedDB
-------------
CREATE DATABASE AdvancedDB
------------------
USE AdvancedDB


 -- Create Employees table
CREATE TABLE Employee (
    EmployeeId INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    BirthDate DATE,
    Salary DECIMAL(10, 2)
);

-- Insert values into Employees table
INSERT INTO Employee (EmployeeId, FirstName, LastName, BirthDate, Salary)
VALUES (1, 'John', 'Doe', '12/10/2020', 50000),
       (2, 'Jane', 'Smith', '10/02/2023', 60000),
       (3, 'Mark', 'Johnson', '10/10/2023', 45000);


	   SELECT * FROM Employee


-- Create Products table
CREATE TABLE Products (
    Productid INT PRIMARY KEY,
    ProductName NVARCHAR(100),
    Description NVARCHAR(500),
    Price MONEY,
    ReleaseDate DATETIME
);

-- Insert values into Products table
INSERT INTO Products (Productid, ProductName, Description, Price, ReleaseDate)
VALUES (1, 'Product A', 'Description of Product A', 10.99, '2021-01-01'),
       (2, 'Product B', 'Description of Product B', 24.99, '2021-02-15'),
       (3, 'Product C', 'Description of Product C', 19.99, '2021-03-20');

	      SELECT * FROM Products



-- Create Orders table
CREATE TABLE Orders (
    Orderld INT PRIMARY KEY,
    OrderDate DATETIME,
    Quantity SMALLINT,
    Discount FLOAT,
    IsShipped BIT
);

-- Insert values into Orders table
INSERT INTO Orders (Orderld, OrderDate, Quantity, Discount, IsShipped)
VALUES (1, '2021-04-05', 5, 0.1, 1),
       (2, '2021-05-10', 10, 0.2, 0),
       (3, '2021-06-15', 3, 0.05, 1);

	      SELECT * FROM Orders