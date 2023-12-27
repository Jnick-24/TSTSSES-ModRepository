﻿using Sandbox.ModAPI;
using VRage.Game.ModAPI;
using VRage.ModAPI;
using VRageMath;
using static Scripts.IHATEKEEN.ModularWeaponry.Communication.DefinitionDefs;
using CoreParts.Data.Scripts.IHATEKEEN.ModularWeaponry.Communication;
using CoreSystems.Api;

namespace IHATEKEEN.Scripts.ModularWeaponry
{
    partial class ModularDefinition
    {
        internal DefinitionContainer Container = new DefinitionContainer();
        internal static ModularDefinitionAPI ModularAPI = null;
        internal static WcApi WcAPI = null;

        internal void LoadDefinitions(params PhysicalDefinition[] defs)
        {
            Container.PhysicalDefs = defs;
        }

        /// <summary>
        /// Load all definitions for DefinitionSender
        /// </summary>
        /// <param name="baseDefs"></param>
        internal static DefinitionContainer GetBaseDefinitions()
        {
            return new ModularDefinition().Container;
        }
    }
}
