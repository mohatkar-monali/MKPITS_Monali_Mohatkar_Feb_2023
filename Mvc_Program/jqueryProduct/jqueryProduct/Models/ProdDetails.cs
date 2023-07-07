using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jqueryProduct.Models
{
    public class ProdDetails
    {

        [Required(ErrorMessage = "Enter Category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Enter Product")]
        public string Product { get; set; }
    }
}