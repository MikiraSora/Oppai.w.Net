using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ezpp_t = System.IntPtr;

namespace OppaiWNet
{
    public unsafe static partial class Oppai
    {
        [DllImport("oppai.dll",CallingConvention =CallingConvention.Cdecl)]
        public static extern ezpp_t ezpp_new();

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_free(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ezpp(ezpp_t ez, string map);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ezpp_pp(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ezpp_stars(ezpp_t ez);

        /*
         * the above is all you need for basic usage. below are some advanced api's
         * and usage examples
         *
         * - if map is "-" the map is read from standard input
         * - you can use ezpp_data if you already have raw beatmap data in memory
         * - if map is 0 (NULL), difficulty calculation and map parsing are skipped
         *   and you must set at least mode, aim_stars, speed_stars, nobjects,
         *   base_ar, base_od, max_combo, nsliders, ncircles
         * - if aim_stars or speed_stars are set difficulty calculation is also
         *   skipped but values are taken from map
         * - setting mods or cs resets aim_stars and speed_stars, set those last
         * = setting end resets accuracy_percent
         * - if mode_override is set, std maps are converted to other modes
         * - mode defaults to MODE_STD or the map's mode
         * - mods default to MODS_NOMOD
         * - combo defaults to full combo
         * - nmiss defaults to 0
         * - score_version defaults to scorev1
         * - if accuracy_percent is set, n300/100/50 are automatically
         *   calculated and stored
         * - if n300/100/50 are set, accuracy_percent is automatically
         *   calculated and stored
         * - if none of the above are set, SS (100%) is assumed
         * - if end is set, the map will be cut to this object index
         * - if base_ar/od/cs are set, they will override the map's values
         */

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ezpp_data(ezpp_t ez, string data, int data_size);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ezpp_aim_stars(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ezpp_speed_stars(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ezpp_aim_pp(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ezpp_speed_pp(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ezpp_acc_pp(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ezpp_accuracy_percent(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ezpp_n300(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ezpp_n100(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ezpp_n50(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ezpp_nmiss(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ezpp_ar(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ezpp_cs(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ezpp_od(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ezpp_hp(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern char* ezpp_artist(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern char* ezpp_artist_unicode(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern char* ezpp_title(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern char* ezpp_title_unicode(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern char* ezpp_version(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern char* ezpp_creator(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ezpp_ncircles(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ezpp_nsliders(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ezpp_nspinners(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ezpp_nobjects(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ezpp_odms(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ezpp_mode(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ezpp_combo(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ezpp_max_combo(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ezpp_mods(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ezpp_score_version(ezpp_t ez);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ezpp_time_at(ezpp_t ez, int i);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ezpp_strain_at(ezpp_t ez, int i, int difficulty_type);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_aim_stars(ezpp_t ez, float aim_stars);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_speed_stars(ezpp_t ez, float speed_stars);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_base_ar(ezpp_t ez, float ar);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_base_od(ezpp_t ez, float od);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_base_cs(ezpp_t ez, float cs);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_base_hp(ezpp_t ez, float hp);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_mode_override(ezpp_t ez, int mode_override);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_mode(ezpp_t ez, int mode);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_mods(ezpp_t ez, int mods);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_combo(ezpp_t ez, int combo);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_nmiss(ezpp_t ez, int nmiss);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_score_version(ezpp_t ez, int score_version);
        
        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_accuracy_percent(ezpp_t ez, float accuracy_percent);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_accuracy(ezpp_t ez, int n100, int n50);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_end(ezpp_t ez, int end);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ezpp_set_end_time(ezpp_t ez, float end);
        
        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern char* errstr(int err);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void oppai_version(ref int major, ref int minor,ref int patch);

        [DllImport("oppai.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern char* oppai_version_str();
    }
}
