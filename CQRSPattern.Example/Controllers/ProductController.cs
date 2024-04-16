using CQRSPattern.Example.Manual_CQRS.Commands.Requests;
using CQRSPattern.Example.Manual_CQRS.Handlers.CommandHandlers;
using CQRSPattern.Example.Manual_CQRS.Handlers.QueryHandlers;
using CQRSPattern.Example.Manual_CQRS.Queries.Requests;
using Microsoft.AspNetCore.Mvc;

namespace CQRSPattern.Example.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	
	public class ProductsController(CreateProductCommandHandler createProductCommandHandler, DeleteProductCommandHandler deleteProductCommandHandler, GetAllProductQueryHandler getAllProductQueryHandler, GetByIdProductQueryHandler getByIdProductQueryHandler) : ControllerBase
	{
		[HttpGet]
		public IActionResult Get([FromQuery] GetAllProductQueryRequest request)
			=> Ok(getAllProductQueryHandler.GetAllProduct(request));

		[HttpGet("{ProductId}")]
		public IActionResult Get([FromRoute] GetByIdProductQueryRequest request)
			=> Ok(getByIdProductQueryHandler.GetByIdProduct(request));

		[HttpPost]
		public IActionResult Post([FromBody] CreateProductCommandRequest request)
			=> Ok(createProductCommandHandler.CreateProduct(request));

		[HttpDelete("{ProductId}")]
		public IActionResult Delete([FromRoute] DeleteProductCommandRequest request)
			=> Ok(deleteProductCommandHandler.DeleteProduct(request));
	}
}
