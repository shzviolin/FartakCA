using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;

namespace FartakCA.Domain.Entities.Fartak;

public class UserContractorsScore : ExtendedEntity
{
    public Guid UserId { get; set; }
    public Guid ContractorsScoreId { get; set; }




    #region navigation properties(relations)
    [ForeignKey(nameof(UserId))]
    public User User { get; set; }

    [ForeignKey(nameof(ContractorsScoreId))]
    public ContractorsScore ContractorsScore { get; set; }
    #endregion

}
