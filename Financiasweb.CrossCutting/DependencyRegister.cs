using FinanciasWeb.Domain.Repositories;
using FinanciasWeb.Domain.Service;
using FinanciasWeb.Infra;
using FinanciasWeb.Infra.Persistence;
using FinanciasWeb.Infra.Persistence.DataContexts;
using FinanciasWeb.Infra.Repositories;
using FinanciasWeb.SharedKernel;
using FinanciasWeb.AplicationService.ServicesClass;
using FinanciasWeb.SharedKernel.Events;
using Unity;
using Unity.Lifetime;

namespace FinanciasWeb.CrossCutting
{
    public static class DependencyRegister
    {
        /// <summary>
        /// HierarchicalLifetimeManager -- Utiliza Singleton (Utiliza a mesma classe da memoria não estancia uma nova)
        /// TransientLifetimeManager -- Cada Resolve uma nova instancia 
        /// </summary>
        /// <param name="container"></param>
        /// 

        public static void Register(UnityContainer container)
        {
            container.RegisterType< StoreDataContext, StoreDataContext >(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<ICategoryRepository, CategoryRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IProductRepository, ProductRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<ICategoryAplicationService, CategoryAplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserAplicationService, UserAplicationService>(new HierarchicalLifetimeManager());
            //container.RegisterType<IProductAplicationService, ProductAplicationService>(new HierarchicalLifetimeManager());

            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());
        }
    }
}
