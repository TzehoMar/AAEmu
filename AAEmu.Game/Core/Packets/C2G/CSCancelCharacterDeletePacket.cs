using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSCancelCharacterDeletePacket : GamePacket
    {
        public CSCancelCharacterDeletePacket() : base(0x027, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var characterId = stream.ReadUInt32();
            DbLoggerCategory.Database.Connection.SetRestoreCharacter(characterId);
        }
    }
}
