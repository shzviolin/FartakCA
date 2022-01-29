using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;

namespace FartakCA.Domain.Entities.Club;

public class SellerServiceDateTime : ExtendedEntity
{
    public Guid SellerId { get; set; }
    public DayOfWeekEnum DayOfWeek { get; set; }

    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }

    #region navigation properties(relations)
    [ForeignKey(nameof(SellerId))]
    public Seller Seller { get; set; }
    #endregion
}
