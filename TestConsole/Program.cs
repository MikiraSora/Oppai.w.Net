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
            Ezpp info = new Ezpp("a.osu");
            float[] accs = new[] { 92f, 94f, 96f, 98f, 100f };

            foreach (var acc in accs)
            {
                info.Acc=acc;
                info.Mods=0;
                info.Mode=0;
                info.ApplyChange();
                Console.WriteLine($"{info.Acc} : {info.PP.ToString("F2")}");
            }

            Console.ReadLine();
        }
    }
}
