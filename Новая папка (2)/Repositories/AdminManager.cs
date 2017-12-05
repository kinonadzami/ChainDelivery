using System;
using System.Collections.Generic;
using System.Text;
using ChainDelivery.DAL.EF;
using ChainDelivery.DAL.Entities;
using ChainDelivery.DAL.Interfaces;

namespace ChainDelivery.DAL.Repositories
{
    public class AdminManager : IAdminManager
    {
        public ApplicationContext Database { get; set; }
        public AdminManager(ApplicationContext db)
        {
            Database = db;
        }

        public void Create(Admin item)
        {
            Database.Admins.Add(item);
            Database.SaveChanges();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}