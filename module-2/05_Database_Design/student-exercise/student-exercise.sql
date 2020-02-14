USE MASTER
GO
DROP DATABASE IF EXISTS Project_Organizer;
GO
CREATE DATABASE Project_Organizer;
GO

USE Project_Organizer;
GO

IF OBJECT_ID('project_employees')	IS NOT NULL DROP TABLE project_employees;
IF OBJECT_ID('projects')			IS NOT NULL DROP TABLE projects;
IF OBJECT_ID('employees')			IS NOT NULL	DROP TABLE employees;
IF OBJECT_ID('departments')			IS NOT NULL	DROP TABLE departments;

GO

CREATE TABLE employees
(
	employee_id		INT	IDENTITY(1,1),
	job_title		VARCHAR(50),
	last_name		VARCHAR(50),
	first_name		VARCHAR(50),
	gender			VARCHAR(12),
	department_id	int,
	date_of_birth	DATE,
	date_of_hire	DATE,

	CONSTRAINT pk_employee_id PRIMARY KEY (employee_Id),
	CONSTRAINT ck_employee_gender CHECK (gender = 'Male' OR gender = 'Female' OR gender = 'Non-Binary')	
);

CREATE TABLE departments
(
	department_id	INT IDENTITY(1,1),
	name			VARCHAR(50)

	CONSTRAINT pk_department_id PRIMARY KEY (department_id)
);

CREATE TABLE projects
(
	project_id		INT IDENTITY(1,1),
	project_number	VARCHAR(12),
	name			VARCHAR(50),
	start_date		DATE,

	CONSTRAINT pk_project_id PRIMARY KEY (project_id)
);

CREATE TABLE project_employees
(
	project_id		int,
	employee_id		int,

	CONSTRAINT pk_project_employees PRIMARY KEY (project_id, employee_id)
);

ALTER TABLE employees ADD CONSTRAINT fk_employees_department_id
FOREIGN KEY (department_id) REFERENCES departments (department_id)

ALTER TABLE project_employees ADD CONSTRAINT fk_project_employees_employee_id
FOREIGN KEY (employee_id) REFERENCES employees (employee_id)

ALTER TABLE project_employees ADD CONSTRAINT fk_project_employees_project_id
FOREIGN KEY (project_id) REFERENCES projects (project_id)


/*
Populate the tables with data for at least four projects, three departments, and eight employees.
Make sure each project has at least one employee assigned to it, and each department has at least two employees.
*/

INSERT INTO projects	(project_number, name, start_date)
VALUES					('S-1', 'Project S1' , GETDATE()),
						('IT-1', 'Project IT1' , GETDATE()),
						('F-1', 'Project F1' , GETDATE()),
						('A-1', 'Project A1' , GETDATE());

INSERT INTO departments	(name)
VALUES					('Sales'),
						('IT'),
						('Finance'),
						('Accounting');

INSERT INTO employees	(job_title,first_name,last_name, gender, department_id, date_of_birth,date_of_hire)
VALUES					('Upper Management', 'Buddy','Smith', 'Male', 1, DATEADD(yyyy,-40,GETDATE()),GETDATE()),
						('Upper Management', 'Guy','Smith', 'Male', 2, DATEADD(yyyy,-40,GETDATE()),GETDATE()),
						('Upper Management', 'Pal','Smith', 'Male', 3, DATEADD(yyyy,-40,GETDATE()),GETDATE()),
						('Upper Management', 'Fred','Smith', 'Male', 4, DATEADD(yyyy,-40,GETDATE()),GETDATE()),
						('Upper Management', 'Jane','Smith', 'Female', 1, DATEADD(yyyy,-40,GETDATE()),GETDATE()),
						('Upper Management', 'June','Smith', 'Female', 2, DATEADD(yyyy,-40,GETDATE()),GETDATE()),
						('Upper Management', 'Judy','Smith', 'Female', 3, DATEADD(yyyy,-40,GETDATE()),GETDATE()),
						('Upper Management', 'Janet','Smith', 'Female', 4, DATEADD(yyyy,-40,GETDATE()),GETDATE());

INSERT INTO project_employees	(project_id, employee_id) 
VALUES							(1,1),
								(1,2),
								(2,3),
								(2,4),
								(3,5),
								(3,6),
								(4,7),
								(4,8);