using BepInEx;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;
using System.Diagnostics;
using UnhollowerRuntimeLib;

namespace CrewmateSpywareMod
{
    [BepInPlugin("Eclipse.AmongUsCrewmateSpyware", "Crewmate Spyware Mod", "1.0.0")]
    internal class Main : BasePlugin
    {
        public Harmony Harmony { get; } = new Harmony("Eclipse.AmongUsCrewmateSpyware");
        internal static ManualLogSource Logger { get => instance.Log; }
        internal static Main instance;

        public override void Load()
        {
            instance = this;
            Harmony.PatchAll();

            ClassInjector.RegisterTypeInIl2Cpp<SusDetector>();
        }
    }
}
