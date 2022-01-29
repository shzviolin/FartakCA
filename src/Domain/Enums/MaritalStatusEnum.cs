using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FartakCA.Domain.Enums;

public enum MaritalStatusEnum
{
    [Display(Name = "مجرد")]
    Single,
    [Display(Name = "متاهل")]
    Married,
}
