using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FartakCA.Domain.Entities.Fartak;

public class Avatar
{
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public GeneralActiveStateEnum State { get; set; }
}
