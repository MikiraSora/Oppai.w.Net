using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OppaiWNet;

namespace TestConsole
{
    public unsafe class Program
    {
        static void Main(string[] args)
        {
            IntPtr ezpp = Oppai.ezpp_new();

            Oppai.ezpp(ezpp, "a.osu");

            Console.WriteLine(Oppai.ezpp_ar(ezpp));
            Console.WriteLine(Oppai.ezpp_od(ezpp));
            Console.WriteLine(Oppai.ezpp_cs(ezpp));
            Console.WriteLine(Oppai.ezpp_hp(ezpp));

            var o = Marshal.PtrToStringAnsi(new IntPtr(Oppai.ezpp_artist(ezpp)));
            Console.WriteLine(o);

            Oppai.ezpp_free(ezpp);

            Console.ReadLine();
        }
    }
}
