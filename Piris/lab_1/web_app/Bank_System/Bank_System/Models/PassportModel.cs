using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bank_System.Models
{
    public class PassportModel
    {
        public int Id { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string WasGivenBy { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}