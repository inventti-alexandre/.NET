using FinanciasWeb.SharedKernel;
using FinanciasWeb.SharedKernel.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.CrossCutting
{
    public class DomainNotificationHandler : IHandler<DomainNotification>
    {
        private List<DomainNotification> _notification;

        public DomainNotificationHandler()
        {
            _notification = new List<DomainNotification>();
        }

        public void Handler(DomainNotification args)
        {
            _notification.Add(args);
        }
        public List<DomainNotification> GetValue()
        {
            return _notification;

        }

        public bool HasNotifications()
        {
            return GetValue().Count > 0;
        }

        public void Dispose()
        {
            this._notification = new List<DomainNotification>();
        }

        public IEnumerable<DomainNotification> Notify()
        {
            return GetValue();
        }
    }
}
