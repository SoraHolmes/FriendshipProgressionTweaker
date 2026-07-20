using FriendshipProgressionTweaker.Core;
using HarmonyLib;
using StardewValley;

namespace FriendshipProgressionTweaker.Patches;

public static class GiftPatch
{
    public static void Apply(Harmony harmony)
    {
        var method =
            AccessTools.Method(
                typeof(Utility),
                "modifyFriendshipForGift"
            );

        if (method == null)
            return;


        harmony.Patch(
            method,

            prefix: new HarmonyMethod(
                typeof(GiftPatch),
                nameof(Prefix)
            ),

            postfix: new HarmonyMethod(
                typeof(GiftPatch),
                nameof(Postfix)
            )
        );
    }


    private static void Prefix()
    {
        FriendshipSourceTracker.Set(
            FriendshipSource.Gift
        );
    }


    private static void Postfix()
    {
        FriendshipSourceTracker.Reset();
    }
}