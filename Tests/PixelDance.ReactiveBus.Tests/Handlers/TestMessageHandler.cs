using System;

using PixelDance.ReativeBus.Abstractions;

namespace PixelDance.ReactiveBus.Tests.Handlers
{
    internal class TestMessageHandler : IEventHandler<TestMessage>
    {
        public bool OnCompletedCalled { get; private set; }
        public bool OnErrorCalled { get; private set; }
        public bool OnNextCalled { get; private set; }
        public TestMessage Message { get; private set; }

        public void OnCompleted()
        {
            OnNextCalled = true;
        }

        public void OnError(Exception error)
        {
            OnNextCalled = true;
        }

        public void OnNext(TestMessage @event)
        {
            OnNextCalled = true;
            Message = @event;
        }
    }
}
