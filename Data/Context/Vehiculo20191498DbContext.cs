using Vehiculo20191498.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Vehiculo20191498.Data.Contex;

public class Vehiculo20191498DbContext:DbContext 
{
   public Vehiculo20191498DbContext(DbContextOptions options):base(options)
    {
        
    } 
    public virtual DbSet<Vehiculo> Vehiculos{get;set;}= null!;

}
public interface Vehiculo20191498{
public DbSet<Vehiculo> Vehiculos{get;set;}
}
 


