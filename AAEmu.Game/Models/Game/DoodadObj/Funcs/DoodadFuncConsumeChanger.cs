﻿using AAEmu.Game.Models.Game.DoodadObj.Templates;
using AAEmu.Game.Models.Game.Units;

namespace AAEmu.Game.Models.Game.DoodadObj.Funcs
{
    public class DoodadFuncConsumeChanger : DoodadFuncTemplate
    {
        public uint SlotId { get; set; }
        public int Count { get; set; }
        
        public override void Use(Unit caster, Doodad owner, uint skillId, int nextPhase = 0)
        {
            _log.Debug("DoodadFuncConsumeChanger");
            owner.ToPhaseAndUse = false;
        }
    }
}
