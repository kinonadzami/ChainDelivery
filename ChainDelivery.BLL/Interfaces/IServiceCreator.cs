using System;
using System.Collections.Generic;
using System.Text;

namespace ChainDelivery.BLL.Interfaces
{
    public interface IServiceCreator
    {
        IUserService CreateUserService(string connection);
    }
}
