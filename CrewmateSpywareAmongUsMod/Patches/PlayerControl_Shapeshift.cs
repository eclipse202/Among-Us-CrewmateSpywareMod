using CrewmateSpywareMod;
using HarmonyLib;

[HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.Shapeshift))]
internal class PlayerControl_Shapeshift
{
    [HarmonyPrefix]
    internal static bool Prefix(PlayerControl __instance, PlayerControl targetPlayer)
    {          
        if (__instance.name == targetPlayer.name)
        {
            Main.Logger.LogMessage(__instance.Data.PlayerName + " is no longer disguised as " + targetPlayer.name);
            return true;
        }
        Main.Logger.LogMessage(__instance.Data.PlayerName + " has shifted into " + targetPlayer.name);
        PlayerControl_Start.detector.SetImposter(__instance.Data.PlayerName);
        return true;
    }
}

