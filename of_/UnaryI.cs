using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_
{
	public interface UnaryI1:nilnul.obj.op_._unary_.retPar_.ClosedI<nilnul.Num1>
	{
	}

	public abstract class UnaryOnClassA : UnaryI1, _unary_.OnIntefaceI
	{
		public abstract Num1 op(Num1 par);
		public NumI1 op(NumI1 par) {
			return op(
				Num1.OvInteface(par)
			);
		}
	}


	public abstract class UnaryOnIntefaceA : UnaryI1, _unary_.OnIntefaceI
	{
		public abstract NumI1 op(NumI1 par);
		public Num1 op(Num1 par) {
			return Num1.OvInteface( op(
				(NumI1)par
			)
				);
		}
	}


}
