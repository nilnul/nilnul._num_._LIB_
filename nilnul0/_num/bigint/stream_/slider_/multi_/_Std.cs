using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

//namespace nilnul.num.stream_.slider_.geometric_._std
namespace nilnul._num.bigint.stream_.slider_.multi_

{
	/// <summary>
	/// 1,x,x^2,x^3,...
	/// </summary>
	/// <remarks>
	/// used in <see cref="num_.IRadix"/>
	/// </remarks>
	/// alias:
	///		_std
	///			avoid name conflicts with later project: nilnul.num.integer;
	public class _Std
		:stream_.SliderA
	{
		private BigInteger _x;

		public BigInteger x
		{
			get { return _x; }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// x^0 =1
		/// </remarks>
		private BigInteger _current=1;

		public override BigInteger current => _current;

		public _Std(BigInteger x)
		{
			this._x = x;
		}

		public override void moveNext()
		{
			_current *= _x;
		}
	}
}
