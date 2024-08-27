using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.be
{
	public class VowA: nilnul.obj.be.Vow<Num>
		,
		nilnul.num.VowI
	{

		public VowA(nilnul.num.BeI be ):base(be)
		{

		}

	}

	public class Vow : nilnul.obj.be.Vow2<NumI1>
		,
		nilnul.obj.VowI<nilnul.Num1>

	{
		public Vow(BeI1<NumI1> be) : base(be)
		{
		}

		public Vow(nilnul.num.BeI be):this( ( BeI1<NumI1>) be )
		{

		}

		public void vow(Num1 obj)
		{
			vow((NumI1)obj);
		}
	}

	public class Vow<T> : Vow
		where T : nilnul.num.BeI, new()
	{
		public Vow() : base(nilnul.obj_.Singleton<T>.Instance)
		{
		}
	}
}
