using System;
using System.Collections.Generic;
using System.Text;
using OdeFoodFactory.Core;
namespace OdeFood.Data
{
    public interface IRestraurantData
    {
        IEnumerable<Restrauntent> GetAll();
    }
}
