﻿using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Network.Send;

namespace PiercingBlow.Game.Network.Recv
{
    class PROTOCOL_SHOP_LEAVE_REQ : ClientPacket
    {
        public override void ReadImpl()
        {
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_SHOP_LEAVE_ACK());
        }
    }
}
