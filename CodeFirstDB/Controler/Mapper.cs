using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{
    public static class Mapper
    {
        public static Brand GetBrand(string name)
        {
            return new Brand() { Name = name };
        }
    }
}
