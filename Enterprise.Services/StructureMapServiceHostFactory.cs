using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using Enterprise.Logic.Repositories;
using Enterprise.Repository.Repositories;

namespace Enterprise.Services
{
    /// <summary>
    ///     StructureMapServiceHostFactory
    /// </summary>
    public class StructureMapServiceHostFactory : ServiceHostFactory
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="StructureMapServiceHostFactory" /> class.
        /// </summary>
        public StructureMapServiceHostFactory()
        {
            ObjectFactory.Configure(x => x.Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
               
            }));
            ObjectFactory.Initialize(x =>
            {
                //x.For<Logic.Services.IOrderService>().Use<Application.Services.OrderService>();
                //x.For<IOrderRepository>().Use<OrderRepository>();
                x.For<IMenuRepository>().Use<MenuRepository>();
                x.For<Logic.Services.IMenuService>().Use<Application.Services.MenuService>();
                x.For<IMenuItemRepository>().Use<MenuItemRepository>();
                x.For<IRestaurantRepository>().Use<RestaurantRepository>();
                x.For<Logic.Services.IRestaurantService>().Use<Application.Services.RestaurantService>();
                x.For<IRestaurantCategoryRepository>().Use<RestaurantCategoryRepository>();
                x.For<Logic.Services.ICustomerService>().Use<Application.Services.CustomerService>();
                x.For<ICustomerRepository>().Use<CustomerRepository>();
                x.For<ICartRepository>().Use<CartRepository>();
                x.For<IOrderRepository>().Use<OrderRepository>();
                x.For<IOrderDetailsRepository>().Use<OrderDetailsRepository>();
                x.For<Logic.Services.ICartService>().Use<Application.Services.CartService>();
                x.For<IOrderStatusRepository>().Use<OrderStatusRepository>();
            });
        }

        /// <summary>
        ///     Creates a <see cref="T:System.ServiceModel.ServiceHost" /> for a specified type of service with a specific base
        ///     address.
        /// </summary>
        /// <param name="serviceType">Specifies the type of service to host.</param>
        /// <param name="baseAddresses">
        ///     The <see cref="T:System.Array" /> of type <see cref="T:System.Uri" /> that contains the
        ///     base addresses for the service hosted.
        /// </param>
        /// <returns>
        ///     A <see cref="T:System.ServiceModel.ServiceHost" /> for the type of service specified with a specific base address.
        /// </returns>
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return new StructureMapServiceHost(serviceType, baseAddresses);
        }
    }
}
