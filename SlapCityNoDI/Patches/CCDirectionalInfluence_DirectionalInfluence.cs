using HarmonyLib;
using Smash;

namespace SlapCityNoDI.Patches
{
    [HarmonyPatch(typeof(CCDirectionalInfluence), "DirectionalInfluence")]
    class CCDirectionalInfluence_DirectionalInfluence
    {
        static bool Prefix() => false;
    }
}
