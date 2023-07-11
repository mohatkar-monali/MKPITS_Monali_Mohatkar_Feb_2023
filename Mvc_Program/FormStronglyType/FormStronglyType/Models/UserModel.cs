using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace FormStronglyType.Models
{
    public class UserModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public bool Addon { get; set; } 
    }
}