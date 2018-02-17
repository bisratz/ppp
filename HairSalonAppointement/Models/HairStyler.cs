using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HairSalonAppointement.Models
{
    public class HairStyler
    {
        public int ID { get; set; }

        [DisplayName("Employee First Name")]
        public string FirstName { get; set; }

        [DisplayName("Employee Last Name")]
        public string LastName { get; set; }

        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        public virtual ICollection<Appointments> Appointments { get; set; }
    }
}