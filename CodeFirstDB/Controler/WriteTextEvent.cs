using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{
    public delegate void ReturnInfoEventHandler(ReturnInfoEventArg arg);

    public class ReturnInfoEventArg : EventArgs
    {
        public string Message { get; set; }

        public ReturnInfoEventArg(string message)
        {
            Message = message;
        }
    }
    
}
