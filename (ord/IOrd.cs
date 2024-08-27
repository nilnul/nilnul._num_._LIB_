namespace nilnul.num
{
	///
	/// <summary>
	/// a map from this to num;
	/// use this to refer to sth; act like a pointer, an address, a reference.
	/// </summary>
	/// <remarks>
	/// when ord is used in total order, different things would not have the same ord.
	/// when ord is used in partial order, different things would have the same ord. but the same ord would mean different numero in different path that connects from min to max;
	///
	/// </remarks>
	/// alias:
	///		count
	///			,count from 1.
	///		index,
	///			index from 0
	///		sort
	///			,meaning serial, whileas ord might partial order.
	///		ord
	///			,as in coordinates. ordinance; order somebody to do sth;
	///	vs:
	///		count
	///			:ord is before the item, and count is used after the item. eg: when we scoop milk power into a milk bottle, we COUNT after the powder is dumped into the bottle; 
	public interface IOrd { }

}
