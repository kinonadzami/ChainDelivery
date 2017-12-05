using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainDelivery.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual Client Client { get; set; }
        public virtual Carrier Carrier { get; set; }
        public virtual Admin Admin { get; set; }
    }
}
