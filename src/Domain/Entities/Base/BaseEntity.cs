using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FartakCA.Domain.Entities.Base;

public abstract class BaseEntity : object
{
    public BaseEntity() : base()
    {
        Id = Guid.NewGuid();
        string databaseGeneratedOption;
    }



    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]

    //[Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Id))]
    public Guid Id { get; set; }
    // **********


}
