using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.slider.to_
{
	public class Enumerable<T>
		:
		nilnul.Box1<_slider_.SliderI<T>>
		,
		IEnumerable<T>
	{
		public Enumerable( _slider_.SliderI<T> slider): base(slider)
		{


		}

		public IEnumerator<T> GetEnumerator()
		{
			while (true)
			{

				yield return this.boxed.current;
				this.boxed.moveNext();

			}

			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}
	}
}
