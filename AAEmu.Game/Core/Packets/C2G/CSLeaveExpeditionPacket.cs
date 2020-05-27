using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Managers;
using AAEmu.Game.Core.Network.Game;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSLeaveExpeditionPacket : GamePacket
    {
        public CSLeaveExpeditionPacket() : base(0x00e, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            _log.Debug("LeaveExpedition");
            ExpeditionManager.Instance.Leave(DbLoggerCategory.Database.Connection);
        }
    }
}
