using ProjectKapital.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectKapital.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter First Name")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter Birthday")]
        [DataType(DataType.Date)]
        public string Birthday { get; set; }
        [Required(ErrorMessage = "Please enter Gender")]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Please enter Category")]
        [Display(Name = "Category")]
        public int CustomerCategoryId { get; set; }
        [Required(ErrorMessage = "Please enter Phone Number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter Credit")]
        public int Credit { get; set; }
        public virtual CustomerCategory? CustomerCategory { get; set; }
    }

    public enum Gender
    {
        Male, Female
    }
}
