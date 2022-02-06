using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HWShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Укажите наименование товара")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Добавьте описание")]
        public string Description { get; set; }

        [Required(ErrorMessage ="Please enter Price")]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Число должно быть положительным")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Пожалуйста укажите категорию товара")]
        public string Category { get; set; }

        [Required(ErrorMessage ="Поле не может быть пустым")]
        public int Amount { get; set; } = 0;
    }
}
