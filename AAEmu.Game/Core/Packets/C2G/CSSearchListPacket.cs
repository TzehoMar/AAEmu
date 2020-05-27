using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSSearchListPacket : GamePacket
    {
        public CSSearchListPacket() : base(0x100, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var zoneType = stream.ReadByte();
            var onlineType = stream.ReadByte();

            _log.Debug("SearchList, ZoneType: {0}, OnlineType: {1}", zoneType, onlineType);
        }
    }
}
