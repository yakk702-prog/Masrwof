using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Masrwof.Data;

namespace Masrwof.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlite("Data Source=masrwof_design.db");

        return new AppDbContext(optionsBuilder.Options);
    }
}
