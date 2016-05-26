using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MICProjectWhiteTheme.Models
{
    public class EmployeeTypes
    {
        [Key]
        public int EmplyeeID { get; set; }
        public string EmployeeType { get; set; }
       
    }
}