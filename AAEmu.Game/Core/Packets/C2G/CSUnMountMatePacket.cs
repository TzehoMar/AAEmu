﻿using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Managers;
using AAEmu.Game.Core.Network.Game;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSUnMountMatePacket : GamePacket
    {
        public CSUnMountMatePacket() : base(0x0a8, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var tlId = stream.ReadUInt16();
            var ap = stream.ReadByte();
            var reason = stream.ReadByte();
            
            //_log.Warn("UnMountMate, TlId: {0}, Ap: {1}, Reason: {2}", tlId, ap, reason);
            MateManager.Instance.UnMountMate(DbLoggerCategory.Database.Connection.ActiveChar, tlId, ap, reason);
        }
    }
}
