SELECT TOP(emp_sal) AS 'Highest Salary' FROM tbl_emp;
SELECT MIN(emp_sal) AS 'Lowest Salary' FROM tbl_emp;
SELECT MAX(emp_sal) AS 'Highest Salary' FROM tbl_emp;
SELECT AVG(emp_sal) AS 'Average Salary' FROM tbl_emp;
SELECT COUNT(emp_id) AS '# of Employees' FROM tbl_emp;
SELECT sum(emp_sal) AS 'Total Salary' FROM tbl_emp;
SELECT emp_name AS 'Names' FROM tbl_emp WHERE emp_name LIKE '%Doe';
SELECT emp_name AS 'Name', emp_sal AS 'Salary' FROM tbl_emp WHERE emp_id IN (1, 2, 3, 4, 5);
SELECT emp_name AS 'Name', emp_sal AS 'Salary' FROM tbl_emp WHERE emp_sal BETWEEN 40000 AND 60000; 