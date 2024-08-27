using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Data;
using nilnul.num.natural;
//using System.Data.Entity.Infrastructure;
using System.Data.Entity;


namespace nilnul.num_.plural_.prime.sortie_.db_.ef_
{
	/// <summary>
	/// try to not load all from db.Svr to this that might be a AppSvr, but let the dbSvr to determine whether there is a such prime.
	/// </summary>
	/// <remarks>
	///  This is the controller of a db table.
	///	/// todo:make it thread safe.
	/// </remarks>
	///
	public class Determiner
	{
		public const long MAX = long.MaxValue;

		readonly nilnul._num_._LINQ_.eg_.plural_.prime_.db_.ef_.Model1 db = new _num_._LINQ_.eg_.plural_.prime_.db_.ef_.Model1();



		private object _lock = new object();
		private void _PopulateAndCommit(long _plural)
		{
			lock (_lock)
			{
				_PopulateToCover(_plural);
				//_PopulateToCover_saveByBatch(_plural);
				db.SaveChanges();

			}

		}

		/// <summary>
		/// the bound has to be a long ;
		/// </summary>
		/// <param name="bound"></param>
		void PopulateAndCommit(BigInteger bound)
		{
			_PopulateAndCommit((long)bound);
		}

		bool _Contains(long _plural)
		{
			_PopulateAndCommit(_plural);
			return db.Prime.Any(c => c.prime1 == _plural);//run this on db server in order to alleviate the burden of appSvr;
		}

		/// <summary>
		/// check whether it's plural first;
		/// </summary>
		/// <param name="i">
		/// if it's not pluarl, a false is returned;
		/// </param>
		/// <returns></returns>
		public bool Contains(long i)
		{

			if (PluralX.Not(i))
			{
				return false;

			}
			return _Contains(i);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns>nullable</returns>
		Tuple<long, long, bool> GetUpperPrimability1()
		{
			var maxRec = GetMaxRecord_byCheckNull();
			if (maxRec is null)
			{
				return null;
			}


			var composite = GetCompositeUpperBound();

			if (composite is null)
			{
				return new Tuple<long, long, bool>(maxRec.position, maxRec.prime1, true);

			}

			return new Tuple<long, long, bool>(maxRec.position, composite.Value, false);

		}

		Tuple<long, long, bool> GetUpperPrimability_noNullReturned()
		{
			var maxRec = GetMaxRecord_byCheckNull();
			if (maxRec is null)
			{
				return new Tuple<long, long, bool>(0, 1, false); ;
			}


			var composite = GetCompositeUpperBound();

			if (composite is null)
			{
				return new Tuple<long, long, bool>(maxRec.position, maxRec.prime1, true);

			}

			return new Tuple<long, long, bool>(maxRec.position, composite.Value, false);

		}



		nilnul._num_._LINQ_.eg_.plural_.prime_.db_.ef_.Prime GetMaxRecord_byCheckNull()
		{
			var t = db.Max.FirstOrDefault();

			if (t is null)
			{
				return null;

			}

			var prime = new nilnul._num_._LINQ_.eg_.plural_.prime_.db_.ef_.Prime();
			prime.position = t.position;
			prime.prime1 = t.prime;
			return prime;

			if (db.Prime.Any())
			{

			}
			else
			{
				return null;
			}

		}


		nilnul._num_._LINQ_.eg_.plural_.prime_.db_.ef_.Max GetMaxRecord2()
		{


			return db.Max.FirstOrDefault();



		}

		long? GetCompositeUpperBound()
		{

			var r = db.Cap.FirstOrDefault();
			if (r is null)
			{
				return null;

			}
			return r.composite;

		}

		private List<long> Loaded;

		/// <summary>
		/// the candidate is not in db;
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

			long sqrtFloor = (long)(_plural.SqrtFloor());



			foreach (var item in
				Loaded.Union(
					db.ChangeTracker.Entries()
				   .Where(
						x => x.State == EntityState.Added && x.Entity is nilnul._num_._LINQ_.eg_.plural_.prime_.db_.ef_.Prime t
					)
				   .Select(
						x => x.Entity as nilnul._num_._LINQ_.eg_.plural_.prime_.db_.ef_.Prime
					).Select(g => g.prime1)
				).Where(f => f <= sqrtFloor)


			/*

			 (db as IObjectContextAdapter).ObjectContext.ObjectStateManager.GetObjectStateEntries(EntityState.Added).Where(c => c.Entity is db.Prime).Select(d => d.Entity as db.Prime).Where(e => e.prime1<= sqrtFloor).Union(

					db.Prime.Where(f => f.prime1 <= sqrtFloor)
					).Select(g => g.prime1)
			 */



			)
			{

				if (_plural % item == 0)
				{
					return false;

				}
			}

			return true;

		}

		void PopulateToCover(long plural)
		{

			PluralX.Assert(plural);
			_PopulateToCover(plural);

			//
		}






		private void _PopulateToCover(long _plural)
		{
			
			var upperPrimability = GetUpperPrimability1();

			if (upperPrimability is null)   //init
			{
				_PopulateToCover_FromNull(_plural);
				return;
			}
			else
			{
				if (_plural > upperPrimability.Item2)
				{
					//_PopulateToCover_saveByBatch
					_Populate2cover_setBound
						(upperPrimability.Item1, upperPrimability.Item2, _plural);

				}
			}
		}


		void PopulateToCover(Plural p)
		{
			_PopulateToCover((long)p);


		}



		private void _Insert(long sn, long prime)
		{

			var rec = new nilnul._num_._LINQ_.eg_.plural_.prime_.db_.ef_.Prime();

			rec.position = sn;
			rec.prime1 = prime;

			db.Prime.Add(rec);

		}




		/// <summary>
		/// upperPrimability is null
		/// </summary>
		/// <param name="p"></param>
		private void _PopulateToCover_FromNull(long p)
		{

			_Populate2cover_setBound(0, 1, p);



		}




		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		///  sn=0, bound=1 if table is empty.
		/// if table is not empty, bound is the actual bound 
		/// </remarks>
		/// <param name="primeSn">
		/// current max prime's sn. it's the prime counting function of prime. for example Pi(2)=1
		/// </param>
		/// <param name="currentBound"></param>
		/// <param name="newBound"> </param>
		/// <param name="currentPrimeSn"></param>
		/// <param name="currentBound"></param>
		/// <param name="newBound"></param>
		/// <returns></returns>
		private void _Populate2cover_setBound(long currentPrimeSn, long currentBound, long newBound)
		{
			Loaded = db.Prime.OrderBy(x=>x.position).Select(x=>x.prime1).ToList();
			//long sn = 0;

			var newBoundDecreased = newBound - 1;

			for (long i = currentBound; i < newBoundDecreased;)
			{
				//check i's primability

				i++;

				if (_isNextPrime2(i))
				{
					currentPrimeSn++;

					_Insert(currentPrimeSn, i);

				}



			}   //i is the newBound.



			if (_isNextPrime2(newBound))
			{
				currentPrimeSn++;

				_Insert(currentPrimeSn, newBound);

				///set the 
				///
				_DeleteBound();


			}
			else
			{
				_SetBound(newBound);

			}

		}


		private void _DeleteBound()
		{
			var compositeUppoerBound = db.Cap.FirstOrDefault();
			if (!(compositeUppoerBound is null))
			{
				db.Cap.Remove(compositeUppoerBound);

			}
			//db.Prime_CompositeUpperBound

		}

		private void _SetBound(long newBound)
		{

			var compositeUppoerBound = db.Cap.FirstOrDefault();
			if (!(compositeUppoerBound is null))
			{
				db.Cap.Remove(compositeUppoerBound);


			}


			compositeUppoerBound = new nilnul._num_._LINQ_.eg_.plural_.prime_.db_.ef_.Cap();
			compositeUppoerBound.composite = newBound;
			db.Cap.Add(compositeUppoerBound);



		}

	}
}