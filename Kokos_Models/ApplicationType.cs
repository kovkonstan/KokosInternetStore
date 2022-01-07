using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Kokos_Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Имя приложения")]
        [Required(ErrorMessage = "Это обязательное поле для заполнения")]
        public string Name { get; set; }
    }
}
