using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FartakCA.Domain.Enums;

public enum ImageTypeEnum 
{
    [Display(Name = "عکس پرسنلی")]
    Avatar = 0,
    [Display(Name = "عکس کارت ملی")]
    NationalCart = 1, 
    [Display(Name = "عکس شناسنامه")]
    BirthCertificateCard = 2,
    [Display(Name = "عکس احراز هویت")]
    Authentication = 4,
    [Display(Name = "سند مخارج")]
    FartakExpenses = 5,
    [Display(Name = "عکس تخفیف گروهی")]
    ClubStore = 6,
    [Display(Name = "احراز هویت فروشندگان تخفیف گروهی")]
    ClubSellerAuth = 7, 
}
