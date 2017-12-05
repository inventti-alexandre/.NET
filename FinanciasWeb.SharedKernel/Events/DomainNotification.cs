using FinanciasWeb.SharedKernel.Events.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.SharedKernel.Events
{
    public class DomainNotification : IDomainEvents
    {
        public DomainNotification(string Key, string value)
        {
            this.Key = Key;
            this.Value = value;
            this.DateOccurred = DateTime.Now;
        }

        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime DateOccurred { get; set; }

    }
}
