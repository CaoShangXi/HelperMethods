using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HelperMethods.Models
{
    [DisplayName("New Person")]
    public partial class PersonMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public int PersonId { get; set; }

        [DisplayName("First")]
        [UIHint("MulitilineText")]
        public string FirstName { get; set; }

        [DisplayName("Last")]
        public string LastName { get; set; }

        [DisplayName("Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public Address HomeAdress { get; set; }

        [DisplayName("Approved")]
        public bool IsApproved { get; set; }
        public Role Role { get; set; }
    }
}