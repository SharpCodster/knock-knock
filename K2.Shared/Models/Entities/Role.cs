using K2.Shared.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2.Shared.Models.Entities
{
    public class Role : BaseEntity
    {
        [Column(Order = 1)]
        public string Name { get; set; }
        [Column(Order = 2)]
        public string Descritpion { get; set; }
        [Column(Order = 3)]
        public string ClinetId { get; set; }
        [Column(Order = 4)]
        public string ClientSecret { get; set; }
        [Column(Order = 5)]
        public bool IsActive { get; set; } = true;
    }
}
}
