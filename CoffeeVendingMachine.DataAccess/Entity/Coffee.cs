using CoffeeVendingMachine.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachine.DataAccess.Entity
{
    [Table("Coffee")]
    public class CoffeeEntity
    {
        [Key]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public CoffeeEntity() { }
    }
}
