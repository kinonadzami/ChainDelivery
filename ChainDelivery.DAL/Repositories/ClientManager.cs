using System;
using System.Collections.Generic;
using System.Text;
using ChainDelivery.DAL.EF;
using ChainDelivery.DAL.Entities;
using ChainDelivery.DAL.Interfaces;

namespace ChainDelivery.DAL.Repositories
{
    public class ClientManager : IClientManager
    {
        public ApplicationContext Database { get; set; }
        public ClientManager(ApplicationContext db)
        {
            Database = db;
        }

        public void Create(Client item)
        {
            Database.Clients.Add(item);
            Database.SaveChanges();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
