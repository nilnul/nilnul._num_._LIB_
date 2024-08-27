using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.uinteger
{
    public class Gcd
    {
        static public uint Eval(uint a,uint b) {
            return a <= b ? _EvalSmallFirst(a, b) : _EvalSmallFirst(b, a);
            
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="smaller"></param>
        /// <param name="bigger"></param>
        /// <returns>0 for (0,0)</returns>
        /// <remarks>a is less than b. Note small first for big things is defined upon the definition of small that must be established first.</remarks>
        static private uint _EvalSmallFirst(uint smaller,uint bigger) {
            if (smaller==0)
            {
                return bigger;
                
            }
            return _EvalSmallFirst(bigger % smaller, smaller);

        }

        static public BigInteger Eval(BigInteger a,BigInteger b) {
 
            return BigInteger.GreatestCommonDivisor(a,b);
        
        }

        static public UintegerI eval(UintegerI a, UintegerI b) {

            if (a is UintegerByBigInteger && b is UintegerByBigInteger)
            {
                return Eval(
                    ((UintegerByBigInteger)a).toBigInteger(),
                    ((UintegerByBigInteger)b).toBigInteger()
                    ).ToUinteger();
                
            }
            throw new Exception("Unrecognized type.");
        
        
        }
    }
}
