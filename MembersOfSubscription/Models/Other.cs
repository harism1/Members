using System.ComponentModel.DataAnnotations;

namespace MembersOfSubscription.Models
{
    public class Other
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(12)]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        [Range(1, 99)]
        public int Age { get; set; }
        [Required]
        [Range(5, 200)]
        [Display(Name = "Weight (in kilograms)")]
        public int Weight { get; set; }
        [Required]
        [Display(Name = "Eye color")]
        public string EyeColor { get; set; }
        [Required]
        public DateTime MemberSince { get; set; } = DateTime.Today;
    }
}
