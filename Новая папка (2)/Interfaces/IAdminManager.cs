using ChainDelivery.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainDelivery.DAL.Interfaces
{
    public interface IAdminManager : IDisposable
    {
        void Create(Admin item);
    }
}