using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_
{
	/*
分配不了1.2G内存都极为不正常”，经过代码严酷测试这句话真没错。所有，我又仔细查看了日志，发现内存数字前面的“横杠”其实是负号。
  
结合代码发现是int msize溢出了，导致实际开辟的不是1.2G，而是负1.2G，类似于表达式1024*1024*1024*8的值其实是0，
  
64位里面，malloc( -1.2G)等于是malloc(17179869182.80G),所以malloc失败。	 */
	class PresetSize
	{
	}
}
