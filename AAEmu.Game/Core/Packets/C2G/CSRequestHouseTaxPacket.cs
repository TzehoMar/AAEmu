﻿using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Managers;
using AAEmu.Game.Core.Network.Game;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSRequestHouseTaxPacket : GamePacket
    {
        public CSRequestHouseTaxPacket() : base(0x05c, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var tl = stream.ReadUInt16();

            _log.Debug("RequestHouseTax, Tl: {0}", tl);
            
            HousingManager.Instance.HouseTaxInfo(DbLoggerCategory.Database.Connection, tl);
        }
    }
}
