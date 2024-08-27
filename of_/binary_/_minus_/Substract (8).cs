using System;
using System.Net;


namespace nilnul.uinteger
{
	public partial class Substract
	{

		static private readonly Substract _Instance = new Substract();
		static public Substract Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Substract()
		{
		}
		public UintegerByBigInteger eval(UintegerByBigInteger a,UintegerByBigInteger b) {
			
				return (a.val - b.val).ToUinteger();
			
		}
		public UintegerByBigInteger eval(UintegerByBigInteger a,int b) {
			return eval(a, b.ToUinteger());
		}

		static public UintegerByBigInteger Eval(UintegerByBigInteger a,UintegerByBigInteger b) {

			return Instance.eval(a, b);
		
		}
		static public UintegerByBigInteger Eval(UintegerByBigInteger a,int b) {
			return Instance.eval(a, b);
		
		}

	}

	static public partial class SubtractX {
		static public UintegerByBigInteger Subtract(this UintegerByBigInteger a,UintegerByBigInteger b) {

			return uinteger.Substract.Eval(a, b);
		
		}
		static public UintegerByBigInteger Subtract(this UintegerByBigInteger a, int b) {

			return uinteger.Substract.Eval(a, b);
		
		}
	}
}
