using MachinePark.Persistence;
using Microsoft.AspNetCore.Cors.Infrastructure;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

var corsPolicyBuilder = new CorsPolicyBuilder();
string[] allowedOrigins = ["https://localhost:7053", "http://localhost:5253"];

var policy = corsPolicyBuilder
    .AllowAnyMethod()
    .AllowAnyHeader()
    .WithOrigins(allowedOrigins)
    .Build();

builder.Services.AddCors(options => options.AddDefaultPolicy(policy));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
