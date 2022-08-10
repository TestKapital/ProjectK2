using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectKapital.Models
{
    public class CustomerCategory
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Category Name")]
        public string CategoryName { get; set; }

    }


}
