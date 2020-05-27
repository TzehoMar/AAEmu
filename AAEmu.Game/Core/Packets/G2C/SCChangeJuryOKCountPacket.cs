﻿using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;
namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCChangeJuryOKCountPacket : GamePacket
    {
        private readonly int _count;
        private readonly int _total;

        public SCChangeJuryOKCountPacket(int count, int total) : base(SCOffsets.SCChangeJuryOKCountPacket,1)
        {
            _count = count;
            _total = total;
        
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_count);
            stream.Write(_total);
            return stream;
        }
    }
    
}
