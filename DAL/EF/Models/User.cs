using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
     //   public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }

        public User()
        {
            Admins = new List<Admin>();
            Employees = new List<Employee>();
         //   Customers = new List<Customer>();
            Tokens = new List<Token>();
        }
    }
}
