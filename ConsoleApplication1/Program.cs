using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [Flags]
    enum Colors
    {
        None = 0,
        Red = 0x1,
        Blue = 0x2,
        Green = 0x4,
        Yellow = 0x8
    }

    class Program
    {
        static void Main(string[] args)
        {
            var colors1 = Colors.Blue | Colors.Green | Colors.Red;

            // Remove a Color from the list
            var colors2 = colors1 & ~Colors.Green;

            // Unboxing
            var color3 = (Colors)(int)colors1;
        }
    }
}
