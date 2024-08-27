using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Data;
using nilnul.num.natural;
//using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Collections;

namespace nilnul.num_.plural_.prime.sortie_.db_.ef
{
	/// <summary>
	/// enumerate from db. assume schema(which is static, or,  before dynamic) exists.
	/// not change db. To save, you need to create a new class.
	/// </summary>
	/// <remarks>
	///  This is the controller of a db table.
	///	/// todo:make it thread safe.
	/// </remarks>
	public class StrAsLongSeq
		: IEnumerable<long>
		,
		IDisposable
		//,
		//nilnul.obj.stream_.SliderI<long>
	{

		public readonly nilnul._num_._LINQ_.eg_.plural_.prime_.db_.ef_.Model1 db = new _num_._LINQ_.eg_.plural_.prime_.db_.ef_.Model1();



		List<nilnul._num_._LINQ_.eg_.plural_.prime_.db_.ef_.Prime> primesOrdered;

		long? compositUpperBound;

		/// <summary>
		/// todo: is "int" enough to hold the indexws of all primes winthin "long"?
		/// </summary>
		int oldCount;

		 private void __deleteBound()
		{
			var compositeUppoerBound = db.Cap.FirstOrDefault();
			if (!(compositeUppoerBound is null))
			{
				db.Cap.Remove(compositeUppoerBound);

			}
			//db.Prime_CompositeUpperBound

		}

		 private void __insert()
		{

			

			db.Prime.AddRange(
				primesOrdered.Skip(oldCount)
			);

		}


		void _saveBack() {
			__deleteBound();
			__insert();
			db.SaveChanges();
		

		}

		public StrAsLongSeq()
		{
			primesOrdered = db.Prime.OrderBy(x => x.position).ToList();
			oldCount = primesOrdered.Count;

			compositUpperBound = getCompositeUpperBound();

			if (!primesOrdered.Any())
			{
				primesOrdered.Add(new _num_._LINQ_.eg_.plural_.prime_.db_.ef_.Prime()
				{ position = 1, prime1 = 2 }
					);

				primesOrdered.Add(new _num_._LINQ_.eg_.plural_.prime_.db_.ef_.Prime()
				{ position = 2, prime1 = 3 }
					);

				compositUpperBound = null;

			}
			else
			{
				if (!primesOrdered.Skip(1).Any())
				{
					primesOrdered.Add(new _num_._LINQ_.eg_.plural_.prime_.db_.ef_.Prime()
					{ position = 2, prime1 = 3 }
						);

					compositUpperBound = null;

				}
			}


		}



		public long? getCompositeUpperBound()
		{

			return db.Cap.FirstOrDefault()?.composite;


		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="_plural">This must be a plural (a natural no less than 2).</param>
		/// <returns></returns>
		/// <remarks>
		/// find in the table anyone that divides the plural
		///  
		/// </remarks>
		private bool _isNextPrime2(long _plural)
		{
			//var ordered = db.Primes.OrderBy(c => c.sn);

			//long curPrime;

			long sqrtFloor = (long)( _plural.SqrtFloor());


			foreach (
				var item in primesOrdered.TakeWhile(f => f.prime1 <= sqrtFloor)
						.Select(g => g.prime1)
			)
			{
				if (_plural % item == 0)
				{
					return false;
				}
			}

			return true;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="currentPrimeSn">primes le/up2.   0, there is no primes </param>
		/// <param name="currentBound">
		/// 1, if there is no prime
		/// 2,3,5,7,11,... if there is some prime
		/// </param>
		/// <param name="newBound"></param>
		public IEnumerator<long> GetEnumerator(
		)
		{

			foreach (var item1 in primesOrdered)
			{
				yield return (item1.prime1);
			}

			var last = primesOrdered.LastOrDefault();

			long currentPrimeSn;

			currentPrimeSn = last.position;

			long next2check;
			if (compositUpperBound is null)
			{
				next2check = last.prime1 + 2;

			}
			else
			{
				next2check = compositUpperBound.Value + 1;
				if (next2check % 2 == 0)
				{
					next2check += 1;
				}
			}

			compositUpperBound = null;


			for (long i = next2check; ; )
			{
				//check i's primability

				if (_isNextPrime2(i))
				{
					currentPrimeSn++;

					primesOrdered.Add(
						new _num_._LINQ_.eg_.plural_.prime_.db_.ef_.Prime()
						{
							position = currentPrimeSn
							,
							prime1 = i
						}
					);

					yield return i;

				}

				if (i <= long.MaxValue-2)
				{
					i += 2;
					continue;
				}
				else
				{
					break;
				}

			}   //i is the newBound.

			



		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}

		public void Dispose()
		{
			_saveBack();
			//throw new NotImplementedException();
		}
	}
}