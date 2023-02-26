using Store.api.Models;
using Store.api.Repositories.Interfaces;

namespace Store.api.Repositories
{
	public class ProductRepository : IProductRepository
	{
		public IReadOnlyCollection<Product> GetAll()
		{
			var products = new List<Product>()
			{
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Sorvete de Morango",
					Description = "Sorvete sabor Morango. Faz muito mal.",
					Price = 5,
					Image = new Uri("https://www.designi.com.br/images/preview/10820250.jpg")
				},
				new Product
				{
					Id = Guid.NewGuid(),
					Name = "Sorvete de Milho",
					Description = "Sorvete sabor Milho. Um pouco menos pior.",
					Price = 10,
					Image = new Uri("https://xtudoreceitas.com/wp-content/uploads/Sorvete-de-massa-de-Milho-Verde-500x400.jpg")
				}
			};

			return products;
		}
	}
}
