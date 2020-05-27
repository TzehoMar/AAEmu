using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSSetTeamOfficerPacket : GamePacket
    {
        public CSSetTeamOfficerPacket() : base(0x07e, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var teamId = stream.ReadUInt32();
            var memberId = stream.ReadUInt32();
            var promote = stream.ReadBoolean();

            _log.Warn("SetTeamOfficer, TeamId: {0}, MemberId: {1}, Promote: {2}", teamId, memberId, promote);
        }
    }
}
