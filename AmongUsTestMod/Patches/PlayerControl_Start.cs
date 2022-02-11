using CrewmateSpywareMod;
using HarmonyLib;
[HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.Start))]
internal class PlayerControl_Start
{
    public static SusDetector detector;

    [HarmonyPostfix]
    internal static void Postfix(PlayerControl __instance)
    {
        if (detector == null)
        {
            detector = __instance.gameObject.AddComponent<SusDetector>();
        }
    }
}