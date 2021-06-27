// ******************************************************************
//       /\ /|       @file       LordJob_AssaultColonyPatch.cs
//       \ V/        @brief      
//       | "")       @author     Shadowrabbit, yingtu0401@gmail.com
//       /  |                    
//      /  \\        @Modified   2021-06-27 20:54:28
//    *(__\_\        @Copyright  Copyright (c) 2021, Shadowrabbit
// ******************************************************************

using System;
using HarmonyLib;
using JetBrains.Annotations;
using RimWorld;
using Verse;

namespace SR.GlitterworldFactionPacks
{
    [UsedImplicitly]
    public class LordJob_AssaultColonyPatch
    {
        [UsedImplicitly]
        [HarmonyPatch(typeof(LordJob_AssaultColony))]
        [HarmonyPatch(MethodType.Constructor)]
        [HarmonyPatch(new[] {typeof(Faction), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)})]
        public class Patch1
        {
            [HarmonyPostfix]
            [UsedImplicitly]
            private static void Postfix(LordJob_AssaultColony __instance, Faction assaulterFaction, ref bool canKidnap,
                ref bool canTimeoutOrFlee, bool sappers, bool useAvoidGridSmart, ref bool canSteal)
            {
                if (assaulterFaction.def != FactionDefOf.Faction_3HSTlimited)
                {
                    return;
                }

                Traverse.Create(__instance).Field("canKidnap").SetValue(false);
                Traverse.Create(__instance).Field("canTimeoutOrFlee").SetValue(false);
                Traverse.Create(__instance).Field("canSteal").SetValue(false);
            }
        }

        [UsedImplicitly]
        [HarmonyPatch(typeof(LordJob_AssaultColony))]
        [HarmonyPatch(MethodType.Constructor)]
        [HarmonyPatch(new Type[] { })]
        public class Patch2
        {
            [HarmonyPostfix]
            [UsedImplicitly]
            private static void Postfix(LordJob_AssaultColony __instance)
            {
                if (__instance.lord.faction.def != FactionDefOf.Faction_3HSTlimited)
                {
                    return;
                }

                Traverse.Create(__instance).Field("canKidnap").SetValue(false);
                Traverse.Create(__instance).Field("canTimeoutOrFlee").SetValue(false);
                Traverse.Create(__instance).Field("canSteal").SetValue(false);
            }
        }
    }
}