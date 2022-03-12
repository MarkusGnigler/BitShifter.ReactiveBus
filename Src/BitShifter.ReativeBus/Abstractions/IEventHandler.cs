using System;

namespace BitShifter.ReativeBus.Abstractions
{
    public interface IEventHandler<TEvent> : IObserver<TEvent>
        where TEvent : IEvent
    {
        new void OnNext(TEvent @event);
    }
}
