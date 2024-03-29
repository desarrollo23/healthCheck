﻿using System;
using System.Collections.Generic;

namespace HealthCheck.Contracts.Base.Interfaces.Repository
{
    public interface IRepository<T>
    {
        void Add(T entity);
        IList<T> FindAll();

        void Delete(int id);

        T FindById(int id);

        void Update(T entity);

        T FindBy(Func<T, bool> predicate);
    }
}
