using nilnul.num._bound;
using nilnul.num.co.be_.lt.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.bound_
{

	/// <summary>
	/// eg:
	///		[0,255] can be rewritten as [0,256), where 256 is the count of elements contained there in. the latter notation is less error-prone.
	/// </summary>

	public class Clopen_byCount
		:
		nilnul.num.BoundI
	{
		private nilnul.NumI1 _basis;

		public nilnul.NumI1 basis
		{
			get { return _basis; }
			set { _basis = value; }
		}

		private nilnul.num_.Positive_struct _count;

		public nilnul.num_.Positive_struct count
		{
			get { return _count; }
			set { _count = value; }
		}
		public Clopen_byCount(
			nilnul.NumI1 basis
			,
nilnul.num_.Positive_struct count
		)
		{
			this._basis = basis;
			this._count = count;

		}



		public Lower lower => new Lower(true, this._basis);

		public Upper upper => new _bound.Upper(false, this._basis+this._count);
	}
}
