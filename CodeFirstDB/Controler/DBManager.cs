using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{
    public static class DBManager
    {
        private static Context context;
        public static event ReturnInfoEventHandler Message;
        public static void Run(string command, string type, string[] args)
        {
            context = new Context();
            switch (type)
            {
                case "brand":
                    switch (command)
                    {
                        case "create":
                            Brand brand = Mapper.GetBrand(args[0]);
                            context.Brands.Add(brand);
                            context.SaveChanges();
                            return;
                        case "read":
                            int idToBeRead = int.Parse(args[0]);
                            var readBrand = context.Brands.Find(idToBeRead);
                            OnMessage(ModelsToString.BrandToString(readBrand));
                            return;
                        case "readAll":
                            var allBrands = context.Brands.ToList();
                            string readAllBrandsOutput = string.Join(Environment.NewLine,
                                allBrands.Select(x => ModelsToString.BrandToString(x)));
                            OnMessage(readAllBrandsOutput);
                            return;
                        //case "update":
                        //    int idToBeUpdated = int.Parse(args[0]);
                        //    var brandToBeUpdated = context.Brands.Find(idToBeUpdated);
                        //    brandToBeUpdated.Name = args[1];
                        //    context.Brands.Update
                        default:
                            break;
                    }
                    break;
                case "Product":
                    switch (command)
                    {
                       
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private static void OnMessage(string message)
        {
            ReturnInfoEventArg arg = new ReturnInfoEventArg(message);
            if (Message != null)
            {
                Message.Invoke(arg);
            }
        }
        
    }
}
