-- Step 1: Rename old table
ALTER TABLE Employees RENAME TO Employees_old;

-- Step 2: Create new table
CREATE TABLE Employees (
    employee_id   INT PRIMARY KEY,
    first_name    VARCHAR(50) NOT NULL,
    last_name     VARCHAR(50) NOT NULL,
    department_id INT,
    FOREIGN KEY (department_id)
        REFERENCES Department(department_id)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);

-- Step 3: Copy data from old table
INSERT INTO Employees (employee_id, first_name, last_name, department_id)
SELECT employee_id, first_name, last_name, department_id
FROM Employees_old;

-- Step 4: Drop old table
DROP TABLE Employees_old;
