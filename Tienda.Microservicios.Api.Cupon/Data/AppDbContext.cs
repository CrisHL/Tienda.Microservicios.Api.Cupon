using Microsoft.EntityFrameworkCore;
using Tienda.Microservicios.Api.Cupon.Models;
namespace Tienda.Microservicios.Api.Cupon.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        {

        }

        public DbSet<Tienda.Microservicios.Api.Cupon.Models.Cupon> Cupons { get; set; }
    }
}
