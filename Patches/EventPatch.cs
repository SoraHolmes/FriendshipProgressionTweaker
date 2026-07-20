using FriendshipProgressionTweaker.Core;
using HarmonyLib;
using StardewValley;

namespace FriendshipProgressionTweaker.Patches;

public static class EventPatch
{
    public static void Apply(Harmony harmony)
    {
        var method =
            AccessTools.Method(
                typeof(Event),
                "setUp"
            );


        if (method == null)
            return;


        harmony.Patch(
            method,

            postfix: new HarmonyMethod(
                typeof(EventPatch),
                nameof(Postfix)
            )
        );
    }


    private static void Postfix()
    {
        FriendshipSourceTracker.Set(
            FriendshipSource.Event
        );
    }
}