using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.DAL;

public class GenericRepo<T> : IGenericRepo<T> where T : class
{
    private readonly AccContext _accContext;
    public GenericRepo(AccContext accContext)
    {
        _accContext = accContext;
    }
    public void Add(T entity)
    {
         _accContext.Set<T>().Add(entity);
    }

    public void Delete(T entity)
    {
        _accContext.Set<T>().Remove(entity);
    }

    public T? Get(int id)
    {
        return _accContext.Set<T>().Find(id);
    }

    public IEnumerable<T> GetAll()
    {
        return _accContext.Set<T>().ToList();
    }

    public void saveChanges()
    {
        _accContext.SaveChanges();
    }

    public void Update(T entity)
    {
        
    }
}
