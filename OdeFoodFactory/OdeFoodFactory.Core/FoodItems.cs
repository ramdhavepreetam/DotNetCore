using System;
using System.Collections.Generic;
using System.Text;

namespace OdeFoodFactory.Core
{
    public class FoodItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SpiceLevel SpiceLevel { get; set; }
        public string FoodType { get; set; }
    }
}
