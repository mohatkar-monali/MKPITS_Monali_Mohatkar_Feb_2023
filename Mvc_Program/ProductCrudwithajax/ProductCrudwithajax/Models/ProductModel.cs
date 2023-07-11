using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductCrudwithajax.Models
{
    public class ProductModel
    {
       public int ProdId { get; set; }
       public string ProdName { get; set; }
       public string Category { get; set; }
       public int Quantity { get; set; }
       public int price { get; set; }
    }
}