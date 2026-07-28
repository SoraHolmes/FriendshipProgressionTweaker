# FriendshipProgressionTweaker
First (and probably last) mod and/or repository for personal use that I "created" with the help of ChatGPT and inspired by [DifficultySocializing](https://www.nexusmods.com/stardewvalley/mods/24389?tab=posts) ([PokeBenji](https://www.nexusmods.com/profile/PokeBenji)).

# Description

FriendshipProgressionTweaker lets you customize how quickly friendship points are gained in Stardew Valley.

Instead of using one multiplier for every friendship level, the mod allows you to set separate percentages for each two-heart range:

- 0–2 hearts
- 2–4 hearts
- 4–6 hearts
- 6–8 hearts
- 8–10 hearts
- 10–12 hearts
- 12–14 hearts

Separate scaling options are available for:

- Gifts
- Conversations
- Quests
- Events

This makes it possible to slow friendship progression down gradually, keep the early stages more generous, or create your own progression balance.


# Tested Features

The following friendship sources have been tested in-game:

- Regular conversations
- Regular gifts
- Birthday gifts
- Help Wanted board item-delivery quests
- Item-delivery quests received by letter
- Weekly Special Orders

Each tested source correctly uses its own configured category and the percentage for the NPC's current heart range.

Event friendship scaling is included in the configuration, but has not yet been fully tested and should currently be considered experimental.

# Installation instructions

Install the latest version of [SMAPI](https://smapi.io).
Install[Generic Mod Config Menu (GMCM)](https://www.nexusmods.com/stardewvalley/mods/5098) to configure the mod.
(Optional) [Lookup Anything](https://www.nexusmods.com/stardewvalley/mods/541), press F2 on NPC to see if mod works as intended / fn+F1 on laptop
(can be used to check an NPC's exact friendship points before and after an interaction because SMAPI shows Vanilla points)
Unzip the mod folder into Stardew Valley/Mods.
Run the game using [SMAPI](https://smapi.io).

# Main features
Gaining a Friendship Points via Milestone/Progression/Scaler per 2 Hearts with adjustable percentage from Gifting, Talking, Quest and Event (like dialogue choices or special days).

# Requirements
the latest version of SMAPI
Generic Mod Config Menu

# WHY?
I don't know which head or tail about programming/coding, that's why, with the help of ChatGPT (yeah, I know) and inspired by a Mod called [DifficultySocializing](https://www.nexusmods.com/stardewvalley/mods/24389?tab=posts) by [PokeBenji](https://www.nexusmods.com/profile/PokeBenji), this mod could exist. Only beginning to play Stardew Valley, realizing that friendship points gained by gifting (more so on birthday and gold quality stuff), like way too much by my standard, raising it from 2 hearts to 5 hearts, just like that was already done within 2 weeks in Spring. Year 1. I'm thinking, "No, I thought this game had the definition of cozy, but that doesn't align with you, taking your time, that later on the NPC will just become a husk."

# Nothing on Nexus Mods
Searching mod on [Nexus Mods](https://www.nexusmods.com), trying to find with the name "Progression","Scaling","Friendship","Points","Hearts""Social", the result??? so little, almost none that fit my needs. There was mod that make friendship easier, or improve UI on them, or others. The similiar mod compare what I have now, the closest one is [Friendship Tweaks](https://www.nexusmods.com/stardewvalley/mods/17055) and [DifficultySocializing](https://www.nexusmods.com/stardewvalley/mods/24389?tab=posts), the former have what I have in mind but no scaling while the latter one was outated (I think?), because the scale option doesn't work anymore for me and you can't setting in-game and only on the menu (while mine works both).

# I tried
So, that's why this mod was born from scratch with 0% skill on both programming and coding, never use Visual Studio or SMAPI, never use ChatGPT before, not good at English or making a statement, or using this GitHub website, I was desperate to make a Friendship Progression/Scaler Percentage every 2 Hearts Mods (MOUTHful).

# images
Well...... as you can see. This is the UI with the help of [Generic Mod Config Menu (GMCM)](https://www.nexusmods.com/stardewvalley/mods/5098)
<img width="1915" height="1055" alt="00" src="https://github.com/user-attachments/assets/80726ca1-0f10-4e73-8579-fc695e2a813c" />
<img width="1917" height="1061" alt="01" src="https://github.com/user-attachments/assets/375b5828-b4e7-4b72-b1ee-7bfd540df352" />
<img width="1913" height="1057" alt="02" src="https://github.com/user-attachments/assets/6f2fcdf8-cc83-4657-be38-646687d1c69b" />

# Adjustable (Slider)
Yup, there is slider to adjust how much percentage for every 2 hearts. Maximum number is 200% which give you double the amount or 0% which give you nothing. Adjust however you want, again thanks to [Generic Mod Config Menu (GMCM)](https://www.nexusmods.com/stardewvalley/mods/5098).

# How do you know it's working???
Well thanks to this mod, [Lookup Anything](https://www.nexusmods.com/stardewvalley/mods/541) I could test it directly on NPC(Of course it's Linus) by pressing F2 to check their "Info" about their "pts" until the next Heart.

# Example
Take a "look" at Linus here, which already 2 hearts, meaning his progression already at the stage of 2-4 Hearts.
<img width="1287" height="731" alt="03" src="https://github.com/user-attachments/assets/102f5492-9bd6-42dd-8c68-86ee7ef523c6" />

If I am talking to him right now with this setup, we will only gain 16 pts from 80% instead the normal 20 pts 100%.
<img width="1915" height="1053" alt="04" src="https://github.com/user-attachments/assets/faf1ed27-8b90-42fe-a176-33d624a68be5" />
<img width="1283" height="711" alt="05-Cafter" src="https://github.com/user-attachments/assets/4d933829-bf9e-4f7c-83e0-d30eb50bfe15" />

If I adjust it less to 10%, we only got 2 pts.
<img width="1913" height="1057" alt="06" src="https://github.com/user-attachments/assets/d6614d04-adbd-48a5-8231-9405e8d818ca" />
<img width="1293" height="721" alt="07" src="https://github.com/user-attachments/assets/acfc8cc0-8378-4061-88cd-b508d7e4998e" />

# Credits

Original creator:
- [SoraHolmes](https://www.nexusmods.com/profile/SoraHolmes)

Additional development and testing:
- [Mememerimo](https://www.nexusmods.com/profile/Mememerimo)

Inspired by:
- [PokeBenji](https://www.nexusmods.com/profile/PokeBenji)

# That's it
Will share the source code here (I don't even know what that's mean lol), bye.

