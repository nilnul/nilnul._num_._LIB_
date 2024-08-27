using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.num.natural.Natural2;
using N1 = nilnul.num.natural.Natural_bigInteger;

namespace nilnul.num.duo.op
{
    public class Gcd
    {
		static public int Eval(int a, int b) {
			return a == 0 ? b : Eval(b % a, a);
		}
    }
}
