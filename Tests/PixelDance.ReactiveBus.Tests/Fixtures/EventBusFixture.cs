using System.Threading.Tasks;

using Xunit;

using PixelDance.ReativeBus.Abstractions;
using PixelDance.ReativeBus.Inrastructure;

namespace PixelDance.ReactiveBus.Tests.Fixtures
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
