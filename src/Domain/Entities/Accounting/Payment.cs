
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace FartakCA.Domain.Entities.Accounting;

[Index(nameof(UserId),IsUnique =false)]
public class Payment : ExtendedEntity
{

    /// <summary>
    /// شماره مرجع اغاز تراکنش
    /// </summary>
    public string RetrivalRefNo { get; set; }

    /// <summary>
    /// شماره ترمینال 
    /// </summary>
    public string SystemTraceNo { get; set; }

    /// <summary>
    /// کد خطای بانکی
    /// </summary>
    public string ResCode { get; set; }

    /// <summary>
    /// توضیحات کد خطای بانکی
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// کد پیگیری پرداخت موفق
    /// </summary>
    public long RRN { get; set; }

    public bool PaymentFinished { get; set; }

    public long Amount { get; set; }

    public string BankName { get; set; }
 
    public Guid UserId { get; set; }

    /// <summary>
    /// وضعیت دادن سرویس به مشتری بعد از انجام پرداخت
    /// </summary>
    public bool CalcState { get; set; }

    /// <summary>
    /// نوع سرویس درخواستی گاربر
    /// </summary>
    public PaymentServiceTypeEnum ServiceType { get; set; }

    /// <summary>
    /// نوع پرداخت
    /// </summary>
    public PaymentTypeEnum PaymentType { get; set; }



    #region navigation properties(relations)
    public IList<MultiplexGateway> MultiplexGateways { get; set; }

    #endregion


}
