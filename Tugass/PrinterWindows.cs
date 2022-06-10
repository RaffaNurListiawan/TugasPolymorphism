using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugass
{
    class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("Printer display dimension: ");
        }
        public virtual void Print()
        {
            Console.WriteLine("Printer Printing......");
        }
    }
}
