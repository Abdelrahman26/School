using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc.DAL;

public interface IGenericRepo<T>
{
    T? Get(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    void saveChanges();
    IEnumerable<T> GetAll();

}
