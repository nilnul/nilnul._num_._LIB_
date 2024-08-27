using System;
using System.Net;
using nilnul.num.natural.relation;



namespace nilnul.num.natural
{
	[Obsolete()]
	static public  class RemainderX
	{


		static public Natural Remainder(this Natural dividend,Natural divisor) {

			if (divisor.Equal(Natural.Zero))
			{
				throw new Exception();
			}
			else
			{
				return (dividend.val % divisor.val).ToNatural();
			}
		}

	
				

	}

	
}
