using System;
using System.Net;

namespace nilnul.num.natural
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

		public NaturalByBigInteger eval(NaturalByBigInteger a,NaturalByBigInteger b) {

			return (a.val + b.val).ToNatural();
		
		}

		static public NaturalByBigInteger Eval(NaturalByBigInteger a,NaturalByBigInteger b) {
			return Instance.eval(a, b);
		}
				

	}

	static public partial class AddX
	{
		static public NaturalByBigInteger Add(this NaturalByBigInteger a,NaturalByBigInteger b) {
			return natural.Add.Eval(a, b);
		
		}
		
	}
}
