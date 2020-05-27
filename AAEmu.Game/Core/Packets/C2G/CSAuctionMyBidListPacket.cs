using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSAuctionMyBidListPacket : GamePacket
    {
        public CSAuctionMyBidListPacket() : base(0x0bb, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var npcObjId = stream.ReadBc();
            var page = stream.ReadInt32();
            
            _log.Warn("AuctionMyBidList, NpcObjId: {0}, Page: {1}", npcObjId, page);
        }
    }
}
