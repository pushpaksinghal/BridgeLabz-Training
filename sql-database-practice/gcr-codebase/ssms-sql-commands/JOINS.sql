USE University_db;
--JOINS
/*
	CREATE TABLE TABLE_NAME(
		Column1 DataTye [Constraints],
		Column2 DataTye [Constraints],
		Column3 DataTye [Constraints],
		...
		[table_Constraints]
	);
*/
CREATE TABLE CATEGORIES(
	CategoriesID INT Primary Key,
	CategoriesName VARCHAR(100) Not Null
);

CREATE TABLE PRODUCTS(
	ProductID INT PRIMARY KEY,
	ProductName VARCHAR(100) Not NUll,
	CategoriesID INT 

	FOREIGN KEY (CategoriesID ) REFERENCES CATEGORIES(CategoriesID)
);
/*
	INSERT INTO TABLE_name (Column1,Column2,..) VALUES (Value1,Value2,..);
*/
INSERT INTO CATEGORIES (CategoriesID, CategoriesName) VALUES (1,'tech'),(2,'dairy'),(3,'Tools');
INSERT INTO PRODUCTS (ProductID, ProductName,CategoriesID) VALUES(001,'laptop',1),(002,'milk',2),(003,'mouse',1),(004,'hammer',3);

SELECT * FROM PRODUCTS CROSS JOIN CATEGORIES;

/*
	SELECT 
		t1.Column1,
		t1.Column2,
		t2.Column3,
		t2.Column4
	FROM Table1 AS t1
	JOIN Table2 AS t2
    ON t1.CommonColumn = t2.CommonColumn;

*/
SELECT p.ProductID,p.ProductName,p.CategoriesID,c.CategoriesName FROM PRODUCTS p INNER JOIN CATEGORIES c ON p.CategoriesID = c.CategoriesID;


SELECT p.ProductID,p.ProductName,p.CategoriesID,c.CategoriesName FROM PRODUCTS p LEFT JOIN CATEGORIES c ON p.CategoriesID = c.CategoriesID;

SELECT p.ProductID,p.ProductName,p.CategoriesID,c.CategoriesName FROM PRODUCTS p RIGHT JOIN CATEGORIES c ON p.CategoriesID = c.CategoriesID;


SELECT p.ProductID,p.ProductName,p.CategoriesID,c.CategoriesName FROM PRODUCTS p FULL OUTER JOIN CATEGORIES c ON p.CategoriesID = c.CategoriesID;

