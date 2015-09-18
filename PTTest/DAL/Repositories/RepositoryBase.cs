﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PTTest.DAL;
using PTTest.DAL.Interfaces;
using System.Data.Entity;
using System.Threading.Tasks;

namespace PTTest.DAL.Repositories
{
    //Declare abstract class for all table interactions using common functions
    //  THese default functions require override [GetPaged(), GetAll(), GetFullObject()]
    //  
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        internal DataContext context;
        internal DbSet<TEntity> dbSet;

        public RepositoryBase(DataContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return dbSet;
        }

        public virtual IQueryable<TEntity> GetPaged(int top = 20, int skip = 0, object orderBy = null, object filter = null)
        {
            return null; //need to override in order to implement specific filtering and ordering
        }

        public virtual IQueryable<TEntity> GetAll(object filter)
        {
            return null; //need to override in order to implement specific filter
        }

        public virtual TEntity GetFullObject(object id)
        {
            return null; //need to override in order to implement specific object graph
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
                dbSet.Attach(entity);

            dbSet.Remove(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entity = dbSet.Find(id);
            Delete(entity);
        }

        public virtual void Commit()
        {
            context.SaveChanges();
        }

        public virtual void Dispose()
        {
            context.Dispose();
        }
    }
}