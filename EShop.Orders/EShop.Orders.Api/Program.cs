using EShop.Orders.Application;
using EShop.Orders.Infrastruture;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHandlers();
builder.Services.AddSubscribers();
builder.Services.AddMongo();
builder.Services.AddRepositoreis();
builder.Services.AddMessageBus();
builder.Services.AddConsulConfig(configuration);

builder.Services.AddHttpClient();

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

app.UseConsul();

app.Run();
