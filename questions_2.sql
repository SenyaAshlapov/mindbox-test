CREATE TABLE Products (Id INT PRIMARY KEY, "ProductName" TEXT);
CREATE TABLE Categories (Id INT PRIMARY KEY,"CategorieName" TEXT);

INSERT INTO Products
VALUES
    (1, 'Milk'),
    (2, 'Potato'),
    (3, 'Burger');


INSERT INTO Categories
VALUES
    (1, 'Confectionery'),
    (2, 'DairyProduce'),
    (3, 'Meet');

CREATE TABLE  ProductCategories (
    ProductId INT FOREIGN KEY REFERENCES Products(Id),
    CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
    PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
    (1, 1),
    (2, 1),
    (3, 3);

SELECT P."CategorieName", C."CategorieName"
FROM Products P

LEFT JOIN ProductCategories PC
    ON P.Id = PC.ProductId
LEFT JOIN Categories C
    ON PC.CategoryId = C.Id;