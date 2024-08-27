using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num_;

namespace nilnul.num.be_
{
	public class Le : 
		nilnul.obj.Box_ofIn<nilnul.Num_ofIn>
		,
		nilnul.num.Be_ofInI
	{
		public Le(in Num_ofIn val) : base(val)
		{
		}

		public Le(Num_ofIn x) : base(x)
		{
		}

		public Le(in BigInteger i ):this( Num_ofIn.Of(in i) )
		{
		}

		public Le( BigInteger i ):this( in i )
		{
		}
		public Le():this(0)
		{

		}

		public bool be(in Num_ofIn val)
		{
			return val.eeByRef <= this.boxed.eeByRef;
		}


		static public Le Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Le>.Instance;
			}
		}

	}
}
