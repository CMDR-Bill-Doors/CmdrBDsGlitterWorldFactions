// ******************************************************************
//       /\ /|       @file       PatchMain.cs
//       \ V/        @brief      
//       | "")       @author     Shadowrabbit, yingtu0401@gmail.com
//       /  |                    
//      /  \\        @Modified   2021-06-27 20:39:25
//    *(__\_\        @Copyright  Copyright (c) 2021, Shadowrabbit
// ******************************************************************

using System.Reflection;
using HarmonyLib;
using JetBrains.Annotations;
using Verse;

namespace SR.GlitterworldFactionPacks
{
    [StaticConstructorOnStartup]
    [UsedImplicitly]
    public class PatchMain
    {
        static PatchMain()
        {
            var instance = new Harmony("SR.GlitterworldFactionPacks");
            instance.PatchAll(Assembly.GetExecutingAssembly()); //对所有特性标签的方法进行patch
        }
    }
}