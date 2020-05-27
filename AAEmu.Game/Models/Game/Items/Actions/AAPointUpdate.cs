﻿using AAEmu.Commons.Network;
using AAEmu.Commons.Network.Core;

namespace AAEmu.Game.Models.Game.Items.Actions
{
    public class AAPointUpdate : ItemTask
    {
        private readonly int _amount;

        public AAPointUpdate(int amount)
        {
            _type = 0x10; // 16
            _amount = amount;
        }

        public override PacketStream Write(PacketStream stream)
        {
            base.Write(stream);
            stream.Write(_amount);
            return stream;
        }
    }
}
