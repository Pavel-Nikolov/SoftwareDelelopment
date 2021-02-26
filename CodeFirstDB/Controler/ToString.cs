using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{
    static class ModelsToString
    {
        public static string BrandToString(Brand brand)
        {
            return $"Name: {brand.Name}, id: {brand.ID}";
        }
    }
}
