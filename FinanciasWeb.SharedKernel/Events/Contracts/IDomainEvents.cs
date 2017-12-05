using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.SharedKernel.Events.Contracts
{
    public interface IDomainEvents
    {
        DateTime DateOccurred { get; }
    }
}
