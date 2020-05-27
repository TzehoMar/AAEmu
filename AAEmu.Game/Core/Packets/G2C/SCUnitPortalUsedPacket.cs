﻿using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCUnitPortalUsedPacket : GamePacket
    {
        private readonly uint _unitId;
        
        public SCUnitPortalUsedPacket(uint unitId) : base(SCOffsets.SCUnitPortalUsedPacket, 1)
        {
            _unitId = unitId;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.WriteBc(_unitId);
            return stream;
        }
    }
}
