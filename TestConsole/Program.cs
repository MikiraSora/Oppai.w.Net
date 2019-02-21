using OppaiWNet;
using OppaiWNet.Wrap;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public unsafe class Program
    {
        static void Main(string[] args)
        {
            var info = new Ezpp("a.osu");
            //auto recalc and you dont need to call ApplyChanged() manually.
            info.AutoCalculate=true;
            
            Console.WriteLine(info.PP);
            info.Acc=98;

            //info.ApplyChange();
            Console.WriteLine(info.PP);

            Console.ReadLine();
        }
    }
}
