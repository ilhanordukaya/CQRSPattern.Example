

using CQRSPattern.Example.MediatR_CQRS.Queries.Requests;
using CQRSPattern.Example.MediatR_CQRS.Queries.Responses;
using CQRSPattern.Example.Modals;
using MediatR;

namespace CQRSPattern.Example.MediatR_CQRS.Handlers.QueryHandlers
{
	public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
	{
		public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
		{
			var product = ApplicationDbContext.ProductList.FirstOrDefault(p => p.Id == request.ProductId);
			return new GetByIdProductQueryResponse
			{
				Id = product.Id,
				CreateTime = product.CreateTime,
				Name = product.Name,
				Price = product.Price,
				Quantity = product.Quantity,
			};
		}
	}
}
