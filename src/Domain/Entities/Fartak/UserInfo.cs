using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;

namespace FartakCA.Domain.Entities.Fartak;

public class UserInfo:ExtraExtendedEntity
{
    public Guid UserId { get; set; }
    public string BirthCertificateNumber { get; set; }
    public string Email { get; set; }
    public GenderTypeEnum Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string FatherName { get; set; }
    public MaritalStatusEnum MaritalStatus { get; set; }
    public EducationLevelEnum EducationLevel { get; set; }
    public string RecommenderIdentity { get; set; }

    public string LatinFirstName { get; set; }
    public string LatinLastName { get; set; }
    public string LatinFatherName { get; set; }

    #region navigation properties(relations)
    [ForeignKey(nameof(UserId))]
    public User User { get; set; }
    #endregion

}
