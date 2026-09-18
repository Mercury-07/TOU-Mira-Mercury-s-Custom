/*
Blackout: activate anonymous voting once per game

Ability (in meeting): Anonomyize - Activates anonymous voting lol

Technical Issues: 
- Blackout cannot be pulled if anonymous voting is already on
*/

//yoinked from disperser, not all are needed
using System.Collections;
using Il2CppInterop.Runtime.Attributes;
using MiraAPI.GameOptions;
using MiraAPI.Modifiers;
using MiraAPI.Modifiers.Types;
using MiraAPI.Utilities;
using Reactor.Utilities.Extensions;
using TownOfUs.Interfaces;
using TownOfUs.Modifiers.Game.Universal;
using TownOfUs.Modules;
using TownOfUs.Options.Modifiers;
using UnityEngine;
using Object = UnityEngine.Object;

namespace TownOfUs.Modifiers.Game.Impostor;

public sealed class BlackoutCustomModifier: TouGameModifier
{
    public override ModifierUiConfiguration Configuration => new(
        TownOfUsColors.Impostor,
        TmpSpriteUtils.CreateSpriteAsset(TouModifierIcons.BlackoutCustom.LoadAsset(),
            "TouMira.Modifier.Impostor.BlackoutCustom", 1.45f));
    public override string IdPart => "Disperser";
}