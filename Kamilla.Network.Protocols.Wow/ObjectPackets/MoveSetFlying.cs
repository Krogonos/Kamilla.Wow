﻿
namespace Kamilla.Network.Protocols.Wow.ObjectPackets
{
    internal sealed class MoveSetFlying : RegularMovementPacket
    {
        protected override TransferDirection Direction
        {
            get { return TransferDirection.ToServer; }
        }

        protected override RegularMovementPacket.MovementStatusElements[] Elements
        {
            get
            {
                return new MovementStatusElements[]
                {
                };
            }
        }

        public override WowOpcodes Opcode
        {
            get { return WowOpcodes.CMSG_MOVE_SET_FLY; }
        }
    }
}
