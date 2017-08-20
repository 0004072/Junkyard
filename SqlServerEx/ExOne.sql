CREATE DATABASE db_junkyard;

CREATE TABLE tbl_emp
( emp_id INT NOT NULL,
  emp_lname VARCHAR(50) NOT NULL,
  emp_fname VARCHAR(50),
  emp_sal MONEY
);

INSERT INTO tbl_emp(emp_id, emp_lname, emp_fname, emp_sal)
VALUES (1, 'Doe', 'John', 50000),
(2, 'Smith', 'John', 65000),
(3, 'Doe', 'Jane', 45000),
(4, 'Bloggs', 'Anne', 75000),
(5, 'Higgs', 'Emily', 35000);