using nilnul._num.bigint.be_.plural_.even.vow;
using nilnul.num_.plural.be_.prime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.plural_
{
	public interface IEven { }

	/// <summary>
	/// avoid a second check against the number stored in db
	/// </summary>
	public interface EvenI:IEven

	{
		_num.bigint.be_.plural_.even.vow.Ee_byRef integer {get;}
	}
	public class Even
		:
		_num.bigint.be_.plural_.even.vow.Ee_byRef
		,
		EvenI
		,
		nilnul._num_.asInteger_.RetRefI
	{
		public Even(ref BigInteger val) : base(ref val)
		{
		}

		//public ref BigInteger integerByRef { get {
		//		return ref base.eeByRef;
		//	} }

		public Ee_byRef integer => this;

		public ref BigInteger integerByRef => ref base.eeByRef;
	}
}
