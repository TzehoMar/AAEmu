using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSLearnSkillPacket : GamePacket
    {
        public CSLearnSkillPacket() : base(0x092, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var skillId = stream.ReadUInt32();

            DbLoggerCategory.Database.Connection.ActiveChar.Skills.AddSkill(skillId);
        }
    }
}