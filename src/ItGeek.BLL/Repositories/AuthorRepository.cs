using ItGeek.DAL.Data;
using ItGeek.DAL.Entities;
using ItGeek.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.BLL.Repositories;

public class AuthorRepository : GenericRepositoryAsync<Author>, IAuthorRepository
{
    public AuthorRepository(AppDbContext db) : base(db)
    {
    }
}
