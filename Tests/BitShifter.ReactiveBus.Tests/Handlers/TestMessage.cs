using System;

using BitShifter.ReativeBus.Abstractions;

namespace BitShifter.ReactiveBus.Tests.Handlers
{
    internal class TestMessage : IEvent
    {
        public string Notification { get; }

        public TestMessage(string notification)
        {
            Notification = notification ?? throw new ArgumentNullException("Notification can't be null."); ;
        }
    }
}
