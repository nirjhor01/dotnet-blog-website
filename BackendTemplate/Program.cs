using Backend.Data.Setups;
using BackendTemplate.DependencyExtensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
#region Dependency Injection for entity framework core implementation (Infrastructure)
string? connectionString = builder.Configuration.GetValue<string>("DbSettings:DbConnectionString");
builder.Services.AddPersistence(connectionString);
#endregion


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.AddSettings();
builder.AddJWTAuthentication();
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
