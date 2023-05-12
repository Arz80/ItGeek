using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.DAL.Entities;

public class Post : BaseEntity
{
    public string Slug { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime EditedAt { get; set; }
    public User CreatedBy { get; set; }
    public User EditedBy { get; set; }
    public List<PostAuthor> PostAuthors { get; } = new();
    public List<PostCategory> PostCategorys { get; } = new();
    public List<PostTag> PostTags { get; } = new();
    public List<PostComment> PostComments { get; } = new();

}
