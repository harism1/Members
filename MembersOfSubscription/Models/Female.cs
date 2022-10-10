using System.ComponentModel.DataAnnotations;

namespace MembersOfSubscription.Models
{
    public class Female
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(12, ErrorMessage = "The field Name must have a maximum length of 12.")]
        [MinLength(2, ErrorMessage = "The field Name must have a minimum length of 2.")]
        public string Name { get; set; }
        [Required]
        [Range(5, 99)]
        public int Age { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        [Display(Name = "Favorite color")]
        public string FavColor { get; set; }
        [Display(Name = "Member since")]
        [Required]
        public DateTime MemberSince { get; set; } = DateTime.Today;
    }
}
