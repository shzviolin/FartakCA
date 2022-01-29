using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FartakCA.Domain.Entities.Fartak;

public class UserParentRelation
{
    public Guid ChildUserId { get; set; }
    public Guid ParentUserId { get; set; }
    public int TreeLevel { get; set; }




    #region navigation properties(relations)
    [ForeignKey(nameof(ChildUserId))]
    public User ChildUser { get; set; }

    [ForeignKey(nameof(ParentUserId))]
    public User ParentUser { get; set; }
    #endregion

}
