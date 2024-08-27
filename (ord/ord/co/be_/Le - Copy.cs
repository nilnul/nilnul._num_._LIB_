using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co.be_
{
	public class Le : BeI
	{
		public bool be(Co obj)
		{
			return nilnul.num.ord.comparer.Re.Singleton.le(obj.Item1, obj.Item2);

			throw new NotImplementedException();
		}

		static public Le Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Le>.Instance;
			}
		}

	}


}
