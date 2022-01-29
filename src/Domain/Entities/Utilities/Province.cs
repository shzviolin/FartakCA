using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;

namespace FartakCA.Domain.Entities.Utilities;

public class Province:ExtendedEntity
{
    public string Title { get; set; }
    public string Code { get; set; }

    #region navigation properties(relations)
        public IList<City> Cities { get; set; }
    #endregion

}
