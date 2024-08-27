using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.plural
{
	public class Eq1 : IEqualityComparer<Plural1>
	{
		public bool Equals(Plural1 x, Plural1 y)
		{
			return (x.en== y.en);
			//throw new NotImplementedException();
		}

		public int GetHashCode(Plural1 obj)
		{
			return obj.en.GetHashCode();
			//throw new NotImplementedException();
		}


		static public Eq1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq1>.Instance;
			}
		}


	}
}
