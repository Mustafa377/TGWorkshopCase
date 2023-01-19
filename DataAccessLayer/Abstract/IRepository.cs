using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        /* CRUD işlemleri için metotlar tanımlanır. Listeleme için List methodunu tanımladım.
           T yerine Category yazarsak CategoryDal sınıfında bu interface'i implemente ederken Category yerine Category yazmamız gerekir.
           Bu yüzden T yazdık. Bu sayede CategoryDal sınıfında bu interface'i implemente ederken Category yerine T yazmamız yeterli olacaktır. */
        List<T> List();
    
        
        // Listeleme işlemlerinde filtreleme yapmak için kullanılan metotlar.
        List<T> List(Expression<Func<T, bool>> filter);

    }
}
