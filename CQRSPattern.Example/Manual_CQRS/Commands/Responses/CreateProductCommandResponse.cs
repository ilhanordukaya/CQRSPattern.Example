namespace CQRSPattern.Example.Manual_CQRS.Commands.Responses
{
	public class CreateProductCommandResponse
	{
        public bool IsSucces { get; set; }
        public Guid ProductId { get; set; }
    }
}
