﻿using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCRankAlarmPacket : GamePacket
    {
        private readonly uint _type;
        private readonly byte _rankAlarmKind;

        public SCRankAlarmPacket(uint type, byte rankAlarmKind) : base(SCOffsets.SCRankAlarmPacket, 1)
        {
            _type = type;
            _rankAlarmKind = rankAlarmKind;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_type);
            stream.Write(_rankAlarmKind);
            return stream;
        }
    }
}
