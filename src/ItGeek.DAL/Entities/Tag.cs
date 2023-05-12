using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.DAL.Entities;

public class Tag : BaseEntity
{
    public string Name { get; set; }
    public string Discription { get; set; }
    public string Slug { get; set; }
    public string TagImage { get; set; }
    public List<PostTag> PostTags { get; } = new();
}
