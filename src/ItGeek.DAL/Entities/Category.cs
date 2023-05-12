﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.DAL.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public string Discription { get; set; }
    public string Slug { get; set; }
    public string CategoryImage { get; set; }
    public List<PostCategory> PostCategorys { get; } = new();
}