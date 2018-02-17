using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HairSalonAppointement.Models
{
    public class Admin
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public string Value { get; set; }
    }
}