using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Managers;
using AAEmu.Game.Core.Network.Game;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSInviteToTeamPacket : GamePacket
    {
        public CSInviteToTeamPacket() : base(0x07a, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var teamId = stream.ReadUInt32();
            var isParty = stream.ReadBoolean();
            var targetName = stream.ReadString();

            // _log.Warn("CSInviteToTeam, TeamId: {0}, IsParty: {1}, Char: {2}", teamId, isParty, targetName);
            TeamManager.Instance.AskToJoin(DbLoggerCategory.Database.Connection.ActiveChar, targetName, teamId, isParty);
        }
    }
}
