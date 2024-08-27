using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.str.be_
{
	public class InitialOfNumSeq
		:
		nilnul.num.str.BeI
		//,
		//nilnul.num.str._be_.OfEnumeratorI
	{
		public bool be(IEnumerator<BigInteger> obj)
		{
			BigInteger ns = 0;
			while (obj.MoveNext())
			{
				if (
					obj.Current != ns++
				)
				{
					return false;
				}

			}
			return true;
			//throw new NotImplementedException();
		}


		 bool _be(IEnumerator<NumI1> obj)
		{
			var nums = new nilnul.num.stream_.Natural();
			while (obj.MoveNext())
			{
				if (
					!nilnul.num.Eq.Singleton.Equals(
					obj.Current , nums.next()
					)
				)
				{
					return false;
				}

			}
			return true;
			//throw new NotImplementedException();
		}

		public bool be(IEnumerable<BigInteger> obj)
		{
			return be(obj.GetEnumerator());

			//throw new NotImplementedException();
		}


		public bool be(IEnumerable<NumI1> obj)
		{
			return be(obj.Select(x=>x.toBigint().en));

			//throw new NotImplementedException();
		}
		public bool be(IEnumerable<Num1> obj)
		{
			return be(obj.Select(x=>x.en));

			//throw new NotImplementedException();
		}


		static public InitialOfNumSeq Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<InitialOfNumSeq>.Instance;
			}
		}



	}
}
