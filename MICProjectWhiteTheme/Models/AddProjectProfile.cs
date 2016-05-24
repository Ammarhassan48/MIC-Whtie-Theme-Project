using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MICProjectWhiteTheme.Models
{
    public class AddProjectProfile
    {
        [Key]
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public DateTime ProjectStartingDate { get; set; }
        public string ClientName { get; set; }
        public string ProjectManager { get; set; }

    }
}