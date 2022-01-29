using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;

namespace FartakCA.Domain.Entities.Fartak;

public class BankAccount : ExtendedEntity
{
    public Guid UserId { get; set; }
    public string AccuntNumber { get; set; }
    public string IBAN { get; set; }
    public string CartNumber { get; set; }
    public BankTypeEnum BankType { get; set; }

    #region navigation properties(relations)
    [ForeignKey(nameof(UserId))]
    public User User { get; set; }

    public IList<BankAccountPhase> BankAccountPhases { get; set; }
    #endregion
}
