using System.ComponentModel.DataAnnotations;

namespace FartakCA.Domain.Enums;

public enum DayOfWeekEnum
{


    [Display(Name = "شنبه")]
    Saturday=1,
    [Display(Name = "یک شنبه")]
    Sunday,
    [Display(Name = "دو شنبه")]
    Monday,
    [Display(Name = "سه شنبه")]
    Tuesday,
    [Display(Name = "چهار شنبه")]
    Wednesday,
    [Display(Name = "پنج شنبه")]
    Thursday,
    [Display(Name = "جمعه")]
    Friday,
}
