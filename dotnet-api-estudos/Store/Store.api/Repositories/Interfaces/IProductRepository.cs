using Store.api.Models;

namespace Store.api.Repositories.Interfaces
{
	public interface IProductRepository
	{
		IReadOnlyCollection<Product> GetAll();
	}
}
