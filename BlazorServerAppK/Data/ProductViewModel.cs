using ProjectK.Models;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerAppK.Data
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Product Code")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Please enter Product Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Product Price")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Please enter Product Availability")]
        public int Availability { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}
