using BepInEx;
using HarmonyLib;
using System.Reflection;

namespace SlapCityNoDI
{
    [BepInPlugin("com.steven.slapcity.noDI", "No DI", "1.0.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            var harmony = new Harmony("com.steven.slapcity.noDI");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}