using Microsoft.Web.Mvc.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace DataAccessLayer.Models
{
    public class RegisterModel {
        public string Name { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        //public string Type { get; set; }
        public DropDownListClass Type { get; set; }
        public string BankName { get; set; }
        public string BankAccountNumber { get; set; }
        public string Contact { get; set; }

        public string Service { get; set; }
        public string Location { get; set; }

        //public SelectList TypeOfUser { get; set; }
    }
    public class DropDownListClass
    {
        public string ValueSelected { get; set; }
        public SelectList TypeOfUser { get; set; }
    }
}
