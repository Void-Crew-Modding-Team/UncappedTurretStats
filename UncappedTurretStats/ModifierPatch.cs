using Gameplay.Utilities;
using HarmonyLib;

namespace UncappedTurretStats
{
    [HarmonyPatch(typeof(PipModifiableFloat), "CapPips")] //Pips are internally capped. This skips the cap.
    internal class ModifierPatch
    {
        [HarmonyPrefix]
        static bool Patch(int val, ref int __result)
        {
            __result = val;
            return false;
        }
    }
}
