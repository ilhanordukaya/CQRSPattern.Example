using CQRSPattern.Example.Manual_CQRS.Queries.Requests;
using CQRSPattern.Example.Manual_CQRS.Queries.Responses;
using CQRSPattern.Example.Modals;

namespace CQRSPattern.Example.Manual_CQRS.Handlers.QueryHandlers
{
	public class GetAllProductQueryHandler
	{
		public List<GetAllProductQueryResponse> GetAllProduct(GetAllProductQueryRequest request)
		{
			return ApplicationDbContext.ProductList.Select(p => new GetAllProductQueryResponse
			{
				Id = p.Id,
				CreateTime = p.CreateTime,
				Name = p.Name,
				Price = p.Price,
				Quantity = p.Quantity,
			}).ToList();
		}
	}
}
