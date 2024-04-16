using CQRSPattern.Example.Manual_CQRS.Handlers.CommandHandlers;
using CQRSPattern.Example.Manual_CQRS.Handlers.QueryHandlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton<CreateProductCommandHandler>()
		.AddSingleton<DeleteProductCommandHandler>()
		.AddSingleton<GetAllProductQueryHandler>()
		.AddSingleton<GetByIdProductQueryHandler>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
