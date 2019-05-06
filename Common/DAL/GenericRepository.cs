using Data.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Common.DAL
{
	public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity :  class
	{
		internal Entity _context;
		internal DbSet<TEntity> dbSet;

		public GenericRepository(Entity context)
		{
			_context = context;
			dbSet = context.Set<TEntity>();
		}
		public  virtual IEnumerable<TEntity> Get(
			Expression<Func<TEntity, bool>> filter = null,
			Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
			string includeProperties = "")
		{
			IQueryable<TEntity> query = dbSet;
			if (filter != null)
			{
				query = query.Where(filter);
			}
			foreach (var includeProperty in includeProperties.Split
				(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
			{
				query = query.Include(includeProperty);
			}
			if (orderBy != null)
			{
				return orderBy(query).ToList();
			}
			else
			{
				return  query.ToList();
			}
		}
		public virtual TEntity GetByID(object id)
		{
			return dbSet.FirstOrDefault();
		}
		public virtual void Insert(TEntity entity)
		{
			dbSet.Add(entity);
		}
		public virtual int Count(Expression<Func<TEntity, bool>> predicate)
		{
			return _context.Set<TEntity>().Count(predicate);
		}
		public virtual void Delete(object id)
		{
			TEntity entityToDelete = dbSet.FirstOrDefault();
			Delete(entityToDelete);
		}

		

		public virtual void Delete(TEntity entityToDelete)
		{
			if (_context.Entry(entityToDelete).State == EntityState.Detached)
			{
				dbSet.Attach(entityToDelete);
			}
			dbSet.Remove(entityToDelete);
		}
		public async Task<TEntity> UpdateAsync(TEntity updated)
		{
			throw new NotImplementedException();
		}
		public async Task<int> DeleteAsync(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public int Count()
		{
			throw new NotImplementedException();
		}

		public async Task<int> CountAsync()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<TEntity> Filter(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "", int? page = null,
			int? pageSize = null)
		{
			throw new NotImplementedException();
		}

		public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public bool Exist(Expression<Func<TEntity, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public IQueryable<TEntity> Query()
		{
			throw new NotImplementedException();
		}

		public ICollection<TEntity> GetAll()
		{
			return dbSet.ToList();
		}

		public async Task<ICollection<TEntity>> GetAllAsync()
		{
			return await dbSet.ToListAsync();
		}

		public TEntity GetById(int id)
		{
			return dbSet.Find(id);
		}

		public async Task<TEntity> GetByIdAsync(int id)
		{
			return await dbSet.FindAsync(id);
		}

		public TEntity GetByUniqueId(string id)
		{
			return dbSet.Find(id);
		}

		public async Task<TEntity> GetByUniqueIdAsync(string id)
		{
			return await dbSet.FindAsync(id);
		}

		public TEntity Find(Expression<Func<TEntity, bool>> match)
		{
			return dbSet.SingleOrDefault(match);
		}

		public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match)
		{
			return await dbSet.SingleOrDefaultAsync(match);
		}

		public ICollection<TEntity> FindAll(Expression<Func<TEntity, bool>> match)
		{
			return dbSet.ToList();
		}

		public async Task<ICollection<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> match)
		{
			return await dbSet.ToListAsync();
		}

		public TEntity Add(TEntity entity)
		{
			return dbSet.Add(entity);
		}

		public async Task<TEntity> AddAsync(TEntity entity)    ///Todo: Implement AddAsync
		{
			throw new NotImplementedException();
		}

		TEntity IGenericRepository<TEntity>.Update(TEntity updated)
		{
			throw new NotImplementedException();
		}

		public virtual void Update(TEntity entityToUpdate)
		{
			dbSet.Attach(entityToUpdate);
			_context.Entry(entityToUpdate).State = EntityState.Modified;
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		protected virtual void Dispose(bool disposing)
		{
			if (!disposing) return;

			if (_context == null) return;

			_context.Dispose();
			_context = null;
		}
	}
}


