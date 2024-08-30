using BepInEx;
using HarmonyLib;
using System.Reflection;
using System;
using UnityEngine.Rendering;
using BoplFixedMath;

namespace Suck
{
    [BepInPlugin("com.maxgamertyper1.suck", "Suck", "1.0.0")]
    public class Suck : BaseUnityPlugin
    {
        private void Log(string message)
        {
            Logger.LogInfo(message);
        }

        private void Awake()
        {
            // Plugin startup logic
            Log($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

            DoPatching();
        }

        private void DoPatching()
        {
            var harmony = new Harmony("com.maxgamertyper1.suck");

            Patch(harmony, typeof(Shockwave), "Awake", "shockwavepatch", false);
        }

        private void OnDestroy()
        {
            Log($"Bye Bye From {PluginInfo.PLUGIN_GUID}");
        }

        private void Patch(Harmony harmony, Type OriginalClass , string OriginalMethod, string PatchMethod, bool prefix)
        {
            MethodInfo MethodToPatch = AccessTools.Method(OriginalClass, OriginalMethod); // the method to patch
            MethodInfo Patch = AccessTools.Method(typeof(Patches), PatchMethod);
            if (prefix)
            {
                harmony.Patch(MethodToPatch, new HarmonyMethod(Patch));
            }
            else
            {
                harmony.Patch(MethodToPatch, null, new HarmonyMethod(Patch));
            }
            Log($"Patched {OriginalMethod} in {OriginalClass.ToString()}");
        }
    }

    public class Patches
    {
        public static void shockwavepatch(ref Shockwave __instance)
        {
            System.Diagnostics.Debug.Print($"default force: {__instance.defaultForce}, platform force: {__instance.platformForce}");
            __instance.defaultForce = __instance.defaultForce*(Fix)(-1);
            __instance.platformForce = __instance.platformForce*(Fix)(-1);
        }
    }
}
