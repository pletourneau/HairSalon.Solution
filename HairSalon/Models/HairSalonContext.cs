using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }

    public HairSalonContext(DbContextOptions options) : base(options) { }

    public int GetStylistCount()
    {
        return Stylists.Count();
    }
  }
}