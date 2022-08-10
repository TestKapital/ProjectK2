using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectK.Models
{
    public class Product 
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
        
    }
}
