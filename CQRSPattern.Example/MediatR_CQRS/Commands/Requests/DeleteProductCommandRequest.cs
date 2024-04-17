﻿
using CQRSPattern.Example.MediatR_CQRS.Commands.Responses;
using MediatR;

namespace CQRSPattern.Example.MediatR_CQRS.Commands.Requests
{
	public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
	{
		public Guid ProductId { get; set; }
	}
}
