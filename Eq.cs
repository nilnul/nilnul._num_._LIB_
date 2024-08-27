using nilnul.num_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{
	public class Eq : IEqualityComparer<nilnul.Num>, IEqualityComparer<nilnul.NumI>
		, IEqualityComparer<nilnul.Num1>
		, IEqualityComparer<nilnul.num_.Positive1>
		, IEqualityComparer<nilnul.NumI1>


	{
		public bool Equals(Num x, Num y)
		{
			return x.val == y.val;
			throw new NotImplementedException();
		}

		public int GetHashCode(Num obj)
		{
			return obj.val.GetHashCode();
			throw new NotImplementedException();
		}

		public bool Equals(NumI x, NumI y)
		{
			return x.toBigint() == y.toBigint();
			throw new NotImplementedException();
		}

		public int GetHashCode(NumI obj)
		{
			return obj.toBigint().GetHashCode();
			throw new NotImplementedException();
		}

		public bool Equals(Num1 x, Num1 y)
		{
			return x.en == y.en;
			throw new NotImplementedException();
		}

		public int GetHashCode(Num1 obj)
		{
			return obj.toBigint().GetHashCode();
			throw new NotImplementedException();
		}

		public bool Equals(Positive1 x, Positive1 y)
		{
			return x.en == y.en;
			throw new NotImplementedException();
		}

		public int GetHashCode(Positive1 obj)
		{
			return obj.en.GetHashCode();
			throw new NotImplementedException();
		}

		public bool Equals(NumI1 x, NumI1 y)
		{
			return x.toBigint().en == y.toBigint().en;

		}

		public int GetHashCode(NumI1 obj)
		{
			return obj.toBigint().GetHashCode();
			throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
