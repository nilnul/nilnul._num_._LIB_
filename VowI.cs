using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{
	public interface VowI:nilnul.obj.VowI<Num>
	{

	}

	public interface VowI1 : nilnul.obj.VowI<nilnul.NumI1>
		,nilnul.obj.VowI<nilnul.Num1>
	{ }

	public abstract class VowA : VowI1
	{
		public abstract void vow(NumI1 obj);

		public void vow(Num1 obj)
		{
			vow((NumI1)obj);
		}
	}
}
