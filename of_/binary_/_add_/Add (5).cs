using System;
using System.Net;

namespace nilnul.uinteger
{
	public partial class Add
	{

		static private readonly Add _Instance = new Add();
		static public Add Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Add()
		{
		}

		public UintegerByBigInteger eval(UintegerByBigInteger a,UintegerByBigInteger b) {

			return (a.val + b.val).ToUinteger();
		
		}

		static public UintegerByBigInteger Eval(UintegerByBigInteger a,UintegerByBigInteger b) {
			return Instance.eval(a, b);
		}
				

	}

	static public partial class AddX
	{
		static public UintegerByBigInteger Add(this UintegerByBigInteger a,UintegerByBigInteger b) {
			return uinteger.Add.Eval(a, b);
		
		}
		
	}
}
