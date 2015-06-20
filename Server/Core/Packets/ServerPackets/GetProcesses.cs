﻿using ProtoBuf;
using xServer.Core.Networking;

namespace xServer.Core.Packets.ServerPackets
{
    [ProtoContract]
    public class GetProcesses : IPacket
    {
        public GetProcesses()
        {
        }

        public void Execute(Client client)
        {
            client.Send(this);
        }
    }
}