using Microsoft.AspNetCore.Mvc;
using Store.api.Repositories.Interfaces;

namespace Store.api.Controllers
{
	[ApiController]
	[Route("products")]
	public class ProductsController : ControllerBase
	{

		private readonly ILogger<ProductsController> _logger;
		private readonly IProductRepository _productRepository;

		public ProductsController(ILogger<ProductsController> logger, IProductRepository product)
		{
			_logger = logger;
			_productRepository = product;
		}

		[HttpGet("get-all")]
		public IActionResult GetAll()
		{
			_logger.LogInformation("Iniciando requisição para obter todos os produtos.");
			var products = _productRepository.GetAll();
			return Ok(products);
					
		}
	}
}