using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSRepairPetItemsPacket : GamePacket
    {
        public CSRepairPetItemsPacket() : base(0x0b5, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var npcId = stream.ReadBc();
            
            _log.Warn("RepairPetItems, NpcId: {0}", npcId);
        }
    }
}
