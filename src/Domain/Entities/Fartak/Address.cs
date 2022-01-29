using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace FartakCA.Domain.Entities.Fartak;

    [Index(nameof(CityId))]
public class Address : BaseEntity
{
    public string Title { get; set; }
    public string Tel { get; set; }
    public string PostAddress { get; set; }
    public string PostCode { get; set; }
    public string Lat { get; set; }
    public string Lng { get; set; }
    public Guid CityId { get; set; }
    public Guid UserId { get; set; }


    #region navigation properties(relations)
    [ForeignKey(nameof(UserId))]
    public User User { get; set; }
    #endregion
}
