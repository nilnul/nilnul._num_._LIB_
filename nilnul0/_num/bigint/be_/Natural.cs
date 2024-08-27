using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
namespace nilnul._num.bigint.be_
{
	[Obsolete(nameof(Natural_ofIn))]
	public  class Natural:nilnul._num.bigint.BeI, nilnul._num.bigint.BeI1
		,
		_num.bigint.BeOfRefI

	{

		public bool be(BigInteger obj)
		{
			return obj >= 0;

			//throw new NotImplementedException();
		}

		public bool be(ref BigInteger val)
		{
			return val >= 0;
			//throw new NotImplementedException();
		}


		static public Natural Singleton
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Natural>.Unison;
			}
		}

		

	}
}

