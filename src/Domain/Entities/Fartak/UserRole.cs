using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;

namespace FartakCA.Domain.Entities.Fartak;

public class UserRole : ExtraExtendedEntity
{
    public Guid RoleId { get; set; }
    public Guid UserId { get; set; }
    public Guid PhaseId { get; set; }


    #region navigation properties(relations)
    [ForeignKey(nameof(UserId))]
    public User User { get; set; }
    [ForeignKey(nameof(RoleId))]
    public Role Role { get; set; }
    #endregion


}
