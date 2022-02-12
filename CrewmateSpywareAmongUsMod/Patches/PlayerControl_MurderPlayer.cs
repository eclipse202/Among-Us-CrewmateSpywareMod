using HarmonyLib;

namespace CrewmateSpywareMod.Patches
{
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.MurderPlayer))]
    internal class PlayerControl_MurderPlayer
    {
        [HarmonyPrefix]
        internal static bool Prefix(PlayerControl __instance, PlayerControl target)
        {
            Main.Logger.LogMessage(__instance.Data.PlayerName + " killed " + target.name);
            HudManager.Instance.ShowPopUp(__instance.Data.PlayerName + " killed " + target.name);
            return true;
        }
    }
}
