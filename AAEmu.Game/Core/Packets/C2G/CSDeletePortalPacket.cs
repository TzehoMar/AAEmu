﻿using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Managers;
using AAEmu.Game.Core.Network.Game;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSDeletePortalPacket : GamePacket
    {
        public CSDeletePortalPacket() : base(0x0df, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var portalType = stream.ReadByte();
            var portalId = stream.ReadUInt32(); // stream.ReadInt32() - Before

            _log.Debug("DeletePortal, PortalType: {0}, PortalId: {1}", portalType, portalId);

            PortalManager.Instance.DeletePortal(DbLoggerCategory.Database.Connection.ActiveChar, portalType, portalId);
        }
    }
}
