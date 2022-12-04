using System.ComponentModel.DataAnnotations;

namespace Students
{
    public partial class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Please enter a surname that is less than 40 characters")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "Please enter a first name that is less than 30 characters")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Telephone Number")]
        [StringLength(15, ErrorMessage = "Please enter a phone number that is less than 15 numbers")]
        [Phone(ErrorMessage = "Please enter a valid phone number")]

        public string TelephoneNo { get; set; }

        [StringLength(50, ErrorMessage = "Please enter an email address that is less than 50 characters")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Please enter a country that is less than 50 characters")]
        [RegularExpression("[a-zA-Z]+", ErrorMessage = "Please enter a valid country")]
        public string Country { get; set; }
    }
}
