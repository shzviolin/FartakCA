using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace FartakCA.Domain.Entities.Fartak;

[Index(nameof(PhaseId),IsUnique =false)]
public class BankAccountPhase : ExtendedEntity
{
    public Guid BankAccountId { get; set; }
    public Guid PhaseId { get; set; }

    public Guid PhaseAccountId { get; set; }

    #region navigation properties(relations)
    [ForeignKey(nameof(BankAccountId))]
    public BankAccount BankAccount { get; set; }
    #endregion
}
