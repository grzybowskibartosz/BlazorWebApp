using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorWebApp.Components.Classes;

namespace BlazorWebApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<BlazorWebApp.Components.Classes.Movie> Movie { get; set; } = default!;
    }
}
