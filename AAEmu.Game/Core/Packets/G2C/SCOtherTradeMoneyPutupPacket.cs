﻿using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCOtherTradeMoneyPutupPacket : GamePacket
    {
        private readonly int _moneyAmount;

        public SCOtherTradeMoneyPutupPacket(int moneyAmount) : base(SCOffsets.SCOtherTradeMoneyPutupPacket, 1)
        {
            _moneyAmount = moneyAmount;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_moneyAmount);
            return stream;
        }
    }
}
