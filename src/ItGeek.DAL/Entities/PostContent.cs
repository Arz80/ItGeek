﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.DAL.Entities;

public class PostContent
{
    public int PostId { get; set; }
    public Post Post { get; set; }
    public string Title { get; set; }
    public string PostBody { get; set; }
    public string PostImage { get; set; }
    public int CommentNum { get; set; }
    public bool CommentClosed { get; set; }
}
