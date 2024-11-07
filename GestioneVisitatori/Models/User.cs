using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneVisitatori.Models
{
    internal class User
    {
        // OnPropertyChanged(nameof(name));
        // OnPropertyChanged(nameof(surname));
        // OnPropertyChanged(nameof(birthDay));
        // OnPropertyChanged(nameof(email));
        // OnPropertyChanged(nameof(password));
        [Required] public string Name { get; set; }
        [Required] public string Surname { get; set; }
        [Required] public DateTimeOffset BirthDay { get; set; }
        [Required] public string Email { get; set; }
        [Required] public string Password { get; set; }


    }
}
