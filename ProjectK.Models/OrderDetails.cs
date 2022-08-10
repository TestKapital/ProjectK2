using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectK.Models
{
    public class OrderDetails
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Order Price")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Please enter Quantity")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Please enter Product Id")]
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public virtual Product? Product { get; set; }
        public virtual Order? Order { get; set; }
    }
}
