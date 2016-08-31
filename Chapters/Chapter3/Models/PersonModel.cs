using System.ComponentModel.DataAnnotations;
namespace Chapter3.Models
{
    public class PersonModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string Phonenumber { get; set; }
        public double Salary { get; set; }
    }
}