﻿using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Managers;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Models.Game.Items;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSTakedownTradeItemPacket : GamePacket
    {
        public CSTakedownTradeItemPacket() : base(0x0f2, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var slotType = (SlotType)stream.ReadByte();
            var slot = stream.ReadByte();
            
            //_log.Warn("TakedownTradeItem, SlotType: {0}, Slot: {1}", slotType, slot);
            TradeManager.Instance.RemoveItem(DbLoggerCategory.Database.Connection.ActiveChar, slotType, slot);
        }
    }
}
