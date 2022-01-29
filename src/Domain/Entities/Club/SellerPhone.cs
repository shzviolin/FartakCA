using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FartakCA.Domain.Entities.Club;

public class SellerPhone
{
    public Guid SellerId { get; set; }
    public string Description { get; set; }
    public string PhoneNumber { get; set; }
    public PhoneTypeEnum PhoneType { get; set; }
    public bool IsDefault { get; set; }
    public DateTime SmsStartTime { get; set; }
    public DateTime SmsEndTime { get; set; }




    #region navigation properties(relations)
    [ForeignKey(nameof(SellerId))]
    public Seller Seller { get; set; }
    #endregion
}
