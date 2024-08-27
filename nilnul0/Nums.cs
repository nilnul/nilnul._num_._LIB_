using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	public interface NumsI:IEnumerable<nilnul.NumI1>
	{

	}

	public class Nums :
		nilnul.Objs3<nilnul.NumI1>
		, NumsI
	{
		public Nums(IEnumerable<NumI1> val) : base(val)
		{
		}
	}
}
