using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Services
{
    /// <summary>
    ///     StructureMapServiceHost
    /// </summary>
    public class StructureMapServiceHost : ServiceHost
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="StructureMapServiceHost" /> class.
        /// </summary>
        /// <param name="serviceType">The type of hosted service.</param>
        /// <param name="baseAddresses">
        ///     An array of type <see cref="T:System.Uri" /> that contains the base addresses for the
        ///     hosted service.
        /// </param>
        public StructureMapServiceHost(Type serviceType, params Uri[] baseAddresses)
            : base(serviceType, baseAddresses)
        {
        }

        /// <summary>
        ///     Invoked during the transition of a communication object into the opening state.
        /// </summary>
        protected override void OnOpening()
        {
            Description.Behaviors.Add(new StructureMapServiceBehavior());
            base.OnOpening();
        }
    }
}
