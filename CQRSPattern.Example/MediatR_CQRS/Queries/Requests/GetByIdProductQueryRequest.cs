
using CQRSPattern.Example.MediatR_CQRS.Queries.Responses;
using MediatR;

namespace CQRSPattern.Example.MediatR_CQRS.Queries.Requests
{
	public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
	{
		public Guid ProductId { get; set; }
	}
}
