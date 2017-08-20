CREATE TABLE tbl_person(
	p_id INT PRIMARY KEY IDENTITY(1,1),
	p_name VARCHAR(255) NOT NULL
);

CREATE TABLE tbl_country(
	c_id INT PRIMARY KEY IDENTITY(1,1),
	c_name VARCHAR(255) NOT NULL
);

CREATE TABLE tbl_citizens(
	p_id INT,
	c_id INT,
	PRIMARY KEY(p_id, c_id)
);

SELECT p.p_name, c.c_name FROM tbl_person p INNER JOIN tbl_citizens ci ON p.p_id=ci.p_id INNER JOIN tbl_country c ON c.c_id=ci.c_id;

SELECT p.p_name, c.c_name FROM tbl_person p LEFT OUTER JOIN tbl_citizens ci ON p.p_id=ci.p_id INNER JOIN tbl_country c ON c.c_id=ci.c_id;

SELECT p.p_name, c.c_name FROM tbl_person p INNER JOIN tbl_citizens ci ON p.p_id=ci.p_id RIGHT OUTER JOIN tbl_country c ON c.c_id=ci.c_id;

SELECT p.p_name, c.c_name FROM tbl_person p FULL OUTER JOIN tbl_citizens ci ON p.p_id=ci.p_id FULL OUTER JOIN tbl_country c ON c.c_id=ci.c_id;