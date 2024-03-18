using Microsoft.EntityFrameworkCore;
using TP3_.NET.Models;

namespace TP3_.NET.Context;
public class InfnetDbContext : DbContext
{
    public DbSet<Computador> computador { get; set; }

    public InfnetDbContext(DbContextOptions options) : base(options)
    {
        
    }
}

