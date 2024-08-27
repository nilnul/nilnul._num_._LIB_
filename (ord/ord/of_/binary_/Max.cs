using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Col = nilnul.num.OrdI1;//.obj._matrix._coord_._col.ValI;

namespace nilnul.num.ord.op_.binary_
{
	public class Max : BinaryI
	{
		public Col op(Col arg, Col arg1)
		{

			return new nilnul.num.Ord1( 
				nilnul.num.op_.binary_.Max.Singleton.op(
				arg.toNum()
				,
				arg1.toNum()
			)
			);
			//throw new NotImplementedException();
		}
	


		static public Max Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Max>.Instance;
			}
		}




	}
}
