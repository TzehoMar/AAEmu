using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Managers;
using AAEmu.Game.Core.Network.Game;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSReplyExpeditionInvitationPacket : GamePacket
    {
        public CSReplyExpeditionInvitationPacket() : base(0x00d, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var id = stream.ReadUInt32(); // type(id)
            var id2 = stream.ReadUInt32(); // type(id)
            var join = stream.ReadBoolean();

            _log.Debug("ReplyExpeditionInvitation, Id: {0}, Id2: {1}, Join: {2}", id, id2, join);
            ExpeditionManager.Instance.ReplyInvite(DbLoggerCategory.Database.Connection, id, id2, join);
        }
    }
}
