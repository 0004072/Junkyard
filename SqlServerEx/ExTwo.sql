CREATE DATABASE db_school;

CREATE TABLE tbl_std(
	std_id INT PRIMARY KEY IDENTITY (1,1),
	std_name VARCHAR(255) NOT NULL
);

CREATE TABLE tbl_tchr(
	tchr_id INT PRIMARY KEY IDENTITY (1,1),
	tchr_name VARCHAR(255) NOT NULL
);

CREATE TABLE tbl_sub(
	sub_id INT PRIMARY KEY IDENTITY (1,1),
	sub_name VARCHAR(100) NOT NULL,
	sub_tchr INT FOREIGN KEY REFERENCES tbl_tchr(tchr_id)
);

CREATE TABLE tbl_marks(
	std_id INT FOREIGN KEY REFERENCES tbl_std(std_id),
	sub_id INT FOREIGN KEY REFERENCES tbl_sub(sub_id),
	sub_mark INT DEFAULT NULL CHECK(sub_mark >= 0 AND sub_mark <= 100)
);