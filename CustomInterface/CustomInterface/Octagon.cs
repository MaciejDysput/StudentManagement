using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    public class Octagon :IDrawToForm,IDrawToMemory,IDrawToPrinter
    {
        public void Draw()
        {
            Console.WriteLine("Writing kurwa");
        }

        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to form...");
        }
        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to memory");
        }
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to printer");
        }
    }
}
