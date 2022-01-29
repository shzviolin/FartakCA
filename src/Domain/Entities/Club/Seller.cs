using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace FartakCA.Domain.Entities.Club;


[Index(nameof(AgencyID),nameof(RecommenderId),nameof(UserId))]
public class Seller : ExtraExtendedEntity
{
    public string SellerIdentity { get; set; }
    public string StoreTitle { get; set; }
    public string LoctionRange { get; set; }
    public string Discription { get; set; }
    public string Discription2 { get; set; }


    public int Discount { get; set; }
    public int SpecialDiscount { get; set; }
    public string SpecialDiscountDiscription { get; set; }
    public int StairDiscount { get; set; }
    public long StairPrice { get; set; }

    public DateTime? AdminAcceptedDateTime { get; set; }

    public DateTime? AgencyAcceptedDateTime { get; set; }

    public string AdminDiscription { get; set; }
    public string GraphistDescription { get; set; }
    public GeneralActiveStateEnum AdminSituation { get; set; }
    public GeneralActiveStateEnum GraphistSituation { get; set; }
    public GeneralActiveStateEnum FartakAdminReview { get; set; }
    public ClubClassTypeEnum ClassType { get; set; }

    public bool Authorized { get; set; }

    public Guid AddressId { get; set; }
    public Guid UserId { get; set; }
    public Guid RecommenderId { get; set; }
    public Guid AgencyID { get; set; }
    public Guid ClubCategoryId { get; set; }

    #region navigation properties(relations)

    [ForeignKey(nameof(ClubCategoryId))]
    public ClubCategory ClubCategory { get; set; }
    public IList<SellerPhone> SellerPhones { get; set; }
    public IList<SellerProperty> SellerProperties { get; set; }
    public IList<SellerServiceDateTime> SellerServiceDateTimes { get; set; }
    public IList<ClubSpecialSuggestion> ClubSpecialSuggestions { get; set; }
    public IList<ClubSellerImage> ClubSellerImages { get; set; }

    #endregion
}