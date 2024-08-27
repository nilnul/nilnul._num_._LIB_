using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prime = nilnul.num.plural.be.Prime.Asserted;

namespace nilnul.num.prime.bag
{
	public class Sube : nilnul.ord.InsideA<Bag>
	{

		static public readonly Sube Instance = new Sube();
		public override bool inside(Bag x, Bag y)
		{
			return nilnul.collection.bag.rel.Sub<Prime,prime.Eq,Bag>.Instance.be(x, y);

			throw new NotImplementedException();
		}
	}
}
