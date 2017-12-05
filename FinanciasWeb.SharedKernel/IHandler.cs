using FinanciasWeb.SharedKernel.Events.Contracts;
using System;
using System.Collections.Generic;

namespace FinanciasWeb.SharedKernel
{
    public interface IHandler <T> :IDisposable where T : IDomainEvents
    {
        void Handler(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}
