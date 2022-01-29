using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace FartakCA.Domain.Entities.Fartak;

[Index(nameof(PaymentId), IsUnique = false)]
public class WalletTransaction : ExtraExtendedEntity
{
    public Guid WalletId { get; set; }
    public Guid PaymentId { get; set; }
    public WalletTransactionTypeEnum WalletTransactionType { get; set; }
    public long Amount { get; set; }

    #region navigation properties(relations)
    [ForeignKey(nameof(WalletId))]
    public Wallet Wallet { get; set; }
    #endregion
}
