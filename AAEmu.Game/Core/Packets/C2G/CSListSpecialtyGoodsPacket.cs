using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSListSpecialtyGoodsPacket : GamePacket
    {
        public CSListSpecialtyGoodsPacket() : base(0x044, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var objId = stream.ReadBc();

            _log.Warn("ListSpecialtyGoods, ObjId: {0}", objId);
        }
    }
}
