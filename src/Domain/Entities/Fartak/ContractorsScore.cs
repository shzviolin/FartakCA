using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;

namespace FartakCA.Domain.Entities.Fartak;

public class ContractorsScore : BaseEntity
{
    public string Category { get; set; }
    public int Order { get; set; }
    public int Score { get; set; }
}
