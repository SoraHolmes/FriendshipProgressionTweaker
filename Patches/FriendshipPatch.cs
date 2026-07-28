using FriendshipProgressionTweaker.Core;
using HarmonyLib;
using StardewModdingAPI;
using StardewValley;

namespace FriendshipProgressionTweaker.Patches;

public static class FriendshipPatch
{
    public static void Apply(Harmony harmony)
    {
        var method =
            AccessTools.Method(
                typeof(Farmer),
                "changeFriendship",
                new[]
                {
            typeof(int),
            typeof(NPC)
                }
            );

        if (method == null)
        {
            return;
        }


        harmony.Patch(
            method,

            prefix: new HarmonyMethod(
                typeof(FriendshipPatch),
                nameof(Prefix)
            ),

            postfix: new HarmonyMethod(
                typeof(FriendshipPatch),
                nameof(Postfix)
            )
        );
    }


    private static void Prefix(
        ref int amount,
        NPC n
    )
    {
        if (!Context.IsWorldReady)
            return;

        if (!ModEntry.Config.Enabled)
            return;

        if (amount <= 0)
            return;

        if (n == null)
            return;

        FriendshipSource source = FriendshipSourceTracker.Current;

        // In Stardew Valley 1.6, tested item-delivery quest rewards reach
        // Farmer.changeFriendship as Talking or Other instead of Quest.
        // Restrict the fallback to large positive gains so normal dialogue,
        // gifts, and events keep their own source categories.
        if (amount >= 100 && amount <= 300 &&
            (source == FriendshipSource.Talking ||
             source == FriendshipSource.Other))
        {
            source = FriendshipSource.Quest;
        }

        ModEntry.Instance.Monitor.Log(
            $"Friendship change: NPC={n.Name}, Amount={amount}, Source={source}",
            LogLevel.Debug
        );

        if (source == FriendshipSource.Other)
        {
            return;
        }

        amount =
            ModEntry.Scale(
                n.Name,
                amount,
                source
            );
    }


    private static void Postfix()
    {
        FriendshipSourceTracker.Reset();
    }   
}