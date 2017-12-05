using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ChainDelivery.DAL.Entities
{
    public class Admin
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
