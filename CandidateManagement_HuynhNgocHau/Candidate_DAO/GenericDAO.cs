using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
	public class GenericDAO<T> where T : class
	{
		private readonly DbContext _context;
		private readonly DbSet<T> _dbSet;
		public GenericDAO(DbContext context)
		{
			_context = context;
			_dbSet = _context.Set<T>();
		}
		public List<T> GetAll()
		{
			try
			{
				return _dbSet.ToList();
			}
			catch (Exception)
			{
				return new List<T>();
			}
		}

		public T GetById(string id)
		{
			try
			{
				return _dbSet.Find(id);
			}
			catch (Exception)
			{
				return null;
			}
		}

		public bool Add(T entity)
		{
			try
			{
				_dbSet.Add(entity);
				return _context.SaveChanges() > 0;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool Update(T entity)
		{
			try
			{
				_context.Entry(entity).State = EntityState.Modified;
				bool isSuccess = _context.SaveChanges() > 0;
				_context.Entry(entity).State = EntityState.Detached;
                return isSuccess;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool Delete(string id)
		{
			try
			{
				var entity = GetById(id);
				if (entity != null)
				{
					_dbSet.Remove(entity);
					return _context.SaveChanges() > 0;
				}
				return false;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
