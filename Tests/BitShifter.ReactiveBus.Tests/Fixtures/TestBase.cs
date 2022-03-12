using System;

using Xunit;

using BitShifter.ReactiveBus.Tests.Handlers;

namespace BitShifter.ReactiveBus.Tests.Fixtures
{
    public abstract class TestBase : IClassFixture<EventBusFixture>, IDisposable
    {
        protected IDisposable _subscription;
        internal TestMessageHandler _sut;

        protected readonly EventBusFixture _fixture;

        public TestBase(EventBusFixture fixture)
        {
            _fixture = fixture;
            _sut = new TestMessageHandler();
            _subscription = _fixture.EventBus.Subscribe(_sut);
        }

        public void Dispose()
        {
            _subscription.Dispose();
        }

    }
}
