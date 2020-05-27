using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Core.Packets.G2C;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSICSMoneyRequestPacket : GamePacket
    {
        public CSICSMoneyRequestPacket() : base(0x11e, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            // Empty struct
            _log.Warn("ICSMoneyRequest");

            DbLoggerCategory.Database.Connection.SendPacket(new SCICSCashPointPacket(5678));
        }
    }
}
