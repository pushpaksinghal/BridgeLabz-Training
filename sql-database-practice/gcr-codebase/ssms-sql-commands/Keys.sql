CREATE DATABASE University_db;
USE University_db;

/*
	CREATE TABLE TABLE_NAME(
		Column1 DataTye [Constraints],
		Column2 DataTye [Constraints],
		Column3 DataTye [Constraints],
		...
		[table_Constraints]
	);
*/
CREATE TABLE Students (
    StudentID INT PRIMARY KEY,    --Primary Key          
    RollNumber INT NOT NULL,                 
    Email VARCHAR(100) NOT NULL,             
    StudentName VARCHAR(100),

    UNIQUE (RollNumber),          --Unique Key           
    UNIQUE (Email)                --Unique Key           
);

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,                
    CourseCode VARCHAR(10) NOT NULL UNIQUE,       --Candidate Key
    CourseName VARCHAR(100)
);

CREATE TABLE ENROLLMENT(
    StudentID INT,
    CourseID INT,
    EnrollmentDate DATE,

    PRIMARY KEY (StudentID, CourseID),       --Composite Key
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),    --Foreign Key
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)        --Foreign Key    
);

/*
	INSERT INTO TABLE_name (Column1,Column2,..) VALUES (Value1,Value2,..);
*/

INSERT INTO Students VALUES
(1, 101, 'alice@gmail.com', 'Alice'),
(2, 102, 'bob@gmail.com', 'Bob');

INSERT INTO Courses VALUES
(10, 'CS101', 'Computer Science'),
(20, 'MATH101', 'Mathematics');

INSERT INTO ENROLLMENT VALUES
(1, 10, '2025-01-10'),
(1, 20, '2025-01-11'),
(2, 10, '2025-01-12');
