using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RPDemoApp.Pages.Orders
{
   public class CreateModel : PageModel
   {
      private readonly IFoodData _foodData;
      private readonly IOrderData _orderData;

      public List<SelectListItem> FoodItems { get; set; }

      public CreateModel(IFoodData foodData, IOrderData orderData)
      {
         _foodData = foodData;
         _orderData = orderData;
      }

      public void OnGet()
      {

      }


   }
}