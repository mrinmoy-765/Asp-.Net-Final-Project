using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminRepo : DatabaseRepo, ICrud<Admin, int, bool>, IEmployee<Employee, int, bool>
    {
        public bool Add(Admin data)
        {
            var user = new User();
            user.user_name = data.email;
            user.password = data.password;
            user.role = "Admin";
            database.Users.Add(user);
            database.SaveChanges();
            data.user_id = user.user_id;
            database.Admins.Add(data);
            return database.SaveChanges() > 0;
        }

        public bool AddEmployee(Employee employee)
        {
            database.Employees.Add(employee);
            return database.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            database.Admins.Remove(database.Admins.Find(id));
            return database.SaveChanges() > 0;
        }

        public bool DeleteEmployee(int id)
        {
            database.Employees.Remove(database.Employees.Find(id));
            return database.SaveChanges() > 0;
        }

        public Admin Get(int id)
        {
            return database.Admins.Find(id);
        }

        public List<Admin> GetAll()
        {
            return database.Admins.ToList();
        }

        public List<Employee> GetAllEmployees()
        {
            return database.Employees.ToList();
        }

        public Employee GetEmployee(int id)
        {
            return database.Employees.Find(id);
        }

        public bool Update(Admin data)
        {
            var record = database.Admins.Find(data.admin_id);
            database.Entry(record).CurrentValues.SetValues(data);
            return database.SaveChanges() > 0;
        }
    }
}
