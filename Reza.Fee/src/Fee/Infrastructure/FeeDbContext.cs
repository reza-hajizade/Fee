using Fee.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fee.Infrastructure;

public class FeeDbContext(DbContextOptions<FeeDbContext> dbContext) : DbContext(dbContext)
{
    public DbSet<Vehicle> vehicles { get; set; }
}

