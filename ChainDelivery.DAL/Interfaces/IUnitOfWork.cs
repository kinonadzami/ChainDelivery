﻿using ChainDelivery.DAL.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainDelivery.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationUserManager UserManager { get; }
        IClientManager ClientManager { get; }
        ICarrierManager CarrierManager { get; }
        IAdminManager AdminManager { get; }
        ApplicationRoleManager RoleManager { get; }
        Task SaveAsync();
    }
}
