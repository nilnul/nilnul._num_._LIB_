using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.plural.be;
using Prime = nilnul.num.plural.be.Prime.Asserted;

namespace nilnul.num.prime
{

	public class Str : StrI
	{
		private IEnumerable<Prime> _val;

		public IEnumerable<Prime> val
		{
			get { return _val; }
			set { _val = value; }
		}

		public Str(IEnumerable<Prime> v)
		{
			_val = v;
		}

		//static public explicit operator Str(IEnumerable<Prime> v) {
		//	return new Str(v);
		//}
		public IEnumerator<Prime> GetEnumerator()
		{
			return _val.GetEnumerator();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();

			throw new NotImplementedException();
		}
	}
	public interface StrI:IEnumerable<Prime>
	{

	}
}
