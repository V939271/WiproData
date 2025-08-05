create database task;
use task;


CREATE TABLE Department (
    DeptCode NVARCHAR(10) PRIMARY KEY,
    DeptName NVARCHAR(100)
);

CREATE TABLE Employee (
    Empno NVARCHAR(10) PRIMARY KEY,
    Ename NVARCHAR(100),
    Gender NVARCHAR(10),
    Salary MONEY,
    DeptCode NVARCHAR(10),
    FOREIGN KEY (DeptCode) REFERENCES Department(DeptCode)
);

CREATE TABLE ProjectAssignment (
    ProjCode NVARCHAR(10),
    Empno NVARCHAR(10),
    Hours INT,
    PRIMARY KEY (ProjCode, Empno),
    FOREIGN KEY (Empno) REFERENCES Employee(Empno)
);

INSERT INTO Department VALUES ('D001', 'DOtnet');
INSERT INTO Employee VALUES ('E100', 'Uday', 'Male', 88423, 'D001');
INSERT INTO ProjectAssignment VALUES ('P001', 'E100', 88);
INSERT INTO ProjectAssignment VALUES ('P123', 'E100', 111);

select * from ProjectAssignment;
select * from Employee;
select * from Department;

SELECT e.Empno, e.Ename, d.DeptCode, d.DeptName, e.Gender, e.Salary,
       p.ProjCode, p.Hours
FROM Employee e
JOIN Department d ON e.DeptCode = d.DeptCode
JOIN ProjectAssignment p ON e.Empno = p.Empno;



-- Course
CREATE TABLE Course (
    Ccode NVARCHAR(10) PRIMARY KEY,
    CourseName NVARCHAR(100),
    Duration NVARCHAR(50),
    Fee MONEY
);


-- Student
CREATE TABLE Student (
    StudentNo INT PRIMARY KEY,
    StudentName NVARCHAR(100),
    City NVARCHAR(100),
    Gender NVARCHAR(10)
);

-- Faculty
CREATE TABLE Faculty (
    FacultyCode NVARCHAR(10) PRIMARY KEY,
    FacultyName NVARCHAR(100),
    Qualification NVARCHAR(100)
);

-- Payment
CREATE TABLE Payment (
    PaymentId INT PRIMARY KEY,
    PaymentDate DATETIME
);

-- Batch
CREATE TABLE Batch (
    BatchCode NVARCHAR(10) PRIMARY KEY,
    BatchName NVARCHAR(100),
    StartDate DATE,
    EndDate DATE,
    Timing NVARCHAR(50)
);

-- Enrollment (linking table)
CREATE TABLE Enrollment (
    StudentNo INT,
    Ccode NVARCHAR(10),
    BatchCode NVARCHAR(10),
    FacultyCode NVARCHAR(10),
    PaymentId INT,
    PRIMARY KEY (StudentNo, Ccode, BatchCode),
    FOREIGN KEY (StudentNo) REFERENCES Student(StudentNo),
    FOREIGN KEY (Ccode) REFERENCES Course(Ccode),
    FOREIGN KEY (BatchCode) REFERENCES Batch(BatchCode),
    FOREIGN KEY (FacultyCode) REFERENCES Faculty(FacultyCode),
    FOREIGN KEY (PaymentId) REFERENCES Payment(PaymentId)
);

-- Student
INSERT INTO Student VALUES (101, 'Ravi', 'Hyderabad', 'Male');

-- Course
INSERT INTO Course VALUES ('C101', 'SQL Server', '30 Days', 4000);

-- Faculty
INSERT INTO Faculty VALUES ('F01', 'Ms. Anjali', 'M.Tech');

-- Payment
INSERT INTO Payment VALUES (9001, '2023-08-01');

-- Batch
INSERT INTO Batch VALUES ('B101', 'Morning Batch', '2023-08-01', '2023-08-30', '7 AM - 9 AM');

-- Enrollment
INSERT INTO Enrollment VALUES (101, 'C101', 'B101', 'F01', 9001);

SELECT * FROM Course;