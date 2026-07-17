using Microsoft.EntityFrameworkCore;
using SistemaControlAportesCooperativa.Infrastructure.Context; 
using SistemaControlAportesCooperativa.Infrastructure.Interfaces; 
using SistemaControlAportesCooperativa.Infrastructure.Repositories; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ISocioRepository, SocioRepository>();
builder.Services.AddScoped<IAporteRepository, AporteRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();