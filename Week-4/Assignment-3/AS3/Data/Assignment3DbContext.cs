using AS3.Models.UserModel;
using Microsoft.EntityFrameworkCore;
using Bogus;
using Microsoft.Identity.Client;
namespace AS3.Data
{
    public class Assignment3DbContext : DbContext
    {
        public Assignment3DbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (!Users.Any())
            {
                var userFaker = new Faker<User>()
                .RuleFor(u => u.Id, f => f.IndexFaker + 1)
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.Password, f => f.Internet.Password());

                var users = userFaker.Generate(10);
                modelBuilder.Entity<User>().HasData(users);

                var articleFaker = new Faker<Article>()
                .RuleFor(a => a.Id, f => f.IndexFaker + 1)
                .RuleFor(a => a.Title, f => f.Lorem.Sentence())
                .RuleFor(a => a.Content, f => f.Lorem.Paragraph())
                .RuleFor(a => a.AuthorId, f => f.PickRandom(users).Id);

                var articles = articleFaker.Generate(30);

                modelBuilder.Entity<Article>().HasData(articles);
                foreach (var article in articles)
                {
                    modelBuilder.Entity<Article>()
                        .HasOne(a => a.Author)
                        .WithMany()
                        .HasForeignKey(a => a.AuthorId);
                };
            }


        }
    }
}

