--DQL Commands

/*
	SELECT * FROM table_name;
	SELECT column1, column2 FROM table_name;
	SELECT * FROM table_name WHERE condition;
	SELECT column1, column2 FROM table_name WHERE condition ORDER BY column1 DESC;
*/

SELECT * FROM Students;
SELECT StudentAGE , StudentName From Students ;
SELECT * FROM Students Where StudentAGE>20;
SELECT * FROM Students Order By StudentAGE DESC;

