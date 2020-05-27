using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Managers.UnitManagers;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Models.Game.Units;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSCreateCharacterPacket : GamePacket
    {
        public CSCreateCharacterPacket() : base(0x022, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var name = stream.ReadString();
            var race = stream.ReadByte();
            var gender = stream.ReadByte();
            var items = new uint[7];
            for (var i = 0; i < 7; i++)
                items[i] = stream.ReadUInt32();

            var customModel = new UnitCustomModelParams();
            customModel.Read(stream);

            var ability1 = stream.ReadByte();
            var ability2 = stream.ReadByte();
            var ability3 = stream.ReadByte();
            var level = stream.ReadByte();

            CharacterManager.Instance.Create(DbLoggerCategory.Database.Connection, name, race, gender, items, customModel, ability1);
        }
    }
}
