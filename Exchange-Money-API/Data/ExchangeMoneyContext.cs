using Exchange_Money_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Exchange_Money_API.Data
{
    public class ExchangeMoneyContext : DbContext
    {
        public ExchangeMoneyContext(DbContextOptions<ExchangeMoneyContext> options) : base(options)
        {

        }
        public DbSet<AcreedorEntity> Acreedores { get; set; }
        public DbSet<AhorroEntity> Ahorros { get; set; }
        public DbSet<DeudaEntity> Deudas { get; set; }
        public DbSet<EgresoEntity> Egresos { get; set; }
        public DbSet<IngresoEntity> Ingresos { get; set; }
        public DbSet<MonedaEntity> Divisas { get; set; }
        public DbSet<ObjetivoAhorroEntity> Objetivos { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<SellersEntity> Sellers { get; set; }
        public DbSet<TipoEntity> Tipos { get; set; }
        public DbSet<TipoSellerEntity> TipoSellers { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }


}
