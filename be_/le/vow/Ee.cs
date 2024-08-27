using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.be_.le.vow
{
	public class Ee : nilnul.num.vow.Ee_ofIn
	{
		public Ee(
			in Num_ofIn val
			,
			in Vow vow
		)
			:
		base(
			in val
			,
			 vow
		)
		{
		}

		public Ee(Num_ofIn val, in Vow vow):this(in val, in vow)
		{

		}
		
		public Ee(Num_ofIn val,  Vow vow):this(in val, in vow)
		{

		}

		public Ee(in Num_ofIn val, in Num_ofIn vow):this(in val, new Vow(vow))
		{

		}

		public Ee(in Num_ofIn val):this(in val, in val)
		{

		}

		public Ee():this(0)
		{

		}

	}
}
