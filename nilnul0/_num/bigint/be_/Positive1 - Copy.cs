using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
namespace nilnul._num.bigint.be_
{
	public  class Positive:nilnul._num.bigint.BeI
	{
		

		public bool be(BigInteger obj)
		{
			return obj > 0;

			//throw new NotImplementedException();
		}


		static public Positive Singleton
		{
			
			get
			{
				return nilnul._obj.typ_._UnisonX<Positive>.Unison;
			}
		}


	}
}

