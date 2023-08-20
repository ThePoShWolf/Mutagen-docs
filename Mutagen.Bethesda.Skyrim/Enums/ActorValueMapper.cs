﻿using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.Skyrim;

public static class ActorValueMapper
{
    private static readonly IReadOnlyDictionary<FormKey, ActorValue> _mapping;

    static ActorValueMapper()
    {
        _mapping = new Dictionary<FormKey, ActorValue>()
        {
            { FormKey.Factory("0003E8:Skyrim.esm"), ActorValue.Health },
            { FormKey.Factory("0003E9:Skyrim.esm"), ActorValue.Magicka },
            { FormKey.Factory("0003EA:Skyrim.esm"), ActorValue.Stamina },
            { FormKey.Factory("0003EB:Skyrim.esm"), ActorValue.HealRate },
            { FormKey.Factory("0003EC:Skyrim.esm"), ActorValue.MagickaRate },
            { FormKey.Factory("0003ED:Skyrim.esm"), ActorValue.StaminaRate },
            { FormKey.Factory("0003EE:Skyrim.esm"), ActorValue.SpeedMult },
            { FormKey.Factory("0003EF:Skyrim.esm"), ActorValue.InventoryWeight },
            { FormKey.Factory("0003F0:Skyrim.esm"), ActorValue.CarryWeight },
            { FormKey.Factory("0003F1:Skyrim.esm"), ActorValue.CriticalChance },
            { FormKey.Factory("0003F2:Skyrim.esm"), ActorValue.MeleeDamage },
            { FormKey.Factory("0003F3:Skyrim.esm"), ActorValue.UnarmedDamage },
            { FormKey.Factory("0003F4:Skyrim.esm"), ActorValue.Mass },
            { FormKey.Factory("0003F5:Skyrim.esm"), ActorValue.VoicePoints },
            { FormKey.Factory("0003F6:Skyrim.esm"), ActorValue.VoiceRate },
            { FormKey.Factory("00044C:Skyrim.esm"), ActorValue.OneHanded },
            { FormKey.Factory("00044D:Skyrim.esm"), ActorValue.TwoHanded },
            { FormKey.Factory("00044E:Skyrim.esm"), ActorValue.Archery },
            { FormKey.Factory("00044F:Skyrim.esm"), ActorValue.Block },
            { FormKey.Factory("000450:Skyrim.esm"), ActorValue.Smithing },
            { FormKey.Factory("000451:Skyrim.esm"), ActorValue.HeavyArmor },
            { FormKey.Factory("000452:Skyrim.esm"), ActorValue.LightArmor },
            { FormKey.Factory("000453:Skyrim.esm"), ActorValue.Pickpocket },
            { FormKey.Factory("000454:Skyrim.esm"), ActorValue.Lockpicking },
            { FormKey.Factory("000455:Skyrim.esm"), ActorValue.Sneak },
            { FormKey.Factory("000456:Skyrim.esm"), ActorValue.Alchemy },
            { FormKey.Factory("000457:Skyrim.esm"), ActorValue.Speech },
            { FormKey.Factory("000458:Skyrim.esm"), ActorValue.Alteration },
            { FormKey.Factory("000459:Skyrim.esm"), ActorValue.Conjuration },
            { FormKey.Factory("00045A:Skyrim.esm"), ActorValue.Destruction },
            { FormKey.Factory("00045B:Skyrim.esm"), ActorValue.Illusion },
            { FormKey.Factory("00045C:Skyrim.esm"), ActorValue.Restoration },
            { FormKey.Factory("00045D:Skyrim.esm"), ActorValue.Enchanting },
            { FormKey.Factory("0004B0:Skyrim.esm"), ActorValue.Aggression },
            { FormKey.Factory("0004B1:Skyrim.esm"), ActorValue.Confidence },
            { FormKey.Factory("0004B2:Skyrim.esm"), ActorValue.Energy },
            { FormKey.Factory("0004B3:Skyrim.esm"), ActorValue.Morality },
            { FormKey.Factory("0004B4:Skyrim.esm"), ActorValue.Mood },
            { FormKey.Factory("0004B5:Skyrim.esm"), ActorValue.Assistance },
            { FormKey.Factory("0005CE:Skyrim.esm"), ActorValue.DamageResist },
            { FormKey.Factory("0005CF:Skyrim.esm"), ActorValue.PoisonResist },
            { FormKey.Factory("0005D0:Skyrim.esm"), ActorValue.ResistFire },
            { FormKey.Factory("0005D1:Skyrim.esm"), ActorValue.ResistShock },
            { FormKey.Factory("0005D2:Skyrim.esm"), ActorValue.ResistFrost },
            { FormKey.Factory("0005D3:Skyrim.esm"), ActorValue.ResistMagic },
            { FormKey.Factory("0005D4:Skyrim.esm"), ActorValue.ResistDisease },
            { FormKey.Factory("0005DC:Skyrim.esm"), ActorValue.Paralysis },
            { FormKey.Factory("0005DD:Skyrim.esm"), ActorValue.Invisibility },
            { FormKey.Factory("0005DE:Skyrim.esm"), ActorValue.NightEye },
            { FormKey.Factory("0005DF:Skyrim.esm"), ActorValue.DetectLifeRange },
            { FormKey.Factory("0005E0:Skyrim.esm"), ActorValue.WaterBreathing },
            { FormKey.Factory("0005E1:Skyrim.esm"), ActorValue.WaterWalking },
            { FormKey.Factory("0005E3:Skyrim.esm"), ActorValue.Fame },
            { FormKey.Factory("0005E4:Skyrim.esm"), ActorValue.Infamy },
            { FormKey.Factory("0005E5:Skyrim.esm"), ActorValue.JumpingBonus },
            { FormKey.Factory("0005E6:Skyrim.esm"), ActorValue.WardPower },
            { FormKey.Factory("0005E7:Skyrim.esm"), ActorValue.RightItemCharge },
            { FormKey.Factory("0005E8:Skyrim.esm"), ActorValue.ArmorPerks },
            { FormKey.Factory("0005E9:Skyrim.esm"), ActorValue.ShieldPerks },
            { FormKey.Factory("0005EA:Skyrim.esm"), ActorValue.WardDeflection },
            { FormKey.Factory("0005EB:Skyrim.esm"), ActorValue.Variable01 },
            { FormKey.Factory("0005EC:Skyrim.esm"), ActorValue.Variable02 },
            { FormKey.Factory("0005ED:Skyrim.esm"), ActorValue.Variable03 },
            { FormKey.Factory("0005EE:Skyrim.esm"), ActorValue.Variable04 },
            { FormKey.Factory("0005EF:Skyrim.esm"), ActorValue.Variable05 },
            { FormKey.Factory("0005F0:Skyrim.esm"), ActorValue.Variable06 },
            { FormKey.Factory("0005F1:Skyrim.esm"), ActorValue.Variable07 },
            { FormKey.Factory("0005F2:Skyrim.esm"), ActorValue.Variable08 },
            { FormKey.Factory("0005F3:Skyrim.esm"), ActorValue.Variable09 },
            { FormKey.Factory("0005F4:Skyrim.esm"), ActorValue.Variable10 },
            { FormKey.Factory("0005F5:Skyrim.esm"), ActorValue.BowSpeedBonus },
            { FormKey.Factory("0005F6:Skyrim.esm"), ActorValue.FavorActive },
            { FormKey.Factory("0005F7:Skyrim.esm"), ActorValue.FavorsPerDay },
            { FormKey.Factory("0005F8:Skyrim.esm"), ActorValue.FavorsPerDayTimer },
            { FormKey.Factory("0005F9:Skyrim.esm"), ActorValue.LeftItemCharge },
            { FormKey.Factory("0005FA:Skyrim.esm"), ActorValue.AbsorbChance },
            { FormKey.Factory("0005FB:Skyrim.esm"), ActorValue.Blindness },
            { FormKey.Factory("0005FC:Skyrim.esm"), ActorValue.WeaponSpeedMult },
            { FormKey.Factory("0005FD:Skyrim.esm"), ActorValue.ShoutRecoveryMult },
            { FormKey.Factory("0005FE:Skyrim.esm"), ActorValue.BowStaggerBonus },
            { FormKey.Factory("0005FF:Skyrim.esm"), ActorValue.Telekinesis },
            { FormKey.Factory("000600:Skyrim.esm"), ActorValue.FavorPointsBonus },
            { FormKey.Factory("000601:Skyrim.esm"), ActorValue.LastBribedIntimidated },
            { FormKey.Factory("000602:Skyrim.esm"), ActorValue.LastFlattered },
            { FormKey.Factory("000603:Skyrim.esm"), ActorValue.MovementNoiseMult },
            { FormKey.Factory("000604:Skyrim.esm"), ActorValue.BypassVendorStolenCheck },
            { FormKey.Factory("000605:Skyrim.esm"), ActorValue.BypassVendorKeywordCheck },
            { FormKey.Factory("000606:Skyrim.esm"), ActorValue.WaitingForPlayer },
            { FormKey.Factory("000607:Skyrim.esm"), ActorValue.OneHandedModifier },
            { FormKey.Factory("000608:Skyrim.esm"), ActorValue.TwoHandedModifier },
            { FormKey.Factory("000609:Skyrim.esm"), ActorValue.MarksmanModifier },
            { FormKey.Factory("00060A:Skyrim.esm"), ActorValue.BlockModifier },
            { FormKey.Factory("00060B:Skyrim.esm"), ActorValue.SmithingModifier },
            { FormKey.Factory("00060C:Skyrim.esm"), ActorValue.HeavyArmorModifier },
            { FormKey.Factory("00060D:Skyrim.esm"), ActorValue.LightArmorModifier },
            { FormKey.Factory("00060E:Skyrim.esm"), ActorValue.PickpocketModifier },
            { FormKey.Factory("00060F:Skyrim.esm"), ActorValue.LockpickingModifier },
            { FormKey.Factory("000610:Skyrim.esm"), ActorValue.SneakingModifier },
            { FormKey.Factory("000611:Skyrim.esm"), ActorValue.AlchemyModifier },
            { FormKey.Factory("000612:Skyrim.esm"), ActorValue.SpeechcraftModifier },
            { FormKey.Factory("000613:Skyrim.esm"), ActorValue.AlterationModifier },
            { FormKey.Factory("000614:Skyrim.esm"), ActorValue.ConjurationModifier },
            { FormKey.Factory("000615:Skyrim.esm"), ActorValue.DestructionModifier },
            { FormKey.Factory("000616:Skyrim.esm"), ActorValue.IllusionModifier },
            { FormKey.Factory("000617:Skyrim.esm"), ActorValue.RestorationModifier },
            { FormKey.Factory("000618:Skyrim.esm"), ActorValue.EnchantingModifier },
            { FormKey.Factory("000619:Skyrim.esm"), ActorValue.OneHandedSkillAdvance },
            { FormKey.Factory("00061A:Skyrim.esm"), ActorValue.TwoHandedSkillAdvance },
            { FormKey.Factory("00061B:Skyrim.esm"), ActorValue.MarksmanSKillAdvance },
            { FormKey.Factory("00061C:Skyrim.esm"), ActorValue.BlockSkillAdvance },
            { FormKey.Factory("00061D:Skyrim.esm"), ActorValue.SmithingSkillAdvance },
            { FormKey.Factory("00061E:Skyrim.esm"), ActorValue.HeavyArmorSkillAdvance },
            { FormKey.Factory("00061F:Skyrim.esm"), ActorValue.LightArmorSkillAdvance },
            { FormKey.Factory("000620:Skyrim.esm"), ActorValue.PickpocketSkillAdvance },
            { FormKey.Factory("000621:Skyrim.esm"), ActorValue.LockpickingSkillAdvance },
            { FormKey.Factory("000622:Skyrim.esm"), ActorValue.SneakingSkillAdvance },
            { FormKey.Factory("000623:Skyrim.esm"), ActorValue.AlchemySkillAdvance },
            { FormKey.Factory("000624:Skyrim.esm"), ActorValue.SpeechcraftSkillAdvance },
            { FormKey.Factory("000625:Skyrim.esm"), ActorValue.AlterationSkillAdvance },
            { FormKey.Factory("000626:Skyrim.esm"), ActorValue.ConjurationSkillAdvance },
            { FormKey.Factory("000627:Skyrim.esm"), ActorValue.DestructionSkillAdvance },
            { FormKey.Factory("000628:Skyrim.esm"), ActorValue.IllusionSkillAdvance },
            { FormKey.Factory("000629:Skyrim.esm"), ActorValue.RestorationSkillAdvance },
            { FormKey.Factory("00062A:Skyrim.esm"), ActorValue.EnchantingSkillAdvance },
            { FormKey.Factory("00062B:Skyrim.esm"), ActorValue.LeftWeaponSpeedMultiply },
            { FormKey.Factory("00062C:Skyrim.esm"), ActorValue.DragonSouls },
            { FormKey.Factory("00062D:Skyrim.esm"), ActorValue.CombatHealthRegenMultiply },
            { FormKey.Factory("00062E:Skyrim.esm"), ActorValue.OneHandedPowerModifier },
            { FormKey.Factory("00062F:Skyrim.esm"), ActorValue.TwoHandedPowerModifier },
            { FormKey.Factory("000630:Skyrim.esm"), ActorValue.MarksmanPowerModifier },
            { FormKey.Factory("000631:Skyrim.esm"), ActorValue.BlockPowerModifier },
            { FormKey.Factory("000632:Skyrim.esm"), ActorValue.SmithingPowerModifier },
            { FormKey.Factory("000633:Skyrim.esm"), ActorValue.HeavyArmorPowerModifier },
            { FormKey.Factory("000634:Skyrim.esm"), ActorValue.LightArmorPowerModifier },
            { FormKey.Factory("000635:Skyrim.esm"), ActorValue.PickpocketPowerModifier },
            { FormKey.Factory("000636:Skyrim.esm"), ActorValue.LockpickingPowerModifier },
            { FormKey.Factory("000637:Skyrim.esm"), ActorValue.SneakingPowerModifier },
            { FormKey.Factory("000638:Skyrim.esm"), ActorValue.AlchemyPowerModifier },
            { FormKey.Factory("000639:Skyrim.esm"), ActorValue.SpeechcraftPowerModifier },
            { FormKey.Factory("00063A:Skyrim.esm"), ActorValue.AlterationPowerModifier },
            { FormKey.Factory("00063B:Skyrim.esm"), ActorValue.ConjurationPowerModifier },
            { FormKey.Factory("00063C:Skyrim.esm"), ActorValue.DestructionPowerModifier },
            { FormKey.Factory("00063D:Skyrim.esm"), ActorValue.IllusionPowerModifier },
            { FormKey.Factory("00063E:Skyrim.esm"), ActorValue.RestorationPowerModifier },
            { FormKey.Factory("00063F:Skyrim.esm"), ActorValue.EnchantingPowerModifier },
            { FormKey.Factory("000640:Skyrim.esm"), ActorValue.DragonRend },
            { FormKey.Factory("000641:Skyrim.esm"), ActorValue.AttackDamageMult },
            { FormKey.Factory("000642:Skyrim.esm"), ActorValue.HealRateMult },
            { FormKey.Factory("000643:Skyrim.esm"), ActorValue.MagickaRateMult },
            { FormKey.Factory("000644:Skyrim.esm"), ActorValue.StaminaRateMult },
            { FormKey.Factory("000645:Skyrim.esm"), ActorValue.WerewolfPerks },
            { FormKey.Factory("000646:Skyrim.esm"), ActorValue.VampirePerks },
            { FormKey.Factory("000647:Skyrim.esm"), ActorValue.GrabActorOffset },
            { FormKey.Factory("000648:Skyrim.esm"), ActorValue.Grabbed },
            { FormKey.Factory("00064A:Skyrim.esm"), ActorValue.ReflectDamage },
        };
    }

    public static bool TryGetActorValue(IActorValueInformationGetter actorValueInformation, out ActorValue actorValue)
    {
        return _mapping.TryGetValue(actorValueInformation.FormKey, out actorValue);
    }
}
