using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    class User
    {
        [Key][Required] public string Login { get; set; }
        [Required] public string Password { get; set; }
         public string FirstName { get; set; }
         public string LastName { get; set; }
    }
}
