using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;

namespace FartakCA.Domain.Entities.Utilities;

public class Phase:ExtendedEntity
{
    public string Title { get; set; }
    [Column(TypeName = "decimal(5, 2)")]
    public decimal PhisicalProgressPercent { get; set; }

}
