using Forum.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forum.Data.Configure
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            List<Post> posts = GetPosts();
            builder.HasData(posts);
        }

        private List<Post> GetPosts()
        {
            return new List<Post>()
            {
                new Post()
                {
                    Id = 1,
                    Title = "My first post",
                    Content = "Programming sure doesn't kill me!!!:))))"
                },
                new Post()
                {
                    Id = 2,
                    Title = "My second post",
                    Content = "It really doesn't :)))))))))"
                },
                new Post()
                {
                    Id = 3,
                    Title = "My third post",
                    Content = "I swear I am sane!!!(I need help)"
                }
            };
        }
    }
}
