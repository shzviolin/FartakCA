using System.ComponentModel.DataAnnotations;

namespace FartakCA.Domain.Enums;

public enum BankTypeEnum
{


    [Display(Name = "بانک ملی")]
    Meli = 1,
    [Display(Name = "بانک ملت")]
    Mellat = 2,
    [Display(Name = "بانک مسکن")]
    Maskan = 3,
    [Display(Name = "بانک سپه")]
    Sepah = 4,
    [Display(Name = "بانک توسعه صادرات")]
    ToseeSaderat = 5,
    [Display(Name = "بانک پست بانک")]
    PostBankIran = 6,
    [Display(Name = "بانک کشاورزی")]
    Keshavarzi = 7,
    [Display(Name = "بانک توسعه تعاون")]
    ToseeTavon = 8,
    [Display(Name = "بانک صنعت و معدن")]
    SanaatMadan = 9,
    [Display(Name = "بانک اقتصاد نوین")]
    EghtesadNovin = 10, 
    [Display(Name = "بانک پارسیان")]
    Parsian = 11,
    [Display(Name = "بانک کارآفرین")]
    KarAfarin = 12,
    [Display(Name = "بانک سامان")]
    Saman = 13,
    [Display(Name = "بانک سینا")]
    Sina = 14,
    [Display(Name = "بانک خاورمیانه")]
    KhavarMiane = 15,
    [Display(Name = "بانک شهر")]
    Shahr = 16,
    [Display(Name = "بانک دی")]
    Dey = 17,
    [Display(Name = "بانک صادرات")]
    Saderat = 18,
    [Display(Name = "بانک تجارت")]
    Tejarat = 19,
    [Display(Name = "بانک رفاه")]
    Refah = 20,
    [Display(Name = "بانک حکمت ایرانیان")]
    HekmatIranian = 21,
    [Display(Name = "بانک گردشگری")]
    Gardeshgari = 22,
    [Display(Name = "بانک ایران زمین")]
    IranZamin = 23,
    [Display(Name = "بانک قوامین")]
    Ghavamin = 24, 
    [Display(Name = "بانک انصار")]
    Ansar = 25,
    [Display(Name = "بانک سرمایه")]
    Sarmaye = 26,
    [Display(Name = "بانک پاسارگاد")]
    Pasargad = 27,
    [Display(Name = "بانک مهر ایران")]
    MehrIran = 28,
    [Display(Name = "بانک رسالت")]
    Resalat = 29,
    [Display(Name = "بانک آینده")]
    Ayande = 30,
    [Display(Name = "بانک ملل")]
    Melal = 31,
}
