using EVEMorgue.Core.Services;
using EVEMorgue.Core.ServicesContracts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddSingleton<IShipService, ShipsService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseRouting();
app.MapControllers();
app.Run();
