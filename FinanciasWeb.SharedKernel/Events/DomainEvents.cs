using FinanciasWeb.SharedKernel.Events.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.SharedKernel.Events
{
    public static class DomainEvents
    {
        public static IContainer Container { get; set; }

        public static void Raise<T>(T args) where T : IDomainEvents
        {
            try
            {
                if(Container != null)
                {
                    var obj = Container.GetService(typeof(IHandler<T>));
                    ((IHandler<T>)obj).Handler(args);
                }
            }
            catch
            {

            }

        } 
    }
}
