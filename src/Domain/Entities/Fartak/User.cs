using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;

namespace FartakCA.Domain.Entities.Fartak;

public class User:ExtraExtendedEntity
{
    public string FirstName { get; set; }
    public string LastName  { get; set; }
    public string NationalCode  { get; set; }
    public string Mobile { get; set; }
    public string Password { get; set; }
    public string Identity { get; set; }
    public DateTime ActiveDate { get; set; }
    public DateTime ExpireDate { get; set; }

    public int TeamCount { get; set; }



    #region navigation properties(relations)
    public IList<Address> Addresses { get; set; }
    public IList<Agency> Agencies { get; set; }
    public IList<BankAccount> BankAccunts { get; set; }
    public IList<UserParentRelation> UserParentRelationParents { get; set; }
    public IList<UserParentRelation> UserParentRelationChildren { get; set; }
    public UserInfo UserInfo { get; set; }
    public IList<UserRole> UserRoles { get; set; }
    public IList<UserContractorsScore> UserContractorsScores { get; set; }
    public IList<Wallet> Wallets { get; set; }
    #endregion
}
