using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeFood.Data;
using OdeFoodFactory.Core;

namespace OdeFoodFactory.Pages.Restraurants
{
    public class DetailModel : PageModel
    {
        private readonly IFoodType iFoodType;
        [TempData]
        public string Message { get; set; }
        public FoodItems FoodItems { get; set; }
        public DetailModel(IFoodType iFoodType)
        {
            this.iFoodType = iFoodType;
        }
        public IActionResult OnGet(int restaurantId)
        {
            FoodItems = iFoodType.GetById(restaurantId);
            if (FoodItems == null)
            {
                return RedirectToPage("../NoteFound");
            }
            
            return Page();
        }
    }
}