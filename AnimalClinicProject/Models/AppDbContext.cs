using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClinicProject.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("clinicdb")
        {

        }

        public DbSet<Client> Clients { get; set; }
    }
}
