using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicDropDown.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        
        public int CategoryId { get; set; }
        [ForeignKey("Category") ]
        [ValidateNever]
        public Category category { get; set; }
    }
}
