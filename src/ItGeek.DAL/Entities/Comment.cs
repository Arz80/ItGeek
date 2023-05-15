using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.DAL.Entities;

public class Comment : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Url { get; set; }
    public string Message { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<Post> Posts { get; } = new();
}
