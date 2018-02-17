using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HairSalonAppointement.Models
{
    public class Appointments 
    {
        public int ID { get; set; }
        public Customers customer { get; set; }
        public HairStyler hairstyler { get; set; }

        [DisplayName("Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DisplayName("Time")]
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        public string Description { get; set; }

        public virtual ICollection <Customers> customers { get; set; }

    }
}