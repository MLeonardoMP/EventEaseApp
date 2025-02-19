namespace EventEaseApp.Models {
    using System.ComponentModel.DataAnnotations;
    public class Registration {
        public int Id { get; set; }
        [Required (ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number.")]
        public string Phone { get; set; }
    }
}