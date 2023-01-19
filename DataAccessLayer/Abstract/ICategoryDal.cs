using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        // CRUD işlemleri için metotlar tanımlanır. Listeleme için List methodunu tanımladım.
        List<Category> List();
        
    }
}
