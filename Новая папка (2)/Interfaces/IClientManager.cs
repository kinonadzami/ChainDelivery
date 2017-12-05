using ChainDelivery.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainDelivery.DAL.Interfaces
{
    public interface IClientManager : IDisposable
    {
        void Create(Client item);
    }
}
