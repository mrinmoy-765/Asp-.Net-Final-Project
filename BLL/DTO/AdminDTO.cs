using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO
{
    public class AdminDTO
    {
        public int admin_id { get; set; }

        [Required(ErrorMessage = "Admin name is required")]
        [StringLength(50, ErrorMessage = "Admin name must be at most 50 characters")]
        public string admin_name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters")]
        public string password { get; set; }

        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Contact must be a numeric value")]
        public string contact { get; set; }

        public int user_id { get; set; }
    }
}
