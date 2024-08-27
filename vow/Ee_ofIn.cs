using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.vow
{


	public class Ee_ofIn : nilnul.obj.vow.Ee_ofIn<nilnul.Num_ofIn>

	{
		public ref BigInteger integer{ get {
				return ref base.eeByRef.eeByRef;
			}
		}
		public Ee_ofIn(in Num_ofIn val,in obj.VowI_ofIn<Num_ofIn> vow) : base(in val, in vow)
		{
		}

		public Ee_ofIn(in Num_ofIn val, obj.VowI_ofIn<Num_ofIn> vow) : this(in val,in vow)
		{
		}

		public Ee_ofIn(Num_ofIn val, obj.VowI_ofIn<Num_ofIn> vow) : this(in val,in vow)
		{
		}
		public Ee_ofIn(Num_ofIn val, in obj.VowI_ofIn<Num_ofIn> vow) : this(in val,in vow)
		{
		}

	}

}
