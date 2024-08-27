using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.theorem_.modulo_
{
	/*
	中国余数定理：

	若x=y(%p)，x=y(%q)，p、q互质，则x=y（%pq）。

证：

因x=y（%p），故x=y+kp（k为整数），故x-y=kp，故x-y可被p整除。----------（1）

同理，x-y可被q整除。-----------------------------------（2）

而p、q互质，综合（1）、（2）得x-y可被p、q整除。

所以x=y（%pq）。 
	 
	 */
	class ChineseRemainder
	{
	}
}
