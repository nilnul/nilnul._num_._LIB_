using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.binary_._pow
{

	[Serializable]
	public class NilNilException : Exception
	{
		public NilNilException() { }
		public NilNilException(string message) : base(message) { }
		public NilNilException(string message, Exception inner) : base(message, inner) { }
		protected NilNilException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }


	}

}
