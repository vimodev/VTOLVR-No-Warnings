using Harmony;

namespace NoWarnings
{

    // Patch the FlightWarnings class such that flight warnings are cleared every frame.
    [HarmonyPatch(typeof(FlightWarnings))]
    [HarmonyPatch("Update")]
    public class Patch0
    {
        public static bool Prefix(FlightWarnings __instance)
        {
            __instance.ClearWarnings();
            return true;
        }
    }

    // Patch the CollisionDetector class such that it never detects a collision.
    [HarmonyPatch(typeof(CollisionDetector))]
    [HarmonyPatch("GetCollisionDetected")]
    public class Patch1
    {
        public static bool Prefix(ref bool __result)
        {
            __result = false;
            return false;
        }
    }



}
