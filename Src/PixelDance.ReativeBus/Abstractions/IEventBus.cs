using System;

namespace PixelDance.ReativeBus.Abstractions
{
    public interface IEventBus
    {
        void Publish<TEvent>(TEvent @event)
            where TEvent : class, IEvent;
        IDisposable Subscribe<TEvent>(IEventHandler<TEvent> observer)
            where TEvent : class, IEvent;
    }
}
