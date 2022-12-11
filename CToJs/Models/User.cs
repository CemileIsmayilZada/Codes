using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CToJs.Models;

internal class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string  Surname { get; set; }

    public Adresses Adresses { get; set; }
    public Languages Languages { get; set; }

   

    public User(int id, string name, string surname, Adresses adresses, Languages languages)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Adresses = adresses;
        Languages = languages;
       

    }
}
