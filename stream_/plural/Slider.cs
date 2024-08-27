using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._stream_;

namespace nilnul.num.stream_.plural
{
	public class Slider : nilnul.num.slider.FroStream
	{
		public Slider() : base(new nilnul.num.stream_.Plural())
		{
		}


		static public readonly Slider Singleton = SingletonByDefault<Slider>.Instance;

	}
}
