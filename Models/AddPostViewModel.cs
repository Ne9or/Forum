using System.ComponentModel.DataAnnotations;

namespace Forum.Models
{
    public class AddPostViewModel
    {
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Field {0} is mandatory!")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Field {0} must be between {2} and {1} characters long!")]
        public string Title { get; set; }

        [Display(Name = "Content")]
        [Required(ErrorMessage = "Field {0} is mandatory!")]
        [StringLength(3000, MinimumLength = 10, ErrorMessage = "Field {0} must be between {2} and {1} characters long!")]
        public string Content { get; set; }
    }
}
