using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MICProjectWhiteTheme.Models
{
    public class ManageClients
    {
        [Key]
        public int ClientID { get; set; }
        public string CompanyName { get; set; }
        public string RepresentatorName { get; set; }
        public string Designation { get; set; }

    }
}