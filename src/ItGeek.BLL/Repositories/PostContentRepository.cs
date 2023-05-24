using ItGeek.DAL.Data;
using ItGeek.DAL.Entities;
using ItGeek.DAL.Interfaces;

namespace ItGeek.BLL.Repositories;

public class PostContentRepository : GenericRepositoryAsync<PostContent>, IPostContentRepository
{
	public PostContentRepository(AppDbContext db) : base(db)
	{
	}
}
