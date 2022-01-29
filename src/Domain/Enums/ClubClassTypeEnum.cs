using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FartakCA.Domain.Enums;

public enum ClubClassTypeEnum
{
    [Display(Name = "برند درجه 1")]
    Brand1 = 1,
    [Display(Name = "برند درجه 2")]
    Brand2 = 2,
    [Display(Name = "واحد بزرگ و پرمخاطب")]
    Big = 3,
    [Display(Name = "واحد معمولی")]
    Medium = 4,
    [Display(Name = "واحد کوچک و محله ای")]
    Small = 5,
}
