using System;
using System.Linq;

using System.Reactive.Linq;
using System.Reactive.Subjects;

using BitShifter.ReativeBus.Abstractions;

namespace BitShifter.ReativeBus.Inrastructure
{
    public class EventBus : IEventBus
    {
        private readonly Subject<IEvent> _queue = new Subject<IEvent>();

        public void Publish<TEvent>(TEvent @event)
            where TEvent : class, IEvent
                => _queue.OnNext(@event);

        public IDisposable Subscribe<TEvent>(IEventHandler<TEvent> observer)
            where TEvent : class, IEvent
                => _queue
                    .OfType<TEvent>()
                    .Subscribe(observer);
    }
}
