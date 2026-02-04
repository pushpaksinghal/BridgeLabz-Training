/*
	CREATE DATABASE DATABASE_name;
	USE DATABASE_name;
*/
create database School;
USE School;

-- DDL Commands

/*
	CREATE TABLE TABLE_NAME(
		Column1 DataTye [Constraints],
		Column2 DataTye [Constraints],
		Column3 DataTye [Constraints],
		...
		[table_Constraints]
	);
*/
CREATE TABLE Students(
	StudentID INT Primary Key,
	StudentName VARCHAR(100) NOT NULL,
	StudentEmail VARCHAR(200) UNIQUE,
	StudentAGE INT,
	Constraint chk_age CHECK (StudentAge>=16)
);

/*
	ALTER TABLE Table_name 
	ADD Column_name Datatype [Constraints]
*/

ALTER TABLE Students
ADD StudentPhone INT ;

/*
	ALTER TABLE Table_name
	DROP COLUMN Column_name;
*/

ALTER TABLE Students
DROP COLUMN StudentPhone;

/*
	TRUNCATE TABLE TABLE_name;
*/

TRUNCATE TABLE Students;

/*
	DROP TABLE TABLE_name;
*/
DROP TABLE Students;
