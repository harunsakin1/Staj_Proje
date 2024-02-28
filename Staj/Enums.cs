using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staj
{
    public enum OdemeTipleri
    {
        [Description("Kredi Kartı")]
        [Display(Name ="Kredi Kartı")]
        KrediKarti = 0,
        [Description("Online")]
        [Display(Name ="Online")]
        Online = 1
    }
}
