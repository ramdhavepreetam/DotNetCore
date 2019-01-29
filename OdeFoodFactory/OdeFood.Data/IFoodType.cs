using System.Collections.Generic;
using OdeFoodFactory.Core;

namespace OdeFood.Data
{
    public interface IFoodType
    {
        IEnumerable<FoodItems> GetByName(string name);
        FoodItems GetById(int Id);
        FoodItems Update(FoodItems updateFoodItems);
        int Commit();
        FoodItems Add(FoodItems newFoodItems);
    }
}