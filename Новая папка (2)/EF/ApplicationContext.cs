using ChainDelivery.DAL.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainDelivery.DAL.EF
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(string conectionString) : base(conectionString) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}