using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EmployeeRepo : DatabaseRepo, ICrud<Employee, int, bool>
    {
        public bool Add(Employee data)
        {
            var user = new User();
            user.user_name = data.email;
            user.password = data.password;
            user.role = "Employee";
            database.Users.Add(user);
            database.SaveChanges();
            data.user_id = user.user_id;
            database.Employees.Add(data);
            return database.SaveChanges() > 0;
        }

        public bool Authenticate(string uname, string pass)
        {
            var data = database.Employees.FirstOrDefault(u => u.employee_name.Equals(uname) && u.password.Equals(pass));
            if (data != null)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            database.Employees.Remove(database.Employees.Find(id));
            return database.SaveChanges() > 0;
        }

        public Employee Get(int id)
        {
            return database.Employees.Find(id);
        }

        public List<Employee> GetAll()
        {
            return database.Employees.ToList();
        }

        public bool Update(Employee data)
        {
            var record = database.Employees.Find(data.employee_id);
            database.Entry(record).CurrentValues.SetValues(data);
            return database.SaveChanges() > 0;
        }
    }
}
