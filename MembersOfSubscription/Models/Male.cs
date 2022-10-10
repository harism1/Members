using System.ComponentModel.DataAnnotations;

namespace MembersOfSubscription.Models
{
    public class Male
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(12)]
        [MinLength(2)]
        public string Name { get; set; }
        [Range(1, 99)]
        [Required]
        public int Age { get; set; }
        [Required]
        [Range(1, 2.5)]
        [Display(Name = "Height (in meters)")]
        public double Height { get; set; }
        [Required]
        [Display(Name = "Favorite sport")]
        public string FavSport { get; set; }
        [Display(Name = "Member since")]
        [Required]
        public DateTime MemberSince { get; set; } = DateTime.Today;
    }
}
