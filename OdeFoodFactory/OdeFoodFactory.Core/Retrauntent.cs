using System;
using System.Collections.Generic;
using System.Text;

namespace OdeFoodFactory.Core
{
    public class Restrauntent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CuisineType Cusine { get; set; }
    }
}
