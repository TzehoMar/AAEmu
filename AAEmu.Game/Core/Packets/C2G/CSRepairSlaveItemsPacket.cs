using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSRepairSlaveItemsPacket : GamePacket
    {
        public CSRepairSlaveItemsPacket() : base(0x035, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var npcId = stream.ReadBc();

            _log.Debug("RepairSlaveItems, NpcId: {0}", npcId);
        }
    }
}
