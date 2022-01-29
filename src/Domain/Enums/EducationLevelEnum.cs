using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FartakCA.Domain.Enums;

public enum EducationLevelEnum
{
    [Display(Name = "بی سواد")]
    Illiterate,
    [Display(Name = "ابتدایی")]
    ElementarySchool,
    [Display(Name = "راهنمایی")]
    MiddleSchool,
    [Display(Name = "متوسطه")]
    HighSchool,
    [Display(Name = "لیسانس")]
    BachelorDegree,
    [Display(Name = "فوق لیسانس")]
    MasterDegree,
    [Display(Name = "دکتری")]
    Phd,
    [Display(Name = "فوق دکتری")]
    PostDoc,
}
