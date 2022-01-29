using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FartakCA.Domain.Enums;

public enum GenderTypeEnum
{
    [Display(Name ="مذکر")]
    Male,
    [Display(Name = "مونث")]
    Female,
    [Display(Name = "سایر")]
    Other
}
