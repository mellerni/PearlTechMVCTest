﻿using System.Linq;

namespace PearlTech.DAL.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Commit();
        void Delete(TEntity entity);
        void Delete(object id);
        void Dispose();
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAll(object filter);
        TEntity GetByID(object id);
        TEntity GetFullObject(object id);
        IQueryable<TEntity> GetPaged(int top = 20, int skip = 0, object orderBy = null, object filter = null);
        void Insert(TEntity entity);
        void Update(TEntity entity);
    }
}