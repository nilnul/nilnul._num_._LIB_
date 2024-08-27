using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.NumI;

namespace nilnul.num.stream_.triangular
{
	public class AdjacentMulti : nilnul.num.StreamI4
	{

		private nilnul.num.stream_.triangular.Slider _slider=new Slider();

		public nilnul.num.stream_.triangular.Slider slider
		{
			get { return _slider; }
		//	set { _slider = value; }
		}

		
		public AdjacentMulti()
		{



		}
		public NumI next()
		{
			var oldCurrent = _slider.current;
			_slider.moveNext();

			return nilnul.num.combine_.Multi.Singleton.eval(_slider.current,oldCurrent);
			//throw new NotImplementedException();
		}
	}
}
