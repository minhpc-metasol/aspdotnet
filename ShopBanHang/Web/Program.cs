using Microsoft.EntityFrameworkCore;
using Models.MetaDBContext;
using Repository.Common;
using Service.HangHoaService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
}));
builder.Services.AddScoped<IHangHoaService, HangHoaService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
// connect to MSSQL with connection string from app settings
var connectionString = builder.Configuration.GetConnectionString("MetaShop");

if(connectionString != null)
{
    builder.Services.AddDbContext<MetasolDBContext>(options =>
        options.UseSqlServer(connectionString));
}

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
