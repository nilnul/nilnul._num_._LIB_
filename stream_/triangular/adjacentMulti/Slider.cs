using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._stream_;

namespace nilnul.num.stream_.triangular.adjacentMulti
{
	public class Slider : nilnul.num.slider.FroStream
	{
		public Slider() : base(new nilnul.num.stream_.triangular.AdjacentMulti())
		{
		}


		static public readonly AdjacentMulti Singleton = SingletonByDefault<AdjacentMulti>.Instance;

	}
}
