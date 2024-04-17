using CQRSPattern.Example.Manual_CQRS.Handlers.CommandHandlers;
using CQRSPattern.Example.Manual_CQRS.Handlers.QueryHandlers;
using CQRSPattern.Example.Modals;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

#region Manual CQRS
builder.Services.AddSingleton<CreateProductCommandHandler>()
		.AddSingleton<DeleteProductCommandHandler>()
		.AddSingleton<GetAllProductQueryHandler>()
		.AddSingleton<GetByIdProductQueryHandler>();
#endregion
#region MediatR CQRS
builder.Services.AddMediatR(conf => conf.RegisterServicesFromAssembly(typeof(ApplicationDbContext).Assembly));
#endregion// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
