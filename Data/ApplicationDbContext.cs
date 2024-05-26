using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Naranj.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {}
        public DbSet<Naranj.Models.Contacto> DataContacto {get; set; }
        public DbSet<Naranj.Models.Producto> DataProducto {get; set; }
        public DbSet<Naranj.Models.Proforma> DataItemCarrito {get; set; }
        
    }
