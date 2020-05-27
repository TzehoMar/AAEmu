using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCCharacterInvenInitPacket : GamePacket
    {
        private readonly uint _numInvenSlots;
        private readonly uint _numBankSlots;

        public SCCharacterInvenInitPacket(uint numInvenSlots, uint numBankSlots) : base(SCOffsets.SCCharacterInvenInitPacket, 1)
        {
            _numInvenSlots = numInvenSlots;
            _numBankSlots = numBankSlots;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_numInvenSlots);
            stream.Write(_numBankSlots);
            return stream;
        }
    }
}
