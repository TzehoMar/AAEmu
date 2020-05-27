using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Models.Game.Items;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCInvenExpandedPacket : GamePacket
    {
        private readonly byte _slotType;
        private readonly byte _numSlots;

        public SCInvenExpandedPacket(SlotType slotType, byte numSlots) : base(SCOffsets.SCInvenExpandedPacket, 1)
        {
            _slotType = (byte)slotType;
            _numSlots = numSlots;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_slotType);
            stream.Write(_numSlots);
            return stream;
        }
    }
}
