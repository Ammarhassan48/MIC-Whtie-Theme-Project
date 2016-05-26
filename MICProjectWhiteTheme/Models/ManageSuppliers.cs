using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MICProjectWhiteTheme.Models
{
    public class ManageSuppliers
    {
        [Key]
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCompany { get; set; }
        public string SuppliersAddress { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierEmail { get; set; }
    }
}