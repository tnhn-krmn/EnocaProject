using EnocaProject.Business.Abstract;
using EnocaProject.Business.Concrete;
using EnocaProject.DataAccess.Abstract;
using EnocaProject.DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICompanyDAL, EfCompanyDAL>();
builder.Services.AddScoped<ICompanyService, CompanyManager>();

builder.Services.AddScoped<IProductDAL, EfProductDAL>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<IOrderDAL, EfOrderDAL>();
builder.Services.AddScoped<IOrderService, OrderManager>();

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
