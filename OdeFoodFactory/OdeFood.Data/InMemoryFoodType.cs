using OdeFoodFactory.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace OdeFood.Data
{
 

    public class InMemoryFoodType : IFoodType
    {
        private readonly List<FoodItems> fooItems;

        public InMemoryFoodType()
        {
            this.fooItems = new List<FoodItems>()
            {
                new FoodItems { Id= 1 , FoodType = "Itealian" , Name =  "pasta" , SpiceLevel = SpiceLevel.Medium },
                new FoodItems { Id= 2 , FoodType = "Thai" , Name =  "MA pu Thfou" , SpiceLevel = SpiceLevel.Medium },
                new FoodItems { Id= 3 , FoodType = "India" , Name =  "PawBhaji" , SpiceLevel = SpiceLevel.Medium },
                new FoodItems { Id= 4 , FoodType = "Maxican" , Name =  "Barito" , SpiceLevel = SpiceLevel.Medium },
                new FoodItems { Id= 5 , FoodType = "Europian" , Name =  "pasta" , SpiceLevel = SpiceLevel.Medium },
                new FoodItems { Id= 6 , FoodType = "Japanees" , Name =  "Momos" , SpiceLevel = SpiceLevel.Medium }
            };
        }

        public IEnumerable<FoodItems> GetByName(string name = null)
        {
            return from f in fooItems
                   where string.IsNullOrEmpty(name) || f.Name.StartsWith(name)
                   orderby f.Name
                   select f;
        }
    }
}
