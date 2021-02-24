BEGIN TRANSACTION;


SELECT s.site_id, s.campground_id, s.site_number, s.max_occupancy, s.accessible, s.max_rv_length, s.utilities
FROM site s
LEFT JOIN reservation ON reservation.site_id = site.site_id
JOIN campground ON campground.campground_id = site.campground_id
WHERE park_id=2;



--created database in windows terminal

CREATE TABLE employee
(
   employee_id varchar(12),
   first_name varchar(30) NOT NULL,
   last_name varchar(30) NOT NULL,
   job_title varchar(120) NOT NULL,
   gender varchar(30) NOT NULL,
   birth_date date NOT NULL,
   hire_date date NOT NULL,
   department_id int NOT NULL,
   
   CONSTRAINT pk_employee_id PRIMARY KEY(employee_id)
);


CREATE TABLE department
(
   department_id SERIAL,
   name varchar(120),
   
   CONSTRAINT pk_department_id PRIMARY KEY(department_id)
);

ALTER TABLE employee
ADD CONSTRAINT fk_department_id FOREIGN KEY(department_id) REFERENCES department(department_id);

CREATE TABLE project
(
   project_id SERIAL,
   name varchar(120),
   start_date date,
   
   CONSTRAINT pk_project_id PRIMARY KEY(project_id)
);

CREATE TABLE project_employee
(
  project_id int,
  employee_id varchar(12),
  
  CONSTRAINT fk_project_id FOREIGN KEY(project_id) REFERENCES project(project_id),
  CONSTRAINT fk_employee_id FOREIGN KEY(employee_id) REFERENCES employee(employee_id)
);

ALTER TABLE employee
ADD CONSTRAINT check_job_title CHECK (job_title IN ('Chief Executive Officer', 'CEO', 'Chief Technology Officer', 'CTO', 'Chief Financial Officer', 'CFO', 'Vice President of Sales', 'VP of Sales', 
'Vice President of Business Development', 'VP of Business Development', 'Director of Software Development', 'Software Project Manager', 'Scrum Master', 'Business Analyst',
'Software Developer', 'Database Administrator', 'Receptionist', 'Recruiter', 'Human Resources Manager', 'HR Manager', 'HR Generalist', 'Human Resources Generalist', 'Accountant', 'Sales Associate'));


--populate the tables:

INSERT INTO project(name, start_date)
VALUES('Parking Mobile App', '2021-02-15');

INSERT INTO project(name, start_date)
VALUES('Implementation of Website Redesign', '2021-03-01');

INSERT INTO project(name, start_date)
VALUES('Source new VMS', '2021-03-15');

INSERT INTO project(name, start_date)
VALUES('Prepare Employee W-2 Paperwork', '2021-12-01');

INSERT INTO department(name) VALUES 
('Accounting'),
('Sales'),
('Business Development'),
('Information Technology'),
('Software Development'),
('Human Resources');

INSERT INTO employee(employee_id, first_name, last_name, job_title, gender, birth_date, hire_date, department_id) VALUES
('111-000-3434', 'Rachel', 'Green', 'Director of Software Development', 'female', '1982-06-25', '2010-01-07', 5),
('222-111-4646', 'Monica', 'Geller', 'CFO', 'female', '1980-12-31', '2012-06-01', 1),
('333-222-6868', 'Phoebe', 'Buffay', 'Recruiter', 'female', '1981-03-15', '2015-08-09', 6),
('444-333-7979', 'Joey', 'Tribbiani', 'VP of Sales', 'male', '1980-09-14', '2013-01-05', 2),
('555-444-8181', 'Chandler', 'Bing', 'Software Project Manager', 'male', '1982-05-15', '2014-03-15', 5),
('667-555-9292', 'Ross', 'Geller', 'HR Manager', 'male', '1981-08-17', '2014-08-12', 6),
('778-666-1313', 'Paolo', 'Fusco', 'Accountant', 'male', '1984-04-16', '2015-10-15', 1),
('889-777-2424', 'Charlie', 'Wheeler', 'Software Developer', 'female', '1984-05-12', '2021-02-15', 5),
('991-888-3535', 'Gunther', 'Tyler', 'Sales Associate', 'male', '1970-06-28', '2017-10-03', 2);

INSERT INTO project_employee(project_id, employee_id) VALUES
(1, '111-000-3434'),
(1, '889-777-2424'),
(2, '555-444-8181'),
(2, '889-777-2424'),
(3, '667-555-9292'),
(3, '333-222-6868'),
(4, '222-111-4646'),
(4, '778-666-1313');

COMMIT;
