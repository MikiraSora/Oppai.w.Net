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
            
            var ver=Oppai.oppai_version();

            Oppai.ezpp(ezpp, "a.osu");

            Console.WriteLine(Oppai.ezpp_ar(ezpp));
            Console.WriteLine(Oppai.ezpp_od(ezpp));
            Console.WriteLine(Oppai.ezpp_cs(ezpp));
            Console.WriteLine(Oppai.ezpp_hp(ezpp));

            var o = Oppai.ezpp_title_unicode_str(ezpp);
            Console.WriteLine(o);

            Oppai.ezpp_free(ezpp);

            Console.ReadLine();
        }
    }
}
