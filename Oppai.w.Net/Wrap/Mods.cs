using System;

namespace OppaiWNet.Wrap
{
    [Flags]
    public enum Mods
    {
        NONE = 0,
        NF = 1<<0,
        EZ = 1<<1,
        TD = 1<<2,
        HD = 1<<3,
        HR = 1<<4,
        SD = 1<<5,
        DT = 1<<6,
        RX = 1<<7,
        HT = 1<<8,
        NC = 1<<9,
        FL = 1<<10,
        AT = 1<<11,
        SO = 1<<12,
        AP = 1<<13,
        PF = 1<<14,
        KEY4 = 1<<15,
        KEY5 = 1<<16,
        KEY6 = 1<<17,
        KEY7 = 1<<18,
        KEY8 = 1<<19,
        FADEIN = 1<<20,
        RANDOM = 1<<21,
        CINEMA = 1<<22,
        TARGET = 1<<23,
        KEY9 = 1<<24,
        KEYCOOP = 1<<25,
        KEY1 = 1<<26,
        KEY3 = 1<<27,
        KEY2 = 1<<28,
        SCOREV2 = 1<<29,
        TOUCH_DEVICE = TD,
        NOVIDEO = TD,
        SPEED_CHANGING = DT|HT|NC,
        MAP_CHANGING = HR|EZ|SPEED_CHANGING,
    }
}