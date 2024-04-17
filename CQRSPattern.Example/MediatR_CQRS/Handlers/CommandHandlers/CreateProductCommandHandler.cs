﻿

using CQRSPattern.Example.MediatR_CQRS.Commands.Requests;
using CQRSPattern.Example.MediatR_CQRS.Commands.Responses;
using CQRSPattern.Example.Modals;
using MediatR;

namespace CQRSPattern.Example.MediatR_CQRS.Handlers.CommandHandlers
{
	public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
	{
		public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
		{
			var id = Guid.NewGuid();
			ApplicationDbContext.ProductList.Add(new()
			{
				Id = id,
				Name = request.Name,
				CreateTime = DateTime.Now,
				Price = request.Price,
				Quantity = request.Quantity
			});

			return new CreateProductCommandResponse
			{
				ProductId = id,
				IsSuccess = true
			};
		}
	}
}
