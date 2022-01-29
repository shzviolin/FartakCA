using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;

namespace FartakCA.Domain.Entities.Fartak;

public class Wallet : ExtraExtendedEntity
{
    public Guid UserId { get; set; }
    public WalletTypeEnum WalletType { get; set; }
    public long Amount { get; set; }

    #region navigation properties(relations)
    [ForeignKey(nameof(UserId))]
    public User User { get; set; }

    public IList<WalletTransaction> BankAccountPhases { get; set; }
    #endregion
}
