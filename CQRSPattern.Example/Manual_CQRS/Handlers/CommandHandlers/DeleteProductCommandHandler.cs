using CQRSPattern.Example.Manual_CQRS.Commands.Requests;
using CQRSPattern.Example.Manual_CQRS.Commands.Responses;
using CQRSPattern.Example.Modals;

namespace CQRSPattern.Example.Manual_CQRS.Handlers.CommandHandlers
{
	public class DeleteProductCommandHandler
	{
		public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest request)
		{
			var product=ApplicationDbContext.ProductList.FirstOrDefault(x=>x.Id==request.ProductId);

			if (product!=null)
			{
				ApplicationDbContext.ProductList.Remove(product);
			}
			return new DeleteProductCommandResponse()
			{
				IsSuccess = true,
			};
		}
	}
}
