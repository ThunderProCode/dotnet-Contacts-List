using System.ComponentModel.DataAnnotations;

namespace ContactsManager.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The name is a required field")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Phone Number is a required field")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "The Email is a required field")]
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
