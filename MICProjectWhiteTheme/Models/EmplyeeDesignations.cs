using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MICProjectWhiteTheme.Models
{
    public class EmplyeeDesignations
    {
        [Key]
        public int DesignationID { get; set; }
        public string DesginationName { get; set; }
        
    }
}