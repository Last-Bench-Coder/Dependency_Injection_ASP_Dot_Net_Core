using Dependency_Injection_Code.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection_Code.interfaces
{
    public interface IProducts
    {
        IEnumerable<Product> List();
        Product Detail(int id);
    }
}
