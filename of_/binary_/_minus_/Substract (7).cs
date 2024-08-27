using System;
using System.Net;


namespace nilnul.num.natural
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
		public NaturalByBigInteger eval(NaturalByBigInteger a,NaturalByBigInteger b) {
			
				return (a.val - b.val).ToNatural();
			
		}
		public NaturalByBigInteger eval(NaturalByBigInteger a,int b) {
			return eval(a, b.ToNatural());
		}

		static public NaturalByBigInteger Eval(NaturalByBigInteger a,NaturalByBigInteger b) {

			return Instance.eval(a, b);
		
		}
		static public NaturalByBigInteger Eval(NaturalByBigInteger a,int b) {
			return Instance.eval(a, b);
		
		}

	}

	static public partial class SubtractX {
		static public NaturalByBigInteger Subtract(this NaturalByBigInteger a,NaturalByBigInteger b) {

			return Substract.Eval(a, b);
		
		}
		static public NaturalByBigInteger Subtract(this NaturalByBigInteger a, int b) {

			return Substract.Eval(a, b);
		
		}
	}
}
