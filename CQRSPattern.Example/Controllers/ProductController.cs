using CQRSPattern.Example.Manual_CQRS.Commands.Requests;
using CQRSPattern.Example.Manual_CQRS.Handlers.CommandHandlers;
using CQRSPattern.Example.Manual_CQRS.Handlers.QueryHandlers;
using CQRSPattern.Example.Manual_CQRS.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSPattern.Example.Controllers
{

	[Route("api/[controller]")]
	[ApiController]

	#region Manual CQRS
	//public class ProductsController(CreateProductCommandHandler createProductCommandHandler, DeleteProductCommandHandler deleteProductCommandHandler, GetAllProductQueryHandler getAllProductQueryHandler, GetByIdProductQueryHandler getByIdProductQueryHandler) : ControllerBase
	//{
	//    [HttpGet]
	//    public IActionResult Get([FromQuery] GetAllProductQueryRequest request)
	//        => Ok(getAllProductQueryHandler.GetAllProduct(request));

	//    [HttpGet("{ProductId}")]
	//    public IActionResult Get([FromRoute] GetByIdProductQueryRequest request)
	//        => Ok(getByIdProductQueryHandler.GetByIdProduct(request));

	//    [HttpPost]
	//    public IActionResult Post([FromBody] CreateProductCommandRequest request)
	//        => Ok(createProductCommandHandler.CreateProduct(request));

	//    [HttpDelete("{ProductId}")]
	//    public IActionResult Delete([FromRoute] DeleteProductCommandRequest request)
	//        => Ok(deleteProductCommandHandler.DeleteProduct(request));
	//} 
	#endregion
	#region MediatR CQRS
	public class ProductsController(IMediator mediator) : ControllerBase
	{
		[HttpGet]
		public IActionResult Get([FromQuery] GetAllProductQueryRequest request)
			=> Ok(mediator.Send(request));

		[HttpGet("{ProductId}")]
		public IActionResult Get([FromRoute] GetByIdProductQueryRequest request)
			=> Ok(mediator.Send(request));

		[HttpPost]
		public IActionResult Post([FromBody] CreateProductCommandRequest request)
			=> Ok(mediator.Send(request));

		[HttpDelete("{ProductId}")]
		public IActionResult Delete([FromRoute] DeleteProductCommandRequest request)
			=> Ok(mediator.Send(request));
	}
	#endregion
}
