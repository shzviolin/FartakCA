using System.ComponentModel.DataAnnotations;

namespace FartakCA.Domain.Enums;

public enum WalletTypeEnum
{
    [Display(Name = "موجودی مخارج")]
    Expenses = -1,
    [Display(Name = "موجودی فرتاک")]
    Fartak = 0,
    [Display(Name = "مانده حساب قابل برداشت")]
    Income = 1,
    [Display(Name = "کیف پول مجازی")]
    Virtual = 2,
    [Display(Name = "اعتبار خرید")]
    Credit = 3,
    [Display(Name = "کیف پول موقت شهروند آبی")]
    Blue = 4,
    [Display(Name = "کیف پول جریمه")]
    Penalty = 5,
    [Display(Name = "کیف پول پاداش")]
    Gift = 6,
    [Display(Name = "کیف  پول درآمد حاصل از صندوق")]
    ChestIncome = 7,
    [Display(Name = "کیف پول مغازه دارها برای تبلیغات")]
    SellersAdvertise = 8,
    [Display(Name = "امتیاز مشارکت")]
    Investment = 9,
    [Display(Name = "کیف پول خرید از فاز های تجاری")]
    Buy = 10,
    [Display(Name = "کیف پول بدهی اولیه برای شهوندان فرتاک شرایطی")]
    PreDebt = 11,
    [Display(Name = "کیف پول بدهی برای شرایط شهروندان فرتاک شرایطی")]
    FinalDebt = 12,
    [Display(Name = "مقدار امتیاز دریافتی برای پیمانکاران از ایجاد تعادل باینری")]
    Contractors = 13,
    [Display(Name = "بدهی تیم")]
    LegDebt = 14,
    [Display(Name = "بدهی تیم")]
    FartakPhases = 15,
}