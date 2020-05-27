using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Managers;
using AAEmu.Game.Core.Network.Game;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSFamilyKickPacket : GamePacket
    {
        public CSFamilyKickPacket() : base(0x01d, 1)  //TODO : 1.0 opcode: 0x01c
        {
        }

        public override void Read(PacketStream stream)
        {
            var memberId = stream.ReadUInt32();

            FamilyManager.Instance.KickMember(DbLoggerCategory.Database.Connection.ActiveChar, memberId);

            _log.Debug("FamilyKick, memberId: {0}", memberId);
        }
    }
}
