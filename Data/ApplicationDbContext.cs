using CollabBridge.Models;
using Microsoft.EntityFrameworkCore;

namespace CollabBridge.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly ApplicationDbContext _context;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opitions) : base(opitions)
        {
        }

        public DbSet<DocumentosModel> Documentos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

    }
}
