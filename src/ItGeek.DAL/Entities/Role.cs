using ItGeek.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.DAL.Entities;

public class Role : BaseEntity
{
    public RoleName RoleName { get; set; }

}
