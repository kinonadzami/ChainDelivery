using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChainDelivery.DAL.Entities
{
    public class Carrier
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Company { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
