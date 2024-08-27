namespace nilnul.num
{
	/// <summary>
	/// anything that can map one2one with Num
	/// This is placed as an extension, not subtype,  in that: for one-based ord, the ToString() of it will return 1 and it's toNum will return 0; To clear the confusion, nilnul.num.Ord shall be an ext, not a subtype of num as it changed the supertype's behavior in "ToString()"
	/// eg:
	///		one-based
	///		in different languages, for example, in chinese it's 一二三四
	///		some euphimism to name the floor of a building by avoiding ominous number such 四. so the floor is ordinalized as: 1,2,3,3A,5,6,7,8,9,10,11,12,12A,12B,15, where "13" is also avoided.
	/// </summary>
	/// <remarks>
	/// usuall starts with one;
	/// Nomanclature:
	///		ordinal means the same thing. but order is used as a relation; and ordinal is used in setTheory as a set.
	///		index means the array index, 0or1 based. but we here defer the use of index to be an integer, ranges from (-inf, inf). For example, we use BC/AD of years; Note here however 0 is not included in index. Index can contain 0 or not, but whatsoever it maps one to one to integers.
	///		"o" in numero means order. "ero" means echolon rank order
	/// </remarks>
	///	Alias:
	///		counting
	///		cardinal
	///		
	///		rank
	///			which is used in matrix.
	///		numero
	///		index
	///			which is used to index array, and can be nil;
	///		position
	///			index starts at 0; also in c# indexer can take in any integer, or even string, or any object like in dictionary or regex matched result;
	///		ord/ordinal
	///			con: starts with 0; it's a partial, not total, order; 
	///			where partial order shall be named as "Acyclic"
	///		echelon
	///		level
	///			like the storeyed building, it unfortunately starts with 0, not 1; if a building's floor is ranked 1, it's a rank; if numbered nil, it's a numero or number;
	///
	public interface IRank { }

}
