using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClientDemoApp.Models
{
    public class OrderUpdateModel
    {
      public int Id { get; set; }

      [Required]
      [MaxLength(20, ErrorMessage = "You need to keep the name to a max of 20 characters")]
      [MinLength(3, ErrorMessage = "You need to enter 3 characters or more")]
      [DisplayName("Name for the order")]
      public string OrderName { get; set; }

   }
}
