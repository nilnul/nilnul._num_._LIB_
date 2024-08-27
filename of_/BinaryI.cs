using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_
{
	public interface BinaryI1:
		nilnul.obj.op_._binary_.par1_.retParPar1_.ClosedI<nilnul.Num1>
		,
		nilnul.obj.op_.BinaryI<Num1>
		//,
		//nilnul.obj.op_._binary_.par1_.retParPar1_.ClosedI<nilnul.NumI1>

	{
	}

	public abstract class BinaryA : BinaryI1
		,
		_binary_.OnInterfacesI
		,
		BinaryI_onInterfaces
	{
		

		public  Num1 op(Num1 par, Num1 par1) {
			return  Num1.OvInteface( op((NumI1)par, (NumI1)par1) );
		}
		public abstract NumI1 op(NumI1 par, NumI1 par1);
	}

	/// <summary>
	/// class is abstract,  not implemented.
	/// </summary>
	public abstract class BinaryOnClassA : BinaryI1
		,
		_binary_.OnInterfacesI
	{
		public  NumI1 op(NumI1 par, NumI1 par1) {
			return   op(Num1.OvInteface(par), Num1.OvInteface(par1) );
		}
		public abstract Num1 op(Num1 par, Num1 par1);


	}

	public abstract class BinaryByIntegerA : BinaryI1
		,
		_binary_.OnInterfacesI
		,
		_binary_.AssumeIntegerI
	{
		public abstract BigInteger op(BigInteger par, BigInteger par1);
		public Num1 op(Num1 par, Num1 par1) {
			return new Num1( op(par.en,par1.en) );
		}
		public  NumI1 op(NumI1 par, NumI1 par1) {
			return new Num1(   op((par.toBigint()), (par1.toBigint()) ) );
		}

	}


	public class Binary
		: BinaryA
	{
		Func<nilnul.NumI1, nilnul.NumI1, nilnul.NumI1> _func;


		public Binary(Func<nilnul.NumI1, nilnul.NumI1, nilnul.NumI1> func)
		{
			_func = func;
		}
		public override NumI1 op(NumI1 par, NumI1 par1)
		{
			return _func(par,par1);
		}
	}
}
