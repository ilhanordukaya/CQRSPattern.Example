
using CQRSPattern.Example.MediatR_CQRS.Queries.Responses;
using MediatR;

namespace CQRSPattern.Example.MediatR_CQRS.Queries.Requests
{
	public class GetAllProductQueryRequest : IRequest<List<GetAllProductQueryResponse>>
	{
	}
}
