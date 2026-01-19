CREATE TABLE Payroll
(
    PayrollID INT IDENTITY(101,1) PRIMARY KEY,
    EmployeeID INT NOT NULL,
    Month NVARCHAR(20) NOT NULL,
    Year INT NOT NULL,
    GrossSalary DECIMAL(10,2) NOT NULL,
    TotalDeduction DECIMAL(10,2) NOT NULL,
    NetSalary DECIMAL(10,2) NOT NULL,

    CONSTRAINT FK_Payroll_Employee
        FOREIGN KEY (EmployeeID)
        REFERENCES employees_info(EmployeeID)
);

CREATE TABLE SalaryManagement
(
    SM_ID INT IDENTITY(1,1) PRIMARY KEY,

    EmployeeID INT NOT NULL,

    EmpName NVARCHAR(100) NOT NULL,
    Department NVARCHAR(50) NOT NULL,
    JobTitle NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(20) NULL,

    Salary DECIMAL(10,2) NOT NULL,

    HouseRent DECIMAL(10,2) NULL DEFAULT 0,
    Medical DECIMAL(10,2) NULL DEFAULT 0,
    Transport DECIMAL(10,2) NULL DEFAULT 0,

    TotalSalary DECIMAL(10,2) NULL,

    CONSTRAINT FK_SalaryManagement_Employee
        FOREIGN KEY (EmployeeID)
        REFERENCES Employees_Info(EmployeeID)
);

select * from Users;

CREATE TABLE dbo.LeaveRequests
(
    LeaveID INT IDENTITY(1,1) NOT NULL,
    EmployeeID INT NULL,
    FromDate DATE NULL,
    ToDate DATE NULL,
    Reason NVARCHAR(200) NULL,
    Status NVARCHAR(20) NULL,

    CONSTRAINT PK_LeaveRequests PRIMARY KEY CLUSTERED (LeaveID ASC)
);
select * Employees_Info;