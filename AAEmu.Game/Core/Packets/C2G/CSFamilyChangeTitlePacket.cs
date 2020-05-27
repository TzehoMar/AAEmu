using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Managers;
using AAEmu.Game.Core.Network.Game;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSFamilyChangeTitlePacket : GamePacket
    {
        public CSFamilyChangeTitlePacket() : base(0x01e, 1)  //TODO : 1.0 opcode: 0x01d
        {
        }

        public override void Read(PacketStream stream)
        {
            var memberId = stream.ReadUInt32();
            var title = stream.ReadString();

            FamilyManager.Instance.ChangeTitle(DbLoggerCategory.Database.Connection.ActiveChar, memberId, title);

            _log.Debug("FamilyChangeTitle, memberId: {0}, title: {1}", memberId, title);
        }
    }
}
