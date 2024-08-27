using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
namespace nilnul._num.bigint.be_
{
	public  class Natural_ofIn:nilnul._num.bigint.BeI, nilnul._num.bigint.BeI1
		,
		_num.bigint.BeOfInI

	{

		public bool be(BigInteger obj)
		{
			return obj >= 0;

			//throw new NotImplementedException();
		}

		public bool be(in BigInteger val)
		{
			return val >= 0;
			//throw new NotImplementedException();
		}


		static public Natural_ofIn Singleton
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Natural_ofIn>.Unison;
			}
		}



	}
}

