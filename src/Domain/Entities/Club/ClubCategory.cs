using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;

namespace FartakCA.Domain.Entities.Club;

public class ClubCategory : ExtendedEntity
{
    public string Title { get; set; }
    public Guid? ParentId { get; set; }
    public bool HaveSpecialDiscount { get; set; } = false;


    //TODO: Create Fluent Api in DBContext
    #region navigation properties(relations)
    [ForeignKey(nameof(ParentId))]
    public ClubCategory ParentClubCategory { get; set; }
    public IList<ClubCategory> ChildClubCategories { get; set; }

    public IList<Seller> Sellers { get; set; }
    #endregion

}
