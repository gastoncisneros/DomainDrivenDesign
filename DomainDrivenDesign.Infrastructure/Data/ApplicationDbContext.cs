using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesign.Infrastructure.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
    }
}
