using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FlattererRepertory.IRepertory
{
    public interface IrepertoryBase<T>
    {
        bool Add(T obj);
        bool Delete(Expression<Func<T,bool>>lambda);
        bool Update(T obj);
        IEnumerable<T> Find(Expression<Func<T, bool>> lambda);
        IList<T> FindList(Expression<Func<T, bool>> lambda);
        IList<T> FindPageList(Expression<Func<T, bool>> lambda,int page,int pageSize);

        bool Commit();
    }
}
