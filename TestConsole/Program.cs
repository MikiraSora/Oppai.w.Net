using OppaiWNet;
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
            var ptr = Oppai.ezpp_new();
            Oppai.ezpp(ptr, "a.osu");

            Console.WriteLine($"VER:{Oppai.oppai_version_str_str()}");
            Console.WriteLine($"HP:{Oppai.ezpp_hp(ptr)}");
            Console.WriteLine($"CS:{Oppai.ezpp_cs(ptr)}");
            Console.WriteLine($"OD:{Oppai.ezpp_od(ptr)}");
            Console.WriteLine($"AR:{Oppai.ezpp_ar(ptr)}");

            Console.ReadLine();
        }
    }
}
