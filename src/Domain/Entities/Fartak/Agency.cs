using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;

namespace FartakCA.Domain.Entities.Fartak;

public class Agency : ExtendedEntity
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public Guid AddressId { get; set; }


    #region navigation properties(relations)
    [ForeignKey(nameof(AddressId))]
    public Address Address { get; set; }

    [ForeignKey(nameof(UserId))]
    public User User { get; set; }
    #endregion

}
