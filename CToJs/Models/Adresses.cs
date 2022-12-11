using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CToJs.Models;

internal class Adresses
{
    public string City { get; set; }
    public string Country { get; set; }

    public Adresses(string city, string country)
    {
        City = city;
        Country = country;
    }
}
