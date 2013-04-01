﻿using System;
using DomainEventExtensions;
using TestApp.Events;

namespace TestApp.Handlers
{
    public class SomeDomainEventHandler : IHandleDomainEvent<SomeDomainEvent>
    {
        public void Handle(SomeDomainEvent domainEvent)
        {
            Console.WriteLine(domainEvent.Text);
        }
    }
}