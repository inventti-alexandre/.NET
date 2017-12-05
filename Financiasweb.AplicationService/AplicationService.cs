using FinanciasWeb.Infra.Persistence;
using FinanciasWeb.SharedKernel;
using FinanciasWeb.SharedKernel.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.AplicationService
{
    public class AplicationService
    {
        private IUnitOfWork _unitofwork;
        private IHandler<DomainNotification> _notifications;

        public AplicationService(IUnitOfWork iunitofwork)
        {
            _unitofwork = iunitofwork;
            _notifications = DomainEvents.Container.GetService<IHandler < DomainNotification >> ();
        }
        public bool Commit()
        {
            if (_notifications.HasNotifications())
                 return false;

            _unitofwork.Commit();
            return true;
        }
    }
}
