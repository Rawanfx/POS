using Microsoft.EntityFrameworkCore;
using POS.Infrastrucure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<POS.Application.Common.Interface.ICurrentUserService, POS.Infrastrucure.ServiceImplementation.CurrentUserService>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(POS.Application.IAssmplyMarker).Assembly));
builder.Services.AddScoped<POS.Application.Common.Interface.IUnitOfWork, POS.Infrastrucure.ServiceImplementation.UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseMiddleware<POS.API.Middleware.ExceptionHandling>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
