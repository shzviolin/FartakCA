using System.ComponentModel.DataAnnotations.Schema;
using FartakCA.Domain.Entities.Base;

namespace FartakCA.Domain.Entities.Club;

public class ClubSpecialSuggestion : ExtraExtendedEntity
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Guid SellerId { get; set; }


    #region navigation properties(relations)
    [ForeignKey(nameof(SellerId))]
    public Seller Seller { get; set; }
    #endregion
}