using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection;
using nilnul.num.natural;
using nilnul.collection.matrix;
using nilnul.collection.matrix.square;
using nilnul.num.natural.matrix;

namespace nilnul.num.matrix.square
{
	/// <summary>
	/// compute the result of power
	/// </summary>
	/// 

	static public class PowX
	{
		static public Square<uint> Eval(this Square<uint> m, uint p)
		{
			if (m  is null)
			{
				return null;

			}

			if (m.components  is null)
			{
				return null;

			}



			return new Square<uint>(_Eval(m.components, p));


		}



		static public uint[,] Eval(this uint[,] a, uint p)
		{
			var r = Eval(new Square<uint>(a), p);


			return r  is null ? null : r.components;
		}


		static public uint[,] _Eval0(uint[,] square)
		{

			return Identity._CreateUint(square.GetLength(0));

		}

		static public uint[,] _Eval_index1_(uint[,] square)
		{

			return square;

		}

		static public uint[,] _Eval__index0or1_(uint[,] square, int index)
		{

			if (index == 0)
			{
				return Identity._CreateUint(square.GetLength(0));

			}
			else
			{
				return square;
			}

		}
		static public uint[,] _Eval_recurBase0_(uint[,] a, uint p)
		{

			if (p == 0)
			{
				return natural.matrix.Identity.CreateUint((uint)a.GetLength(0));

			}


			var l = p / 2;

			var r = p - l*2;



			var t = _Eval_recurBase0_(a, l);

			return num.matrix.duo.be.multiplicable.asserted.op.Multiply._Eval(
				 num.matrix.duo.be.multiplicable.asserted.op.Multiply._Eval(t, t)
				,
				_Eval(a, r)
			);





		}

		static private uint[,] _Eval(uint[,] a, uint p)
		{

			if (p == 0)
			{
				return natural.matrix.Identity.CreateUint((uint)a.GetLength(0));

			}

			if (p == 1)
			{
				return a;

			}



			var l = p / 2;

			var r = p - l - l;




			var t = _Eval(a, l);
			return Multiply.Eval(
				Multiply.Eval(t, t)
				,
				_Eval(a, r)
			);





		}
		//static private ulong[,] _Eval(ulong[,] a, uint p)
		//{

		//	if (p == 0)
		//	{
		//		return Identity.CreateUlong((uint)a.GetLength(0));

		//	}

		//	if (p == 1)
		//	{
		//		return a;

		//	}



		//	var l = p / 2;
		//	var r = p - l - l;


		//	var t = _Eval(a, l);
		//	return Multiply.Eval(
		//		Multiply.Eval(t, t)
		//		,
		//		_Eval(a, r)
		//	);





		//}

	}

}
