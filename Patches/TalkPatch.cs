using FriendshipProgressionTweaker.Core;
using HarmonyLib;
using StardewValley;

namespace FriendshipProgressionTweaker.Patches;

public static class TalkPatch
{
    public static void Apply(Harmony harmony)
    {
        var method =
            AccessTools.Method(
                typeof(NPC),
                "checkAction"
            );


        if (method == null)
            return;


        harmony.Patch(
            method,

            postfix: new HarmonyMethod(
                typeof(TalkPatch),
                nameof(Postfix)
            )
        );
    }


    private static void Postfix(
        NPC __instance
    )
    {
        if (__instance == null)
            return;


        FriendshipSourceTracker.Set(
            FriendshipSource.Talking
        );
    }
}