using System.ComponentModel.DataAnnotations;

namespace FartakCA.Domain.Enums;

public enum PhoneTypeEnum
{
    [Display(Name = "تلفن ثابت")]
    Phone,
    [Display(Name = "موبایل")]
    Mobile,
    [Display(Name = "فاکس")]
    Fax
}
