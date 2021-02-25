using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{
    public class ProductRepository : IDB<Product, string>
    {
        public void Create(Product item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string key)
        {
            throw new NotImplementedException();
        }

        public Product Find(string index)
        {
            throw new NotImplementedException();
        }

        public Product Read(string key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
