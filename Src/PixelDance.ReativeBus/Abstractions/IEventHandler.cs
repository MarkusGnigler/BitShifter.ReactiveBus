using System;

namespace PixelDance.ReativeBus.Abstractions
{
    public interface IEventHandler<TEvent> : IObserver<TEvent>
        where TEvent : IEvent
    {
        new void OnNext(TEvent @event);
    }
}
