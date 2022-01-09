﻿using Xunit;
using FluentAssertions;

using PixelDance.ReactiveBus.Tests.Fixtures;
using PixelDance.ReactiveBus.Tests.Handlers;

namespace PixelDance.ReactiveBus.Tests
{
    public class EventBusTests : TestBase
    {
        public EventBusTests(EventBusFixture fixture) 
            : base(fixture)
        { }

        [Fact]
        public void EventBus_Propagated_Message()
        {
            // Arrange
            var message = new TestMessage("test-message");

            // Act
            _fixture.EventBus.Publish(message);

            // Assert
            _sut.OnNextCalled.Should()
                .BeTrue();
        }

        [Fact]
        public void EventBus_Propagated_MessageWithText()
        {
            // Arrange
            string expectedMessage = "test-message";
            var message = new TestMessage(expectedMessage);

            // Act
            _fixture.EventBus.Publish(message);

            // Assert
            _sut.Message.Notification.Should()
                .Be(expectedMessage);
        }
    }
}
