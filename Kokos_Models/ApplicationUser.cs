using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kokos_Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "Это обязательное поле для заполнения")]
        public string FullName { get; set; }
        
        [NotMapped]
        public string StreetAddress{ get; set; }
        [NotMapped]
        public string City { get; set; }
        [NotMapped]
        public string Region { get; set; }
        [NotMapped]
        public string PostalCode { get; set; }

    }
}
