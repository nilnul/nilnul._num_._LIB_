namespace nilnul.num.ord_
{
	/// <summary>
	/// number one meanse index at 0.
	/// </summary>
	/// <remarks>
	/// while <see cref="ord_.IOffset"/> is from the perspective of the basis of an object, this is from the perspective of the receiving end of the object.Each incoming object would take a position of the storage place.
	/// </remarks>
	/// alias:
	///		pos:
	///			abbr of position; defined as this, pos would be unambiguous in meaning position or positive, as the two means the same concept: one based ord|rank
	///			, perspective of storage, point of sales (how many goods are going to be charged, then this number is used to calculate the receivable-how much the customer needs to pay with such formula like pos*price=pay).
	///			, per Pos, the sales person would count each commodity to evaluate its price.
	///		position
	///			means positive.
	///			used in sports.
	///			means some vacancy, such as an empty chair;  this counts how many chairs are occupied;
	///		pose
	///		posture
	///		oneBased
	///		count
	///		upto
	///		endAt
	///		terminal
	///			,terminated at count
	///		rank
	///			,when hiring, fetch how many persons from outside into the workplace
	///
	public interface IPosition:IOrd { }

}
