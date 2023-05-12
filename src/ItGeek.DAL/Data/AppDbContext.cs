using ItGeek.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItGeek.DAL.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<AuthorsSocial> AuthorsSocials { get; set; }
    public DbSet<Category> Categories{ get; set; }
    public DbSet<Comment> Comments{ get; set; }
    public DbSet<Menu> Menus{ get; set; }
    public DbSet<MenuItem> MenuItems{ get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<PostAuthor> PostAuthors { get; set; }
    public DbSet<PostCategory> PostCategories { get; set; }
    public DbSet<PostComment> PostComments { get; set; }
    public DbSet<PostTag> PostTags { get; set; }

}
