using System.ComponentModel.DataAnnotations;

namespace FartakCA.Domain.Enums;

public enum GeneralActiveStateEnum
{
    [Display(Name = "بررسی نشده")]
    Pending=1,
    [Display(Name = "رد شده")]
    Rejected,
    [Display(Name = "تایید شده")]
    Accepted
}
