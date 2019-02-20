using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OppaiWNet.Oppai;

namespace OppaiWNet.Wrap
{
    public class Ezpp
    {
        IntPtr handle;

        #region Contruction/Deconstruction

        public Ezpp()
        {
            handle=ezpp_new();
        }

        public Ezpp(string osu_file_path) : this() => LoadOsuFile(osu_file_path);

        ~Ezpp()
        {
            ezpp_free(handle);
        }

        #endregion

        public void LoadOsuFile(string osu_file_path) => ezpp(handle, osu_file_path);

        public float PP => ezpp_pp(handle);

        public float DiffRate => ezpp_stars(handle);

        public float Stars => ezpp_stars(handle);

        public float AimStars { get => ezpp_aim_stars(handle); set => ezpp_set_aim_stars(handle, value); }

        public float SpeedStars { get => ezpp_speed_stars(handle); set => ezpp_set_speed_stars(handle, value); }

        public float AimPP => ezpp_aim_pp(handle);

        public float SpeedPP => ezpp_speed_pp(handle);

        public float AccPP => ezpp_acc_pp(handle);

        public float Acc
        {
            get => ezpp_accuracy_percent(handle);
            set => ezpp_set_accuracy_percent(handle, value);
        }

        public int Count300 => ezpp_n300(handle);
        public int Count100 { get => ezpp_n100(handle); set => ezpp_set_accuracy(handle, value, Count50); }
        public int Count50 { get => ezpp_n50(handle); set => ezpp_set_accuracy(handle, Count100, value); }
        public int CountMiss { get => ezpp_nmiss(handle); set => ezpp_set_nmiss(handle, value); }

        public int Combo { get => ezpp_combo(handle); set => ezpp_set_combo(handle, value); }
        public int MaxCombo => ezpp_max_combo(handle);

        public float AR { get => ezpp_ar(handle); set => ezpp_set_base_ar(handle, value); }
        public float CS { get => ezpp_cs(handle); set => ezpp_set_base_cs(handle, value); }
        public float OD { get => ezpp_od(handle); set => ezpp_set_base_od(handle, value); }
        public float HP { get => ezpp_hp(handle); set => ezpp_set_base_hp(handle, value); }

        public string Artist => ezpp_artist_str(handle);
        public string ArtistUnicode => ezpp_artist_unicode_str(handle);
        public string Title => ezpp_title_str(handle);
        public string TitleUnicode => ezpp_title_unicode_str(handle);

        public string Version => ezpp_version_str(handle);
        public string Creator => ezpp_creator_str(handle);

        public int CountCircles => ezpp_ncircles(handle);
        public int CountSliders => ezpp_nsliders(handle);
        public int CountSpinners => ezpp_nspinners(handle);
        public int CountObjects => ezpp_nobjects(handle);

        public float ObjectFadeTime => ezpp_odms(handle);

        public Mods Mods { get => (Mods)ezpp_mods(handle); set => ezpp_set_mods(handle, (int)value); }

        public int ScoreVersion
        {
            get => ezpp_score_version(handle);
            set => ezpp_set_score_version(handle, value);
        }

        public int Mode { get => ezpp_mode(handle); set => ezpp_set_mode(handle, value); }

        public float GetTimeFromObjectIndex(int object_index) => ezpp_time_at(handle, object_index);

        public float GetStrainFromObjectIndex(int object_index, int difficulty_type) => ezpp_strain_at(handle, object_index, difficulty_type);

        public void SetEnd(int end) => ezpp_set_end(handle, end);

        public void SetModeOverride(int mode) => ezpp_set_mode_override(handle, mode);

        public void SetEndTime(int end_time) => ezpp_set_end_time(handle, end_time);

        public string TitleAvaliable {
            get {
                var x = TitleUnicode;
                return string.IsNullOrWhiteSpace(x) ? Title : x;
            }
        }

        public string ArtistAvaliable
        {
            get
            {
                var x = ArtistUnicode;
                return string.IsNullOrWhiteSpace(x) ? Artist : x;
            }
        }
    }
}
