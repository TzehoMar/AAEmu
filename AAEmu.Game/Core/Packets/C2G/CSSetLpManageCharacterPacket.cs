using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Core.Packets.G2C;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSSetLpManageCharacterPacket : GamePacket
    {
        public CSSetLpManageCharacterPacket() : base(0x0fe, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var characterId = stream.ReadUInt32();
            DbLoggerCategory.Database.Connection.SendPacket(new SCLpManagedPacket(characterId));
        }
    }
}
