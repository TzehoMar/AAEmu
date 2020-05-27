﻿using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Managers;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Core.Packets.G2C;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSMountMatePacket : GamePacket
    {
        public CSMountMatePacket() : base(0x0a7, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var tlId = stream.ReadUInt16();
            var ap = stream.ReadByte();
            var reason = stream.ReadByte();

            // _log.Warn("MountMate, TlId: {0}, Ap: {1}, Reason: {2}", tlId, ap, reason);
            MateManager.Instance.MountMate(DbLoggerCategory.Database.Connection, tlId, ap, reason);
        }
    }
}
