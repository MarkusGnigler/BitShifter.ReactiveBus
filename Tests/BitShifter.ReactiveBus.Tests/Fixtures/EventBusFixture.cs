using System.Threading.Tasks;

using Xunit;

using BitShifter.ReativeBus.Abstractions;
using BitShifter.ReativeBus.Inrastructure;

namespace BitShifter.ReactiveBus.Tests.Fixtures
{
    public class EventBusFixture : IAsyncLifetime
    {
        internal IEventBus EventBus { get; private set; }

        public Task InitializeAsync()
        {
            EventBus = new EventBus();

            return Task.CompletedTask;
        }

        public Task DisposeAsync()
        {
            return Task.CompletedTask;
        }
    }
}
