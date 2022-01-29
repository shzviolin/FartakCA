using System.ComponentModel.DataAnnotations;

namespace FartakCA.Domain.Enums;

public enum WalletTransactionTypeEnum
{
    [Display(Name = "انتقال فرتاک به مخارج")]
    FartakToExpenses = 0, 
    [Display(Name = "انتقال درون شبکه")]
    InsideTransfer = 1, 
    [Display(Name = "انتقال تسویه حساب")]
    CheckOutTransfer = 2, 
    [Display(Name = "خرید از باشگاه")]
    ClubShopping = 3, 
    [Display(Name = "شارژ کردن اکانت خرید")]
    RechargAccunt = 4,
    [Display(Name = "تقسیم سهم معرف طرف قرارداد")]
    ClubSellerRecomender = 5,
    [Display(Name = "تقسیم سهم معرف خریدار")]
    ClubBuyerRecomender = 6,
    [Display(Name = "سهم از صندوق")]
    TotalChestShare = 7,
    [Display(Name = "خرید توکن از درآمد")]
    BuyToken_income = 8,
    [Display(Name = "جریمه نمایندگی برای عدم رسیدگی به درخواست ثبت طرف قرارداد")]
    AgencyPenalty_ForRequest = 9,
    [Display(Name = "تسویه حساب جریمه")]
    PenaltyCheckout = 10, 
    [Display(Name = "جریمه نمایندگی توسط مدیریت")]
    AgencyPenalty_ByAdmin = 11, 
    [Display(Name = "بخشش جریمه نمایندگی")]
    AgencyPenalty_Forgive = 12, 
    [Display(Name = "تسویه حساب درآمد از صندوق کل")]
    TotalChest_CheckOut = 13, 
    [Display(Name = "انتقال از کیف پول درآمد به کیف پول خرید")]
    IncomeToBuyWallet = 14, 
    [Display(Name = "انتقال از کیف پول مجازی به کیف پول درآمدی")]
    VirtualToIncome = 15, 
    [Display(Name = "خرید از فروشگاه")]
    EShopShopping = 16, 
    [Display(Name = "تراکنش در کیف پول امتیاز پیمانکاری برای تعادل باینری")]
    ContractorScore = 17, 
    [Display(Name = "پرداخت بدهی نهایی برای شهروندان فرتاک شرایطی")]
    FinalDebtPayment = 18, 
    [Display(Name = "عدم پرداخت امتیاز به پیمانکار به علت رسیدن به سقف درآمد در روز جاریه")]
    LimitContractorScore = 19, 
    [Display(Name = "مرجوع کالا به فروشگاه اینترنتی")]
    EShopReturnedShopping = 20,
    [Display(Name = "درآمد تیم")]
    LegIncome = 21,
    [Display(Name = "تقسیم سهم خرید بیمه")]
    InsuranceDivision = 21,
    [Display(Name = "تفریق امتیاز پیمانکاران برای لغو جایگاه شهروندان فرتاک")]
    VIPTerminationContractorTakeAway = 22, 
    [Display(Name = "تفریق درآمد پنل لگ برای لغو جایگاه شهروندان فرتاک")]
    VIPTerminationLegTakeAway = 23,
    [Display(Name = "تفریق کمیسیون برای لغو جایگاه شهروندان فرتاک")]
    VIPTerminationCommisionTakeAway = 24,
    [Display(Name = "درآمد حاصل از فاز های تجاری برای پیمانکاران")]
    FartakPhasesIncome = 25,
    [Display(Name = "تبدیل مبلغ درآمد از فاز های تجاری به امتیاز پیمانکاری")]
    FartakPhasesContractorScore = 26,
}
