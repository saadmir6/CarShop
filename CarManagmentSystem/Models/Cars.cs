using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarManagmentSystem.Models
{
    public class Cars
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Miles { get; set; }

        public int Year { get; set; }

        public string Company { get; set; }

        public string Type { get; set; }

        public byte[] Image { get; set; }
    }
}