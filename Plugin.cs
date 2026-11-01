using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace RealCSTrainingMod
{
    [BepInPlugin("com.sverint.realcsmod", "Real CS Training Mod", "1.0.0")]
    public class Plugin : BasePlugin
    {
        private readonly Harmony _harmony = new Harmony("com.sverint.realcsmod");

        public override void Load()
        {
            Log.LogInfo("=======================================");
            Log.LogInfo("=== REAL CS MOD УСПЕШНО ЗАГРУЖЕН! ===");
            Log.LogInfo("=======================================");

            _harmony.PatchAll();
        }
    }
}