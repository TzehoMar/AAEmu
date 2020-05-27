using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSLeaveTrialAudiencePacket : GamePacket
    {
        public CSLeaveTrialAudiencePacket() : base(0x078, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            // Empty struct
            _log.Warn("LeaveTrialAudience");
        }
    }
}
