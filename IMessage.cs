using System;

namespace Aragas.QServer.NetworkBus
{
    public interface IMessage
    {
        string Name { get; }

        ReadOnlySpan<byte> GetData();
        void SetData(in ReadOnlySpan<byte> data);
    }

    //public interface IMessageRequest : IMessage { }
    //public interface IMessageResponse : IMessage { }

    public interface IEnumerableMessage : IMessage
    {
        bool IsLastMessage { get; }
    }
}