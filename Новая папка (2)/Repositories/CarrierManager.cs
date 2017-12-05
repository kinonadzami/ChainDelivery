using System;
using System.Collections.Generic;
using System.Text;
using ChainDelivery.DAL.EF;
using ChainDelivery.DAL.Entities;
using ChainDelivery.DAL.Interfaces;

namespace ChainDelivery.DAL.Repositories
{
    public class CarrierManager : ICarrierManager
    {
        public ApplicationContext Database { get; set; }
        public CarrierManager(ApplicationContext db)
        {
            Database = db;
        }

        public void Create(Carrier item)
        {
            Database.Carriers.Add(item);
            Database.SaveChanges();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}