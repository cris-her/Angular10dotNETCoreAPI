# Angular10dotNETCoreAPI
 
Create Database EmployeeDB

create table dbo.Department(
DepartmentId int identity(1,1),
DepartmentName varchar(500)
)

select * from dbo.Department

insert into dbo.Department values
('IT')

insert into dbo.Department values
('Support')

create table dbo.Employee(
EmployeeId int identity(1,1),
EmployeeName varchar(500),
Department varchar(500),
DateOfJoining date,
PhotoFileName varchar(500)
)

insert into dbo.Employee values
('Sam', 'IT', '2020-06-01', 'anonymous.png')

select * from dbo.Employee

ng serve --open

170-9
"Data Source=.;Initial Catalog=EmployeeDB; Integrated Security=true"
dotnet .\ASSEMBLY.dll