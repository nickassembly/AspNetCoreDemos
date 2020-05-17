using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClientDemoApp.Models
{
    public class OrderResultModel
    {
      public OrderModel Order { get; set; }
      public string ItemPurchased { get; set; }

   }
}
