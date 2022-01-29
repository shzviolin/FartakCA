using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;

namespace FartakCA.Domain.Entities.Fartak;

public class Role : ExtraExtendedEntity
{
    public int Title { get; set; }


    #region navigation properties(relations)

    public IList<UserRole> UserRoles { get; set; }
    #endregion
}
