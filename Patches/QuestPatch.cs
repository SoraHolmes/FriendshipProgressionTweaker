using FriendshipProgressionTweaker.Core;
using HarmonyLib;
using StardewValley.Quests;

namespace FriendshipProgressionTweaker.Patches;

public static class QuestPatch
{
    public static void Apply(Harmony harmony)
    {
        var method =
            AccessTools.Method(
                typeof(Quest),
                "questComplete"
            );

        if (method == null)
            return;

        harmony.Patch(
            method,

            prefix: new HarmonyMethod(
                typeof(QuestPatch),
                nameof(Prefix)
            )
        );
    }

    private static void Prefix()
    {
        FriendshipSourceTracker.Set(
            FriendshipSource.Quest
        );
    }
}