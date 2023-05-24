using ItGeek.DAL.Data;
using ItGeek.DAL.Entities;
using ItGeek.DAL.Interfaces;

namespace ItGeek.BLL.Repositories;

public class MenuItemRepository : GenericRepositoryAsync<MenuItem>, IMenuItemRepository
{
	public MenuItemRepository(AppDbContext db) : base(db)
	{
	}
}
