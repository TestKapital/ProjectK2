using Microsoft.EntityFrameworkCore;
using ProjectKapital.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectK.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter Order Date")]
        public string OrderDate { get; set; }
        [Required(ErrorMessage = "Please enter Customer Id")]
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

    }
}
