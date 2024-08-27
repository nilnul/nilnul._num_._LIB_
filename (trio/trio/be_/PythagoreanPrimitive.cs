using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.trio.be_
{
	/// <summary>
	/// if a^2+b^2=c^2, and 
	/// </summary>
	public class PythagoreanPrimitive : BeI
	{
		public bool be(Trio obj)
		{
			return Coprime.Singleton.be(obj) && Pythagorean.Singleton.be(obj);

			//throw new NotImplementedException();
		}
	}
}
