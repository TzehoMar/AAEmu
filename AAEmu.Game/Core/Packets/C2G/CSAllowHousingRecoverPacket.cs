using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSAllowHousingRecoverPacket : GamePacket
    {
        public CSAllowHousingRecoverPacket() : base(0x05d, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var tl = stream.ReadUInt16();
            
            _log.Debug("AllowHousingRecover, Tl: {0}", tl);
        }
    }
}
