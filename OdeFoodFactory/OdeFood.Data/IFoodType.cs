using System.Collections.Generic;
using OdeFoodFactory.Core;

namespace OdeFood.Data
{
    public interface IFoodType
    {
        IEnumerable<FoodItems> GetByName(string name);
    }
}