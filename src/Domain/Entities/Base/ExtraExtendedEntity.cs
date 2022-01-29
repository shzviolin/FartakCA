using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FartakCA.Domain.Entities.Base;

public abstract class ExtraExtendedEntity : ExtendedEntity
{
    public ExtraExtendedEntity() : base()
    {

    }

    public Guid? CreatedByUserId { get; set; }
    public Guid? ModifyedByUserId { get; set; }
}
