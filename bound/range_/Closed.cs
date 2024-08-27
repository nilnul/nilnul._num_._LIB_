using System;
using System.Collections;
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
	public class Closed : 
		
		nilnul.obj.Box<nilnul.num.duo.be_.le.vow.Ed>
		,
		IEnumerable<nilnul.Num>

		
	{

		/// <summary>
		/// the least one
		/// </summary>
		public Num begin
		{
			get
			{
				return this.boxed.ed.Item1;
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// how many more.
		/// </summary>
		/// <remarks>
		/// this par is interpreted as extra, not end, in that we don't need to worry whether end is no more than "begin"
		/// </remarks>
		public Num end
		{
			get
			{
				return this.boxed.ed.Item2;
				throw new NotImplementedException();
			}
		}
		public Closed(duo.be_.le.vow.Ed ed):base(ed)
		{

		}

		public Num count {
			get {
				return new nilnul.Num( end - begin+1);
			}
		}

		public Closed(Duo1 val) : this(
			new duo.be_.le.vow.Ed(
			val
				)
		)
		{

		}

		public Closed(Num begin, Num end):this(new Duo1(begin,end))
		{
		}

		public Closed(NumI begin, NumI end):this(new Duo1(begin,end))
		{
		}

		public Closed(NumI1 numI11, NumI1 numI12):this(new Num(numI11),new Num(numI12))
		{
		}

		static public implicit operator Range(Closed span) {
			return Range.CreateClose( span.begin, span.end);
		}

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public bool contain(Num x) {
			return ((Range)this).contain(x);
		}

		public bool contain(NumI x) {
			return ((Range)this).contain(x);
		}


		static public Closed CreateSingleton(Num num) {
			return new Closed(num, num);
		}

		public IEnumerator<Num> GetEnumerator()
		{
			for (var i = this.begin; i <=this.end ; i++)
			{
				yield return i;
			}
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}

		public IEnumerable<int> toInts() {
			for (var i = this.begin; i <=this.end ; i++)
			{
				yield return (int)i;
			}

		}

		public override string ToString()
		{
			return $"[{begin},{end}]";
		}
	}
}
