using System.ComponentModel.DataAnnotations;

namespace FartakCA.Domain.Enums;

public enum PaymentTypeEnum
{
    [Display(Name = "درگاه بانکی فرتاک")]
    FartakGateway,
    [Display(Name = "کیف پول")]
    Wallet,
    [Display(Name = "درگاه داپ اپ")]
    DaapAppGateway
}
