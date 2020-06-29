using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Models
{
    //[DisplayName("New Person")]
    //public class Person
    //{
    //    [HiddenInput(DisplayValue =false)]
    //    public int PersonId { get; set; }

    //    [DisplayName("First")]
    //    [UIHint("MulitilineText")]
    //    public string FirstName { get; set; }

    //    [DisplayName("Last")]
    //    public string LastName { get; set; }

    //    [DisplayName("Birth Date")]
    //    [DataType(DataType.Date)]
    //    public DateTime BirthDate { get; set; }
    //    public Address HomeAdress { get; set; }

    //    [DisplayName("Approved")]
    //    public bool IsApproved { get; set; }
    //    public Role Role { get; set; }
    //}

    [MetadataType(typeof(PersonMetaData))]
    public partial class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Address HomeAdress { get; set; }
        public bool IsApproved { get; set; }
        public Role Role { get; set; }
    }


    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public enum Role
    {
        Admin,
        User,
        Guest,
    }
}