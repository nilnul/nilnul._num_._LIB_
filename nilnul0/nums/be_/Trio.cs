using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.s.b
{
	extern alias bit;
	[Obsolete()]
	public class Trio<T>
	{
		/// <summary>
		/// because we have to use count, so it must be in "s", not "seq"
		/// </summary>
		/// <param name="seq"></param>
		/// <returns></returns>
		static public bool Eval(IEnumerable<T> seq)
		{
			return seq.Count() == 3;
		}


		public class B : bit::nilnul.obj.Be<IEnumerable<T>>
		{
			public B() : base(Eval)
			{

			}

		}

		public class Assert:nilnul.obj.Assert_TbDefault<IEnumerable<T>,B>
		{



			
		}


	}
}
