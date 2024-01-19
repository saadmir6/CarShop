using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarManagmentSystem.Models
{
    public class StoresData
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public string AddressDetail { get; set; }

        public int Telephone { get; set; }

        public string ShowroomDays { get; set; }

        public string ShowroomHours { get; set; }

        public string ServiceDays { get; set; }

        public string ServiceHours { get; set; }  
    }
}