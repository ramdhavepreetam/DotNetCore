using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeFood.Data;
using OdeFoodFactory.Core;

namespace OdeFoodFactory.Pages.Restraurants
{

    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestraurantData restraurantData;
        private readonly IFoodType foodData;
        [BindProperty(SupportsGet = true)]
        public string searchTerm { get; set; }
        public ListModel(IConfiguration config, IRestraurantData restraurantData, IFoodType FoodData)
        {
            this.config = config;
            this.restraurantData = restraurantData;
            this.foodData = FoodData;
        }
        public string Message { get; set; }
        public IEnumerable<Restrauntent> restrauntents { get; set; }
        public IEnumerable<FoodItems> foodItems { get; set; }
        public void OnGet()
        {
             
            Message = config["Message"];
            this.foodItems = this.foodData.GetByName(searchTerm);
        }

    }
}