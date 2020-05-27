﻿using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;
using AAEmu.Game.Core.Managers;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Core.Packets.G2C;
using Microsoft.EntityFrameworkCore;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSLootItemPacket : GamePacket
    {
        public CSLootItemPacket() : base(0x08f, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var iid = stream.ReadUInt64();
            var count = stream.ReadInt32();

            _log.Warn("LootItem, IId: {0}, Count: {1}", iid, count);

            var objId = (uint)(iid >> 32);
            var lootDropItems = ItemManager.Instance.GetLootDropItems(objId);
            var lootDropItem = lootDropItems.Find(a => a.Id == iid);
            if (lootDropItem != null)
            {
                ItemManager.Instance.TookLootDropItem(DbLoggerCategory.Database.Connection.ActiveChar, lootDropItems, lootDropItem, count);
            }
            else
            {
                if (lootDropItems.Count <= 0)
                {
                    ItemManager.Instance.RemoveLootDropItems(objId);
                    DbLoggerCategory.Database.Connection.ActiveChar.BroadcastPacket(new SCLootableStatePacket(objId, false), true);
                }
            }
        }
    }
}
