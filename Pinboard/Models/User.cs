using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pinboard.Models
{
    public class User
    {
        [Display(Name = "Email Id")]
        [Key]
        public string EmailID{ get; set; }

        [Display(Name = "User Handle")]
        public string UserHandle { get; set; }

        public string Password { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }   
    }
}
