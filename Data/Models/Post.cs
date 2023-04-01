using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Forum.Constants.DataConstants.Post;

namespace Forum.Data.Models
{
    [Comment("Published Posts")]
    public class Post
    {
        [Key]
        [Comment("Posts Identifier")]
        public int Id { get; set; }


        [Comment("Post Title")]
        [Required]
        [MaxLength(TitleMaxlength)]
        public string Title { get; set; } = null!;


        [Comment("Content")]
        [Required]
        [MaxLength(ContextMaxLength)]
        public string Content { get; set; } = null!;

        [Comment("Marks record as deleted")]
        [Required]
        public bool IsDeleted { get; set; } = false;
    }
}
