using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CToJs.Models;

internal class Languages
{
    public string NativeLang { get; set; }
    public string AdditionalLang { get; set; }

    public Languages(string nativeLang,string additionalLang)
    {
        this.AdditionalLang = additionalLang;
        this.NativeLang = nativeLang;
    }
}
