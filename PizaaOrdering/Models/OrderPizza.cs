using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizaaOrdering.Models
{
    public class OrderPizza
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="username is required")]
        [Display(Name ="UserName")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Area code is required")]
        [Display(Name = "Area Code")]
        public int AreaCode { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }
    }
}
