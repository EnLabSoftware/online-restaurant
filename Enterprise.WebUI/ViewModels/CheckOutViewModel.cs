using Enterprise.Logic.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Enterprise.WebUI.ViewModels
{
    public class CheckOutViewModel
    {
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Telephone is required")]
        public string ContactTelephone { get; set; }

        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "Postal Code is required")]
        public string PostalCode { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "State is required")]
        [StringLength(2, ErrorMessage = "State Max Length is 2")]
        public string State { get; set; }

        [Display(Name = "Street")]
        [Required(ErrorMessage = "Street is required")]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email address is not correct")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }

        public decimal Total { get; set; }
    }
}