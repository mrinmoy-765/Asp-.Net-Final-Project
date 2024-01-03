using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO
{
    public class EmployeeDTO
    {
        public int employee_id { get; set; }

        [Required(ErrorMessage = "Employee name is required")]
        [StringLength(50, ErrorMessage = "Employee name must be at most 50 characters")]
        public string employee_name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters")]
        public string password { get; set; }

        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Contact must be a numeric value")]
        public string contact { get; set; }

        public string location { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Salary must be a non-negative value")]
        public int salary { get; set; }

        public int user_id { get; set; }
    }
}
