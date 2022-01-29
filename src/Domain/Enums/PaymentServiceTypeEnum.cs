using System.ComponentModel.DataAnnotations;

namespace FartakCA.Domain.Enums;


public enum PaymentServiceTypeEnum
{
    //TODO: یادت باشه مقادیر سیستم قبلی رو با مقادیر جدید جایگزین کن
    #region Club
    [Display(Name = "خرید از باشگاه")]
    ClubBuy = 101,
    [Display(Name = "ارائه کالاهای مورد نیاز به فروشنده های باشگاه مشتریان")]
    CustomerService,
    #endregion

    #region Fartak
    [Display(Name = "خرید توکن")]
    FartakBuyToken = 201,
    [Display(Name = "تسویه حساب کاربر")]
    FartakCheckout,
    [Display(Name = "ارتقا سطح کاربری توسط کاربر ساده")]
    UpgradeAccunt ,
    [Display(Name = "شارژ کردن اکانت خرید")]
    RechargAccunt,
    [Display(Name = "سفارش کارت بانکی فرتاک")]
    CartBankOrder,
    [Display(Name = "خرید امتیاز مشارکت از درگاه بانکی")]
    BuyStockFRTK,
    [Display(Name = "پرداخت مبلغ کیف پول Prdebt برای فعالسازی حساب کاربری")]
    PreDebt,

    #endregion

    #region Shop
    [Display(Name = "خرید  از فروشگاه")]
    ShopBuy = 301,
    #endregion






    
}
