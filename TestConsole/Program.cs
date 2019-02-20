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
        private static string Utf8Ptr2String(IntPtr ptr)
        {
            var p = Marshal.PtrToStringAnsi(ptr);
            return Encoding.UTF8.GetString(Encoding.ASCII.GetBytes(p));
        }

        static void Main(string[] args)
        {
            IntPtr ezpp = Oppai.ezpp_new();
            
            var ver=Oppai.oppai_version();

            Oppai.ezpp(ezpp, "a.osu");

            Console.WriteLine(Oppai.ezpp_ar(ezpp));
            Console.WriteLine(Oppai.ezpp_od(ezpp));
            Console.WriteLine(Oppai.ezpp_cs(ezpp));
            Console.WriteLine(Oppai.ezpp_hp(ezpp));

            Console.WriteLine(Oppai.ezpp_title_str(ezpp));
            Console.WriteLine(Oppai.ezpp_artist_str(ezpp));
            Console.WriteLine(Oppai.ezpp_creator_str(ezpp));

            Oppai.ezpp_free(ezpp);

            Console.ReadLine();
        }
    }
}
