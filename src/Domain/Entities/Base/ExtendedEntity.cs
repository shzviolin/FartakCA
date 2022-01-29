using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FartakCA.Domain.Entities.Base;

public abstract class ExtendedEntity : BaseEntity
{
    public ExtendedEntity() : base()
    {
        InsertDateTime = DateTime.Now;
    }


    //[Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.IsActive))]
    public bool IsActive { get; set; } = true;



    //[Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.UpdateDateTime))]
    public DateTime UpdateDateTime { get; set; }


    // **********
    //[Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.InsertDateTime))]
    public DateTime InsertDateTime { get; set; }
    // **********


    public DateTime? DeleteDateTime { get; set; }

}
