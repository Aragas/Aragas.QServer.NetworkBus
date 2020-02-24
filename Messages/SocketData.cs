namespace Aragas.QServer.NetworkBus.Messages
{
    public sealed class SocketDataToBusMessage : BinaryMessage
    {
        public override string Name => "services.socket.data.tobus";
    }
    public sealed class SocketDataToProxyMessage : BinaryMessage
    {
        public override string Name => "services.socket.data.toproxy";
    }
}