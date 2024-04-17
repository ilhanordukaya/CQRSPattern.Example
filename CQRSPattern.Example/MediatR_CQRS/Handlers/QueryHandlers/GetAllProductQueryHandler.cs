
using CQRSPattern.Example.MediatR_CQRS.Queries.Requests;
using CQRSPattern.Example.MediatR_CQRS.Queries.Responses;
using CQRSPattern.Example.Modals;
using MediatR;

namespace CQRSPattern.Example.MediatR_CQRS.Handlers.QueryHandlers
{
	public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
	{
		public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
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
