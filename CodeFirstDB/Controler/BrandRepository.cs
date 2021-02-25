using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{
    class BrandRepository : IDB<Brand, int>
    {
        private Context context;

        public BrandRepository()
        {
            context = new Context();
        }
        public void Create(Brand item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public Brand Find(string index)
        {
            throw new NotImplementedException();
        }

        public Brand Read(int key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Brand> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Brand item)
        {
            throw new NotImplementedException();
        }
    }
}
