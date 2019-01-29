using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeFood.Data;
using OdeFoodFactory.Core;

namespace OdeFoodFactory.Pages.Restraurants
{
    public class EditModel : PageModel
    {
        private readonly IFoodType iFoodType;

        public IHtmlHelper htmlHelper { get; }
        [BindProperty]
        public FoodItems FoodItems { get; set; }
        public IEnumerable<SelectListItem> spiceLevel { get; set; }
        public EditModel(IFoodType iFoodType, IHtmlHelper htmlHelper)
        {
            this.iFoodType = iFoodType;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                spiceLevel = htmlHelper.GetEnumSelectList<SpiceLevel>();
                return Page();
            }
            if (FoodItems.Id > 0)
            {
                TempData["Message"] = "The data updated sucessfully. ";
                this.FoodItems = iFoodType.Update(FoodItems);
            }
            else
            {
                iFoodType.Add(FoodItems);
                TempData["Message"] = "The data added sucessfully. ";
            }           
            iFoodType.Commit();
            return RedirectToPage("./Detail", new { restaurantID = FoodItems.Id });
            
        }
        public IActionResult OnGet(int? restaurantID)
        {
           
            spiceLevel = htmlHelper.GetEnumSelectList<SpiceLevel>();
            if (restaurantID != null)
            {
                FoodItems = iFoodType.GetById(restaurantID.Value);
            }
            else
            {
                FoodItems = new FoodItems();

            }
            
            if (FoodItems == null)
            {
                return RedirectToPage("../NoteFound");
            }
            return Page();
        }
    }
}