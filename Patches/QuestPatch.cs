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
        {
            return;
        }


        harmony.Patch(
            method,

            postfix: new HarmonyMethod(
                typeof(QuestPatch),
                nameof(Postfix)
            )
        );
    }


    private static void Postfix()
    {
        FriendshipSourceTracker.Set(
            FriendshipSource.Quest
        );
    }
}