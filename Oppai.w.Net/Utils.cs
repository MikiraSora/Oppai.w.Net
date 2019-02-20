using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppaiWNet
{
    internal unsafe static class Utils
    {
        private static int Strlen(byte* p,int max_len=256)
        {
            int c = 0;
            while (*p++!=0 && c<max_len)
            {
                c++;
            }

            return c;
        }

        public static string Utf8Ptr2String(char* ptr)
        {
            var p = (byte*)ptr;
            var len = Strlen(p);

            return Encoding.UTF8.GetString(p, len);
        }
    }
}
