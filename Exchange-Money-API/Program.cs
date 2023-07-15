using Exchange_Money_API.Data;
using Exchange_Money_API.Models;
using Exchange_Money_API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ExchangeMoneyContext>(
    options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("ExchangeMoneyConnection"));
    }
);
builder.Services.AddTransient<IService<EgresoEntity, EgresoModel>, EgresoService>();
builder.Services.AddTransient<IService<IngresoEntity, IngresoModel>, IngresoService>();
builder.Services.AddTransient<IService<DeudaEntity, DeudaModel>, DeudaService>();
builder.Services.AddTransient<IService<AhorroEntity, AhorroModel>, AhorroService>();
builder.Services.AddTransient<IService<AcreedorEntity, AcreedorModel>, AcreedorService>();
builder.Services.AddTransient<IService<MonedaEntity, MonedaModel>, MonedaService>();
builder.Services.AddTransient<IService<ObjetivoAhorroEntity, ObjetivoAhorroModel>, ObjetivoAhorroService>();
builder.Services.AddTransient<IService<RoleEntity, RoleModel>, RoleService>();
builder.Services.AddTransient<IService<SellersEntity,SellersModel>,  SellersService>();
builder.Services.AddTransient<IService<TipoSellerEntity, TipoSellerModel>, TipoSellerService>();
builder.Services.AddTransient<IService<TipoEntity, TipoModel>, TipoService>();
builder.Services.AddTransient<IService<UserEntity, UserModel>, UserService>();



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
