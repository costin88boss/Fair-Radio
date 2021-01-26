using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fair_Radio
{
    [HarmonyPatch(typeof(Radio), nameof(Radio.UseBattery))]
    internal static class FairRadio
    {
        static bool Prefix(Radio __instance)
        {
            if (__instance.isVoiceChatting || __instance.isTransmitting)
                return true;
            else return false;
        }
    }
}
