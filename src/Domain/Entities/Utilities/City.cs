using System.ComponentModel.DataAnnotations.Schema;
using FartakCA.Domain.Entities.Base;

namespace FartakCA.Domain.Entities.Utilities;

public class City:ExtendedEntity
{
    public string Title { get; set; }
    public string Code { get; set; }
    public Guid ProvinceId { get; set; }


    #region navigation properties(relations)
    [ForeignKey(nameof(ProvinceId))]
    public Province Province { get; set; }
    #endregion
}