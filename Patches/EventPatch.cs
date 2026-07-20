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

            prefix: new HarmonyMethod(
                typeof(EventPatch),
                nameof(Prefix)
            )
        );
    }

    private static void Prefix()
    {
        FriendshipSourceTracker.Set(
            FriendshipSource.Event
        );
    }
}