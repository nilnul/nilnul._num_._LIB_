using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.be_.positive
{
	public class Vow:nilnul._num.bigint.be.Vow<Positive>
		,
		nilnul._num.bigint.VowOfRefI
	{

		static public Vow Singleton
		{
			get
			{
				return nilnul.Singleton1<Vow>.Instance;
			}
		}

		public void vow(ref BigInteger obj)
		{
			if (obj==0)
			{
				throw new ArgumentOutOfRangeException($"{obj} is not positive.");
			}
			;
		}
	}
}
