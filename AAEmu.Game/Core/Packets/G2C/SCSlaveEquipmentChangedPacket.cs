using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Models.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCSlaveEquipmentChangedPacket : GamePacket
    {
        private SlaveEquipment slaveEquipment;
        private bool success;

        public SCSlaveEquipmentChangedPacket(SlaveEquipment slaveEquipment, bool success) : base(SCOffsets.SCSlaveEquipmentChangedPacket, 1)
        {

        }

        public override PacketStream Write(PacketStream stream)
        {
            // TODO coming soon!
            return stream;
        }
    }
}
