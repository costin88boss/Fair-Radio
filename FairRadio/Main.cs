using Exiled.API.Features;
using Exiled.Loader;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fair_Radio
{
    
    class Main : Plugin<Config>
    {

        private int _PatchesCounter;
        Harmony Harmony { get; set; }

        void Patch()
        {
            try
            {
                Harmony = new Harmony($"Fair_Radio{++_PatchesCounter}");
                var Lastdebugstatus = Harmony.DEBUG;
                Harmony.DEBUG = true;
                Harmony.PatchAll();
                Harmony.DEBUG = Lastdebugstatus;
                Log.Debug("applied patch", Loader.ShouldDebugBeShown);
            }
            catch (Exception e)
            {
                Log.Debug("ERROR, COULDN'T PATCH: " + e);
            }
        }
        void UnPatch()
        {
            Harmony.UnpatchAll();
            Log.Debug("unapplied patch", Loader.ShouldDebugBeShown);
        }

        public override void OnEnabled()
        {
            Patch();
        }
        public override void OnDisabled()
        {
            UnPatch();
        }
    }
}
