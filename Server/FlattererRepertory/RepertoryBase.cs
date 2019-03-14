using FlattererRepertory.IRepertory;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FlattererRepertory
{
    public class RepertoryBase<T>: IrepertoryBase<T>
    {
        protected readonly FlattererContext context;

        protected RepertoryBase(FlattererContext context)
        {
            this.context = context;
        }

        public bool Add(T obj)
        {
            throw new NotImplementedException();
        }

        public bool Commit()
        {
            throw new NotImplementedException();
        }

        public bool Delete(Expression<Func<T, bool>> lambda)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> lambda)
        {
            throw new NotImplementedException();
        }

        public IList<T> FindList(Expression<Func<T, bool>> lambda)
        {
            throw new NotImplementedException();
        }

        public IList<T> FindPageList(Expression<Func<T, bool>> lambda, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public bool Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
