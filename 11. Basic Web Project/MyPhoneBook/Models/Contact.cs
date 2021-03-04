using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhoneBook.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Полето {0} е задължително!")]
        [Display(Name="Име")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Полето {0} е задължително!")]
        [StringLength(15, MinimumLength =5,ErrorMessage ="Дължината на полето {0} трябва да е между {2} и {1}.")]
        [Display(Name="Номер")]
        public string Number { get; set; }
    }
}
