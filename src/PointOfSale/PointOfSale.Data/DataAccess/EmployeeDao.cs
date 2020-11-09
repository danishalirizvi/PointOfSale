using Dapper;
using PointOfSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.DataAccess
{
    public class EmployeeDao
    {
        private string _connectionstring = string.Empty;
        public EmployeeDao(string connectionString)
        {
            _connectionstring = connectionString;
        }



        //Employment Role Start
        public List<EmploymentRole> getEmploymentRoleList()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<EmploymentRole>
                    (@"SELECT * FROM EmploymentRole");
                return output?.ToList();
            }
        }

        public List<LoginUser> getAllLoginUsers()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<LoginUser>
                    (@"SELECT LoginUserID,Username,Password,IsAdmin FROM LoginUser where IsActive = 1 and IsBlocked = 0");
                return output?.ToList();
            }
        }

        public EmploymentRole getEmploymentRole(EmploymentRole role)
        {

            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.QueryFirstOrDefault<EmploymentRole>
                    (@"SELECT * FROM EmploymentRole where RoleName = @RoleName"
                    , new { RoleName = role.RoleName });
                return output;
            }
        }
        public void addEmploymentRole(EmploymentRole role)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                string query = @"INSERT INTO EmploymentRole
                                (RoleName,BasicSalary,Description,IsActive,IsBlocked) VALUES
                                (@RoleName,@BasicSalary,@Description,@IsActive,@IsBlocked)";

                con.ExecuteScalar(query, new
                {
                    RoleName = role.RoleName,
                    BasicSalary = role.BasicSalary,
                    Description = role.Description,
                    IsActive = role.IsActive,
                    IsBlocked = role.IsBlocked
                });
            }
        }

        public List<SalesPerson> getAllSalePersons()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<SalesPerson>
                    (@"SELECT * from SalesPerson WHERE IsActive = 1");
                return output?.ToList();
            }
        }

        public void deleteSalesPerson(int salesPersonID)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Execute(@"UPDATE SalesPerson SET IsActive = 0 where SalesPersonID = @SalesPersonID"
                    , new { SalesPersonID = salesPersonID });
            }
        }

        public void addSalesPerson(SalesPerson salesperson)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                string query = @"INSERT INTO SalesPerson
                                (Name,Phone,CNIC,IsActive) VALUES
                                (@Name,@Phone,@CNIC,@IsActive)";

                con.ExecuteScalar(query, new
                {
                    Name = salesperson.Name,
                    Phone = salesperson.Phone,
                    CNIC = salesperson.CNIC,
                    IsActive = 1
                });
            }
        }

        public void addLoginUser(LoginUser user)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                string query = @"INSERT INTO LoginUser(Username,Password,IsAdmin,IsActive,IsBlocked) VALUES
                                (@Username,@Password,@IsAdmin,@IsActive,@IsBlocked)";

                con.ExecuteScalar(query, new
                {
                    Username = user.Username,
                    Password = user.Password,
                    IsAdmin = user.IsAdmin,
                    IsActive = user.IsActive,
                    IsBlocked = user.IsBlocked
                });
            }
        }

        public List<SalesPerson> getAllSalePersons(string text)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<SalesPerson>
                    (@"SELECT * from SalesPerson WHERE Name LIKE '%" + text + "%' and IsActive = 1");
                return output?.ToList();
            }
        }

        public void updateSalesPerson(SalesPerson salePerson)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                string query = @"UPDATE SalesPerson SET Name = @Name, CNIC = @CNIC,
                               Phone = @Phone
                               WHERE SalesPersonID = @SalesPersonID";

                con.ExecuteScalar(query, new
                {
                    Name = salePerson.Name,
                    CNIC = salePerson.CNIC,
                    Phone = salePerson.Phone,
                    SalesPersonID = salePerson.SalesPersonID
                });
            }
        }

        public LoginUser getLoginUsers(string username)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.QueryFirstOrDefault<LoginUser>
                    (@"SELECT LoginUserID,Username,Password,IsAdmin FROM LoginUser where lower(Username) = @Username 
                    and IsActive = 1 and IsBlocked = 0"
                    , new { Username = username.ToLower() });
                return output;
            }
        }

        public void deleteEmployee(int employeeID)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Execute(@"UPDATE Employee SET IsActive = 0 where EmployeeID = @EmployeeID"
                    , new { EmployeeID = employeeID });
            }
        }

        public void deleteLoginUser(int userID)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Execute(@"UPDATE LoginUser SET IsActive = 0 where LoginUserID = @LoginUserID"
                    , new { LoginUserID = userID });
            }
        }

        //Employment Role End



        //Employment Status Start
        public List<EmploymentStatus> getEmploymentStatusList() {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<EmploymentStatus>
                    (@"SELECT * FROM EmploymentStatus");
                return output?.ToList();
            }

        }
        public EmploymentStatus getEmploymentStatus(EmploymentStatus employmentstatus)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.QueryFirstOrDefault<EmploymentStatus>
                    (@"SELECT * FROM EmploymentStatus where EmploymentStatusName = @EmploymentStatusName"
                    , new { EmploymentStatusName = employmentstatus.EmploymentStatusName });
                return output;
            }
        }
        public void addEmploymentStatus(EmploymentStatus employmentstatus)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                string query = @"INSERT INTO EmploymentStatus
                                (EmploymentStatusName,Description,IsActive,IsBlocked) VALUES
                                (@EmploymentStatusName,@Description,@IsActive,@IsBlocked)";

                con.ExecuteScalar(query, new
                {
                    EmploymentStatusName = employmentstatus.EmploymentStatusName,
                    Description = employmentstatus.Description,
                    IsActive = employmentstatus.IsActive,
                    IsBlocked = employmentstatus.IsBlocked
                });
            }
        }
        //Employment Status End
        
        

        //Work Shift Start
        public List<WorkShift> getWorkShiftList()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<WorkShift>
                    (@"SELECT * FROM WorkShift");
                return output?.ToList();
            }
        }
        public WorkShift getWorkShift(WorkShift shift)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.QueryFirstOrDefault<WorkShift>
                    (@"SELECT * FROM WorkShift where WorkShiftName = @WorkShiftName"
                    , new { WorkShiftName = shift.WorkShiftName });
                return output;
            }
        }

        public void updateLoginUser(LoginUser user)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                string query = @"UPDATE LoginUser SET Username = @Username, Password = @Password, IsAdmin = @IsAdmin
                               WHERE LoginUserID = @LoginUserID";

                con.ExecuteScalar(query, new
                {
                    Username = user.Username,
                    Password = user.Password,
                    IsAdmin = user.IsAdmin,
                });
            }
        }

        

        public void updateEmployee(Employee employee)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                string query = @"UPDATE Employee SET Name = @Name, DOB = @DOB, Gender = @Gender, FatherName = @FatherName, CNIC = @CNIC,
                               PrimaryMobile = @PrimaryMobile, SecondaryMobile = @SecondaryMobile, Email = @Email, Address = @Address, 
                               Salary = @Salary, JoiningDate = @JoiningDate, BloodGroup = @BloodGroup
                               WHERE EmployeeID = @EmployeeID";

                con.ExecuteScalar(query, new
                {
                    Name = employee.Name,
                    DOB = employee.DOB,
                    Gender = employee.Gender,
                    FatherName = employee.FatherName,
                    CNIC = employee.CNIC,
                    PrimaryMobile = employee.PrimaryMobile,
                    SecondaryMobile = employee.SecondaryMobile,
                    Email = employee.Email,
                    Address = employee.Address,
                    Salary = employee.Salary,
                    JoiningDate = employee.JoiningDate,
                    BloodGroup = employee.BloodGroup,
                    EmployeeID = employee.EmployeeID
                });
            }
        }

        public List<LoginUser> getAllLoginUsers(string text)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<LoginUser>
                    (@"SELECT LoginUserID,Username,Password,IsAdmin FROM LoginUser where Username LIKE '%" + text + "%' and IsActive = 1 and IsBlocked = 0");
                return output?.ToList();
            }
        }

        public void addWorkShift(WorkShift shift)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                string query = @"INSERT INTO WorkShift
                                (WorkShiftName,Description,ShiftStartTime,ShiftEndTime,IsActive,IsBlocked) VALUES
                                (@WorkShiftName,@Description,@ShiftStartTime,@ShiftEndTime,@IsActive,@IsBlocked)";

                con.ExecuteScalar(query, new
                {
                    WorkShiftName = shift.WorkShiftName,
                    Description = shift.Description,
                    ShiftStartTime = shift.ShiftStartTime,
                    ShiftEndTime = shift.ShiftEndTime,
                    IsActive = shift.IsActive,
                    IsBlocked = shift.IsBlocked
                });
            }
        }
        //Work Shift Start



        //add new employee
        public void addEmployee(Employee employee)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                string query = @"INSERT INTO Employee
                                (Name,DOB,Gender,FatherName,CNIC,PrimaryMobile,SecondaryMobile,Email,Address,Salary,JoiningDate,EmploymentStatusID,EmploymentRoleTypeID,WorkShiftID,LastWorkDate,IsActive,IsBlocked,BloodGroup) VALUES
                                (@Name,@DOB,@Gender,@FatherName,@CNIC,@PrimaryMobile,@SecondaryMobile,@Email,@Address,@Salary,@JoiningDate,@EmploymentStatusID,@EmploymentRoleTypeID,@WorkShiftID,@LastWorkDate,@IsActive,@IsBlocked,@BloodGroup)";

                con.ExecuteScalar(query, new
                {
                    Name = employee.Name,
                    DOB = employee.DOB,
                    Gender = employee.Gender,
                    FatherName = employee.FatherName,
                    CNIC = employee.CNIC,
                    PrimaryMobile = employee.PrimaryMobile,
                    SecondaryMobile = employee.SecondaryMobile,
                    Email = employee.Email,
                    Address = employee.Address,
                    Salary = employee.Salary,
                    JoiningDate = employee.JoiningDate,
                    EmploymentStatusID = employee.EmploymentStatusID,
                    EmploymentRoleTypeID = employee.EmploymentRoleTypeID,
                    WorkShiftID = employee.WorkShiftID,
                    LastWorkDate = employee.LastWorkDate,
                    IsActive = employee.IsActive,
                    IsBlocked = employee.IsBlocked,
                    BloodGroup = employee.BloodGroup
                });
            }
        }
        //



        //
        public List<Employee> getAllEmployees()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<Employee>
                    (@"SELECT * from Employee WHERE IsActive = 1 AND IsBlocked = 0");
                return output?.ToList();
            }
        }


        public List<Employee> getAllEmployees(string text)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<Employee>
                    (@"SELECT * from Employee WHERE Name LIKE '%" + text + "%' and IsActive = 1 AND IsBlocked = 0");
                return output?.ToList();
            }
        }
    }
}
