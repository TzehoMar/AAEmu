using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCReconnectAuthPacket : GamePacket
    {
        private readonly uint _token;

        public SCReconnectAuthPacket(uint token) : base(SCOffsets.SCReconnectAuthPacket, 1)
        {
            _token = token;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_token);
            return stream;
        }
    }
}
