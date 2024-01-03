using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Book
    {
        [Key]
        public int book_id { get; set; }

        [Required]
        public string book_name { get; set; }

        [Required]
        public int stock { get; set; }

        [Required]
        public int unit_price { get; set; }

        [Required]
        public DateTime store_date { get; set; }

        [Required]
        public DateTime stockout_date { get; set; }

    }
}
