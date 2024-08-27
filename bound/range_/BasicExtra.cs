using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.range_
{
	/// <summary>
	/// from one num to another. the other num must be no more than the start one.
	/// 
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	public class BasicExtra : nilnul.obj.Box<Duo1>

		
	{
		/// <summary>
		/// the least one
		/// </summary>
		public Num basic
		{
			get
			{
				return this.boxed.Item1;
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// how many more.
		/// </summary>
		/// <remarks>
		/// this par is interpreted as extra, not end, in that we don't need to worry whether end is no more than "begin"
		/// </remarks>
		public Num extra
		{
			get
			{
				return this.boxed.Item2;
				throw new NotImplementedException();
			}
		}

		public BasicExtra(Duo1 val) : base(val)
		{

		}

		public BasicExtra(Num begin, Num extra):this(new Duo1(begin,extra))
		{
		}

		static public implicit operator Range(BasicExtra span) {
			return Range.CreateClose( span.basic, span.basic + span.extra);
		}

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public bool contain(Num x) {
			return ((Range)this).contain(x);
		}

		
	}
}
