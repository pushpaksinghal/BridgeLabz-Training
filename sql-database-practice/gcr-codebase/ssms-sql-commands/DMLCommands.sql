
--DML Commands

/*
	INSERT INTO TABLE_name (Column1,Column2,..) VALUES (Value1,Value2,..);
*/

INSERT INTO Students (StudentID,StudentName,StudentEmail,StudentAGE) 
VALUES (1,'pushpak','pushpak@Gmail.com',21);

INSERT INTO Students (StudentID,StudentName,StudentEmail,StudentAGE) 
VALUES  (2,'prakher','prakher@Gmail.com',23),
		(3,'ojas','ojas@Gmail.com',22),
		(4,'Abhay','abhay@gmail.com',23),
		(5,'Pradeep','praddep@gmail.com',17);

/*
	UPDATE TABLE_name SET Column_name1 = NEW_Value Where Column_name2 = Checking_Value
*/

UPDATE Students SET StudentAGE = 18 WHERE StudentID = 5;

UPDATE Students SET StudentAGE = StudentAGE-1;

/* 
	DELETE FROM TABLE_name WHERE Column_name = Value;
*/

DELETE FROM Students WHERE StudentAGE<22;

DELETE FROM Students WHERE StudentEmail = 'abhay@gmail.com';
