using CQRSPattern.Example.Manual_CQRS.Commands.Requests;
using CQRSPattern.Example.Manual_CQRS.Commands.Responses;
using CQRSPattern.Example.Modals;

namespace CQRSPattern.Example.Manual_CQRS.Handlers.CommandHandlers
{
	public class CreateProductCommandHandler
	{
		public CreateProductCommandResponse CreateProduct(CreateProductCommandRequest request)
		{
			var id= Guid.NewGuid();

			ApplicationDbContext.ProductList.Add
				(new ()
				{
					Id = id,
					Name=request.Name,
					CreateTime = DateTime.Now,
					Price=request.Price,
					Quantity=request.Quantity,

				});

			return new CreateProductCommandResponse
			{
				ProductId = id,
				IsSuccess=true,
			};
		}
	}
}
