﻿using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCGetSlotCountPacket : GamePacket
    {
        private readonly byte _sc;

        public SCGetSlotCountPacket(byte sc) : base(SCOffsets.SCGetSlotCountPacket, 1)
        {
            _sc = sc;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_sc);
            return stream;
        }
    }
}
