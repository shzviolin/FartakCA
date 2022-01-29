using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace FartakCA.Domain.Entities.Shop;


[Index(nameof(UserId))]
public class Supplier : ExtraExtendedEntity
{
    public Guid UserId { get; set; }

    public string CompanyName { get; set; }

    public string Imagelogo { get; set; }

    public string Description { get; set; }

    public string phoneNumber1 { get; set; }

    public string phoneNumber2 { get; set; }

    public string ShortKey { get; set; }


}
