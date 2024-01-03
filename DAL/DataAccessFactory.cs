using DAL.EF.Models;
using DAL.Interfaces;
//using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DataAccessFactory
    {
        public static ICrud<Admin, int, bool> AdminDataAccess()
        {
            return new AdminRepo();
        }
        public static IEmployee<Employee, int, bool> EmployeeDataAccess()
        {
            return new AdminRepo();
        }
        
        public static ICrud<Employee, int, bool> CourierDataAccess()
        {
            return new EmployeeRepo();
        }
        
       
       
        public static ICrud<User, int, bool> UserDataAccess()
        {
            return new UserRepo();
        }
        public static IAuth AuthDataAccess()
        {
            return new UserRepo();
        }
        public static ICrud<Token, int, bool> TokenDataAccess()
        {
            return new TokenRepo();
        }
        public static ICount UserCountAccess()
        {
            return new UserRepo();
        }

        public static ICrud<Book, int, bool> ItemDataAccess()
        {
            return new BookRepo();
        }
    }
}
