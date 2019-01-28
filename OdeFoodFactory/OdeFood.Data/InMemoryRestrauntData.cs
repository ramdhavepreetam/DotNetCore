using System.Collections.Generic;
using System.Linq;
using OdeFoodFactory.Core;
namespace OdeFood.Data
{
    public class InMemoryRestrauntData : IRestraurantData
    {
      readonly  List<Restrauntent> restaurants;
        public InMemoryRestrauntData()
        {
           this.restaurants = new List<Restrauntent>()
            {
                new Restrauntent {Id = 1 , Location = "Bellevue" , Name = "Cannum Pizza" , Cusine = CuisineType.Indian},
                new Restrauntent {Id = 2 , Location = "Renton" , Name = "Dominos" , Cusine = CuisineType.Italian},
                new Restrauntent {Id = 3 , Location = "Renton" , Name = "Pizza Hut" , Cusine = CuisineType.None}

            };
        }
        public IEnumerable<Restrauntent> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
