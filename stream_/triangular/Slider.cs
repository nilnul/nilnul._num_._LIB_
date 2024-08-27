using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.stream_.triangular
{
	public class Slider : 
		nilnul.obj.Box< nilnul.num.stream_.Triangular>
		,
		nilnul.num.SliderI1
	{
		public Slider() : base(new Triangular())
		{
			_current = this.boxed.next();

		}

		private NumI _current;

		public NumI current
		{
			get
			{
				return _current;
				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			_current = this.boxed.next();
			//throw new NotImplementedException();
		}
	}
}
