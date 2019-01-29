using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OdeFoodFactory.Core
{
    public class FoodItems
    {
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Name { get; set; }        
        public SpiceLevel SpiceLevel { get; set; }
        [Required]
        [StringLength(50)]
        public string FoodType { get; set; }
    }
}
