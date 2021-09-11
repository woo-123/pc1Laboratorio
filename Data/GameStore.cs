using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore; 

namespace pc1Laboratorio.Data
{    public class ApplicationDbContext : IdentityDbContext {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        
        {
            

        }
        public DbSet<pc1Laboratorio.Models.Producto> gameStore {get; set;}
    }
}