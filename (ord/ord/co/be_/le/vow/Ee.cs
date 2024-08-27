using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co.be_.le.vow
{
	
	public class Ee<TCol> : 
		co.vow.ee_.VowDefault_OnColVow<TCol,le.Vow_OnOrd<TCol>>
		where TCol : OrdI2


	{
		public Ee(ord.Co<TCol> val) : base(val)
		{
		}
	}

}
