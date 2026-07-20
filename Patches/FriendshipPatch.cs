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

        ModEntry.Instance.Monitor.Log(
            $"Friendship change: NPC={n.Name}, Amount={amount}, Source={FriendshipSourceTracker.Current}",
            LogLevel.Debug
        );

        if (FriendshipSourceTracker.Current ==
            FriendshipSource.Other)
        {
            return;
        }

        amount =
            ModEntry.Scale(
                n.Name,
                amount,
                FriendshipSourceTracker.Current
            );
    }


    private static void Postfix()
    {
        FriendshipSourceTracker.Reset();
    }   
}