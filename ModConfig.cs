namespace FriendshipProgressionTweaker;

public class ModConfig
{
    public int ConfigVersion { get; set; } = 1;

    public bool Enabled { get; set; } = true;

    public bool Debug { get; set; } = false;


    // Gift progression %
    public int Gift_0_2 { get; set; } = 100;
    public int Gift_2_4 { get; set; } = 90;
    public int Gift_4_6 { get; set; } = 75;
    public int Gift_6_8 { get; set; } = 60;
    public int Gift_8_10 { get; set; } = 50;
    // Romance NPC only (10-12 hearts)
    public int Gift_10_12 { get; set; } = 40;
    // Romance NPC only (12-14 hearts)
    public int Gift_12_14 { get; set; } = 25;


    // Talking progression %
    public int Talk_0_2 { get; set; } = 100;
    public int Talk_2_4 { get; set; } = 90;
    public int Talk_4_6 { get; set; } = 80;
    public int Talk_6_8 { get; set; } = 70;
    public int Talk_8_10 { get; set; } = 60;
    // Romance NPC only (10-12 hearts)
    public int Talk_10_12 { get; set; } = 50;
    // Romance NPC only (12-14 hearts)
    public int Talk_12_14 { get; set; } = 40;


    // Quest progression %
    public int Quest_0_2 { get; set; } = 100;
    public int Quest_2_4 { get; set; } = 90;
    public int Quest_4_6 { get; set; } = 75;
    public int Quest_6_8 { get; set; } = 50;
    public int Quest_8_10 { get; set; } = 25;
    // Romance NPC only (10-12 hearts)
    public int Quest_10_12 { get; set; } = 20;
    // Romance NPC only (12-14 hearts)
    public int Quest_12_14 { get; set; } = 10;


    // Event progression %
    public int Event_0_2 { get; set; } = 100;
    public int Event_2_4 { get; set; } = 90;
    public int Event_4_6 { get; set; } = 75;
    public int Event_6_8 { get; set; } = 50;
    public int Event_8_10 { get; set; } = 25;
    // Romance NPC only (10-12 hearts)
    public int Event_10_12 { get; set; } = 20;
    // Romance NPC only (12-14 hearts)
    public int Event_12_14 { get; set; } = 10;


    public int[] GetGiftValues()
    {
        return new[]
        {
            Gift_0_2,
            Gift_2_4,
            Gift_4_6,
            Gift_6_8,
            Gift_8_10,
            Gift_10_12,
            Gift_12_14
        };
    }


    public int[] GetTalkValues()
    {
        return new[]
        {
            Talk_0_2,
            Talk_2_4,
            Talk_4_6,
            Talk_6_8,
            Talk_8_10,
            Talk_10_12,
            Talk_12_14
        };
    }


    public int[] GetQuestValues()
    {
        return new[]
        {
            Quest_0_2,
            Quest_2_4,
            Quest_4_6,
            Quest_6_8,
            Quest_8_10,
            Quest_10_12,
            Quest_12_14
        };
    }


    public int[] GetEventValues()
    {
        return new[]
        {
            Event_0_2,
            Event_2_4,
            Event_4_6,
            Event_6_8,
            Event_8_10,
            Event_10_12,
            Event_12_14
        };
    }
}