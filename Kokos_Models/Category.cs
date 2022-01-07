using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Kokos_Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Это обязательное поле для заполнения")]
        [DisplayName("Имя категории")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Это обязательное поле для заполнения")]
        [DisplayName("Порядок отображения")]
        [Range(1, int.MaxValue, ErrorMessage = "Порядок отображения категорий должен быть больше 0")]
        public int DisplayOrder { get; set; }
    }
}
