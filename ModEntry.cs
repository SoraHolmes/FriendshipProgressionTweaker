using FriendshipProgressionTweaker.Core;
using GenericModConfigMenu;
using HarmonyLib;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using System;

namespace FriendshipProgressionTweaker;
public class ModEntry : Mod
{

    public static ModConfig Config = null!;

    public static ModEntry Instance { get; private set; } = null!;

    public override void Entry(IModHelper helper)
    {
        Instance = this;

        Config = helper.ReadConfig<ModConfig>();

        helper.Events.GameLoop.GameLaunched += OnGameLaunched;

        helper.ConsoleCommands.Add(
        "fptoggle",
         "Toggle FriendshipProgressionTweaker on/off.",
         ToggleCommand
);

        Harmony harmony = new(ModManifest.UniqueID);

        Patches.TalkPatch.Apply(harmony);
        Patches.GiftPatch.Apply(harmony);
        Patches.QuestPatch.Apply(harmony);
        Patches.EventPatch.Apply(harmony);
        Patches.FriendshipPatch.Apply(harmony);

        Monitor.Log(
            "FriendshipProgressionTweaker loaded.",
            LogLevel.Info
        );
    }

    private void AddSlider(
        IGenericModConfigMenuApi api,
        string name,
        string id,
        Action<int> setter,
        Func<int> getter
    )
    {
        api.AddNumberOption(
            ModManifest,

            getValue: getter,

            setValue: setter,

            name: () => name,

            tooltip: () =>
                $"Friendship progression percentage ({id}).",

            min: 0,

            max: 200,

            interval: 5
        );
    }

    private void OnGameLaunched(
    object? sender,
    GameLaunchedEventArgs e
    )
    {
        SetupConfigMenu();
    }

    private void SetupConfigMenu()
    {
        IGenericModConfigMenuApi? api =
            Helper.ModRegistry.GetApi<IGenericModConfigMenuApi>(
             "spacechase0.GenericModConfigMenu"
         );

        if (api == null)
            return;


        api.Register(
            ModManifest,

            reset: () =>
            {
                Config = new ModConfig();
            },

            save: () =>
            {
                Helper.WriteConfig(Config);
            }
        );

        api.AddBoolOption(

            ModManifest,
            getValue: () => Config.Enabled,
            setValue: value => Config.Enabled = value,
            name: () => "Enable Friendship Scaling",
            tooltip: () => "Toggle friendship progression changes."
        );

        AddSlider(api,
            "Gift 0-2 Hearts",
            "Gift_0_2",
            value => Config.Gift_0_2 = value,
            () => Config.Gift_0_2
        );




        AddSlider(api,
            "Gift 2-4 Hearts",
            "Gift_2_4",
            value => Config.Gift_2_4 = value,
            () => Config.Gift_2_4
        );



        AddSlider(api,
            "Gift 4-6 Hearts",
            "Gift_4_6",
            value => Config.Gift_4_6 = value,
            () => Config.Gift_4_6
        );



        AddSlider(api,
            "Gift 6-8 Hearts",
            "Gift_6_8",
            value => Config.Gift_6_8 = value,
            () => Config.Gift_6_8
        );


        AddSlider(api,
            "Gift 8-10 Hearts",
            "Gift_8_10",
            value => Config.Gift_8_10 = value,
            () => Config.Gift_8_10
        );

        AddSlider(api,
            "Gift 10-12 Hearts (Romance)",
            "Gift_10_12",
             value => Config.Gift_10_12 = value,
             () => Config.Gift_10_12
        );

        AddSlider(
            api,
            "Gift 12-14 Hearts (Romance)",
            "Gift_12_14",
            value => Config.Gift_12_14 = value,
            () => Config.Gift_12_14
        );



        AddSlider(api,
            "Talk 0-2 Hearts",
            "Talk_0_2",
            value => Config.Talk_0_2 = value,
            () => Config.Talk_0_2
        );



        AddSlider(api,
            "Talk 2-4 Hearts",
            "Talk_2_4",
            value => Config.Talk_2_4 = value,
            () => Config.Talk_2_4
        );



        AddSlider(api,
            "Talk 4-6 Hearts",
            "Talk_4_6",
            value => Config.Talk_4_6 = value,
            () => Config.Talk_4_6
        );



        AddSlider(api,
            "Talk 6-8 Hearts",
            "Talk_6_8",
            value => Config.Talk_6_8 = value,
            () => Config.Talk_6_8
        );


        AddSlider(api,
            "Talk 8-10 Hearts",
            "Talk_8_10",
            value => Config.Talk_8_10 = value,
            () => Config.Talk_8_10
        );
        AddSlider(api,
            "Talking 10-12 Hearts (Romance)",
            "Talk_10_12",
            value => Config.Talk_10_12 = value,
             () => Config.Talk_10_12
        );


        AddSlider(api,
            "Talking 12-14 Hearts (Romance)",
            "Talk_12_14",
            value => Config.Talk_12_14 = value,
            () => Config.Talk_12_14
        );

        AddSlider(
            api,
            "Quest 0-2 Hearts",
            "Quest_0_2",
            v => Config.Quest_0_2 = v,
            () => Config.Quest_0_2
        );

        AddSlider(
            api,
            "Quest 2-4 Hearts",
            "Quest_2_4",
            v => Config.Quest_2_4 = v,
            () => Config.Quest_2_4
        );

        AddSlider(
            api,
            "Quest 4-6 Hearts",
            "Quest_4_6",
            v => Config.Quest_4_6 = v,
            () => Config.Quest_4_6
        );

        AddSlider(
            api,
            "Quest 6-8 Hearts",
            "Quest_6_8",
            v => Config.Quest_6_8 = v,
            () => Config.Quest_6_8
        );

        AddSlider(
            api,
            "Quest 8-10 Hearts",
            "Quest_8_10",
            v => Config.Quest_8_10 = v,
            () => Config.Quest_8_10
        );

        AddSlider(api,
            "Quest 10-12 Hearts (Romance)",
            "Quest_10_12",
            value => Config.Quest_10_12 = value,
             () => Config.Quest_10_12
        );

        AddSlider(api,
            "Quest 12-14 Hearts (Romance)",
            "Quest_12_14",
            value => Config.Quest_12_14 = value,
            () => Config.Quest_12_14
        );

        AddSlider(
            api,
            "Event 0-2 Hearts",
            "Event_0_2",
            v => Config.Event_0_2 = v,
            () => Config.Event_0_2
        );

        AddSlider(
            api,
            "Event 2-4 Hearts",
            "Event_2_4",
            v => Config.Event_2_4 = v,
            () => Config.Event_2_4
        );

        AddSlider(
            api,
            "Event 4-6 Hearts",
            "Event_4_6",
            v => Config.Event_4_6 = v,
            () => Config.Event_4_6
        );

        AddSlider(
            api,
            "Event 6-8 Hearts",
            "Event_6_8",
            v => Config.Event_6_8 = v,
            () => Config.Event_6_8
        );

        AddSlider(
            api,
            "Event 8-10 Hearts",
            "Event_8_10",
            v => Config.Event_8_10 = v,
            () => Config.Event_8_10
        );

        AddSlider(
            api,
            "Event 10-12 Hearts (Romance)",
            "Event_10_12",
            v => Config.Event_10_12 = v,
            () => Config.Event_10_12
        );

        AddSlider(
            api,
            "Event 12-14 Hearts (Romance)",
            "Event_12_14",
            v => Config.Event_12_14 = v,
            () => Config.Event_12_14
        );
    }

    public static int GetMultiplier(
        string npcName,
        FriendshipSource source
    )
    {
        if (!Context.IsWorldReady)
            return 100;

        if (Game1.player == null)
            return 100;

        if (!Game1.player.friendshipData.TryGetValue(
            npcName,
            out var friendship
        ))
        {
            return 100;
        }

        int hearts =
            Math.Max(0, friendship.Points / 250);


        int stage;


        // Normal NPC progression
        if (hearts < 10)
        {
            stage = hearts / 2;
        }
        else
        {
            // 10+ hearts only allowed for romance NPCs
            if (!IsRomanceableNPC(npcName))
            {
                stage = 4;
            }
            else if (hearts < 12)
            {
                stage = 5;
            }
            else
            {
                stage = 6;
            }
        }


        int[] values = source switch
        {
            FriendshipSource.Gift =>
                Config.GetGiftValues(),

            FriendshipSource.Talking =>
                Config.GetTalkValues(),

            FriendshipSource.Quest =>
                Config.GetQuestValues(),

            FriendshipSource.Event =>
                Config.GetEventValues(),

            _ =>
                new[] { 100 }
        };


        if (stage < 0)
            stage = 0;


        if (stage >= values.Length)
            stage = values.Length - 1;


        return values[stage];
    }

    public static int Scale(
        string npc,
        int amount,
        FriendshipSource source
    )
    {
        if (!Config.Enabled)
            return amount;


        return amount *
            GetMultiplier(npc, source)
            / 100;
    }

    private static bool IsRomanceableNPC(string npcName)
    {
        NPC? npc =
            Game1.getCharacterFromName(npcName);


        if (npc == null)
            return false;


        return npc.datable.Value;
    }
    private void ToggleCommand(
        string command,
        string[] args
    )
    {
        Config.Enabled = !Config.Enabled;

        Helper.WriteConfig(Config);


        Monitor.Log(
            Config.Enabled
            ? "FriendshipProgressionTweaker enabled."
            : "FriendshipProgressionTweaker disabled.",
            LogLevel.Info
        );
    }

}