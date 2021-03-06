﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ELearningV1._3._1.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> Get(Expression<Func<T, bool>> expression);

        Task<T> GetById(long id);
        Task<IEnumerable<T>> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        Task<T> SingleOrDefault(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entity);
    }
}
