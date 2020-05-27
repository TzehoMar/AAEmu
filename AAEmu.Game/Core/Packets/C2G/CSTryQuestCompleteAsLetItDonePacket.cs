using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSTryQuestCompleteAsLetItDonePacket : GamePacket
    {
        public CSTryQuestCompleteAsLetItDonePacket() : base(0x0dd, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var id = stream.ReadUInt32();
            var objId = stream.ReadBc();
            var selected = stream.ReadInt32();

            _log.Warn("TryQuestCompleteAsLetItDone, Id: {0}, ObjId: {1}, Selected: {2}", id, objId, selected);
        }
    }
}
