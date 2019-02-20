using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OppaiWNet;
using OppaiWNet.Wrap;

namespace TestConsole
{
    public unsafe class Program
    {
        static void Main(string[] args)
        {
            Ezpp info = new Ezpp(File.ReadAllBytes("a.osu"));

            Console.WriteLine(info.PP);
            info.Acc=99;
            info.ApplyChange();
            Console.WriteLine(info.PP);

            Console.ReadLine();
        }
    }
}
