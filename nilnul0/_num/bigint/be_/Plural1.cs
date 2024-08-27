using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul._num.bigint.be_
{
	[Obsolete()]
	public class Plural1
		:

		nilnul._num.bigint.BeI1
		,
		_num.bigint.BeOfRefI
	//,
	//_num.bigint.BeI1
	{
		public bool be(ref BigInteger x) {
			return x >= 2;
		}
		public bool be(BigInteger obj)
		{
			return be(ref obj);
			//throw new NotImplementedException();
		}


		static public Plural1 Singleton
		{
			
			get
			{
				return nilnul._obj.typ_._UnisonX<Plural1>.Unison;
			}
		}


	}
}

