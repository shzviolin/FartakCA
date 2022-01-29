
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FartakCA.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace FartakCA.Domain.Entities.Accounting;

[Index(nameof(BankAccountPhaseId), IsUnique = false)]
public class MultiplexGateway : ExtendedEntity
{
	public Guid PaymentId { get; set; }
	public Guid BankAccountPhaseId { get; set; }
	public long Amount { get; set; }
	/// <summary>
	/// میشود true بعد از تایید پرداخت این فیلد
	/// </summary>
	public bool Confirmed { get; set; }


	#region navigation properties(relations)
	[ForeignKey(nameof(PaymentId))]
	public Payment Payment { get; set; }

	#endregion
}
