using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OppaiWNet
{
    public static unsafe partial class Oppai
    {
        const string OPPAI_LOWEST_VER = "3.1.0";

        static Oppai()
        {
            try
            {
                var cur_ver_str = string.Join(".", oppai_version());
                var cur_version = new Version(cur_ver_str);
                var chk_version = new Version(OPPAI_LOWEST_VER);

                if (cur_version<chk_version)
                {
                    //this oppai.dll can't be used
                    throw new Exception($"Oppai.w.Net requires oppai version {OPPAI_LOWEST_VER} or latest");
                }
            }
            catch 
            {
#if DEBUG
                throw;
#endif
            }
        }

        public static int[] oppai_version()
        {
            var ver = new int[3];
            oppai_version(ref ver[0], ref ver[1], ref ver[2]);
            return ver;
        }

        public static string ezpp_artist_str(IntPtr handle) => Marshal.PtrToStringAnsi(new IntPtr(ezpp_artist(handle)));

        public static string ezpp_artist_unicode_str(IntPtr handle) => Utils.Utf8Ptr2String(ezpp_artist_unicode(handle));

        public static string ezpp_title_str(IntPtr handle) => Marshal.PtrToStringAnsi(new IntPtr(ezpp_title(handle)));

        public static string ezpp_title_unicode_str(IntPtr handle) => Utils.Utf8Ptr2String(ezpp_title_unicode(handle));

        /// <summary>
        /// get beatmap difficult name.
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        public static string ezpp_version_str(IntPtr handle) => Marshal.PtrToStringAnsi(new IntPtr(ezpp_version(handle)));

        public static string ezpp_creator_str(IntPtr handle) => Marshal.PtrToStringAnsi(new IntPtr(ezpp_creator(handle)));

        public static string oppai_version_str_str() => Marshal.PtrToStringAnsi(new IntPtr(oppai_version_str()));

        public static string errstr_str(int err) => Marshal.PtrToStringAnsi(new IntPtr(errstr(err)));
    }
}
