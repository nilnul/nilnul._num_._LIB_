using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.duo;

namespace nilnul.num.ord.co
{
	public class Eq<TCol,TRow> : 
		IEqualityComparer<nilnul.num.ord.Co<TCol,TRow> >
		where TCol: nilnul.num.OrdI2
		where TRow :nilnul.num.OrdI2
	{
		
		public bool Equate(Co<TCol,TRow> x, Co<TCol,TRow> y)
		{
			return nilnul.num.ord.Eq2.Singleton.Equals(x.Item1, y.Item1)
				&&
nilnul.num.ord.Eq2.Singleton.Equals(x.Item2, y.Item2);

			//throw new NotImplementedException();
		}

		public bool Equate(CoI x, CoI y)
		{
			return nilnul.num.ord.Eq2.Singleton.Equals(x.component, y.component)
				&&
nilnul.num.ord.Eq2.Singleton.Equals(x.component1, y.component1);

			//throw new NotImplementedException();
		}

		public bool Equals(Co<TCol,TRow> x, Co<TCol,TRow> y)
		{
			return nilnul.num.ord.Eq2.Singleton.Equals(x.Item1, y.Item1)
				&&
nilnul.num.ord.Eq2.Singleton.Equals(x.Item2, y.Item2);

			//throw new NotImplementedException();
		}

		public int GetHashCode(Co<TCol,TRow>  obj)
		{
			return nilnul.num.ord.Eq2.Singleton.GetHashCode(obj.Item1)
				&
				nilnul.num.ord.Eq2.Singleton.GetHashCode(obj.Item2)
				;
			//throw new NotImplementedException();
		}

		static public Eq<TCol,TRow> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq<TCol,TRow>>.Instance;
			}
		}

	}

	public class Eq: Eq<nilnul.num.OrdI2,nilnul.num.OrdI2>
	{


		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}



	}
}
