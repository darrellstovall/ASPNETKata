using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETKata.Models
{
    public class Person
    {
        public int Age { get; internal set; }
        public bool IsMinor { get; internal set; }
        public string Name { get; internal set; }
    }
}