﻿using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Managers;
using AAEmu.Game.Core.Network.Game;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSTradeOkPacket : GamePacket
    {
        public CSTradeOkPacket() : base(0x0f4, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            //_log.Warn("TradeOk");
            TradeManager.Instance.OkTrade(DbLoggerCategory.Database.Connection.ActiveChar);
        }
    }
}
