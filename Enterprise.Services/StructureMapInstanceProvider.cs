using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Services
{
    /// <summary>
    ///     StructureMapInstanceProvider
    /// </summary>
    public class StructureMapInstanceProvider : IInstanceProvider
    {
        private readonly Type _serviceType;

        /// <summary>
        ///     Initializes a new instance of the <see cref="StructureMapInstanceProvider" /> class.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        public StructureMapInstanceProvider(Type serviceType)
        {
            _serviceType = serviceType;
        }

        /// <summary>
        ///     Returns a service object given the specified <see cref="T:System.ServiceModel.InstanceContext" /> object.
        /// </summary>
        /// <param name="instanceContext">The current <see cref="T:System.ServiceModel.InstanceContext" /> object.</param>
        /// <returns>
        ///     A user-defined service object.
        /// </returns>
        public object GetInstance(InstanceContext instanceContext)
        {
            return GetInstance(instanceContext, null);
        }

        /// <summary>
        ///     Returns a service object given the specified <see cref="T:System.ServiceModel.InstanceContext" /> object.
        /// </summary>
        /// <param name="instanceContext">The current <see cref="T:System.ServiceModel.InstanceContext" /> object.</param>
        /// <param name="message">The message that triggered the creation of a service object.</param>
        /// <returns>
        ///     The service object.
        /// </returns>
        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            return ObjectFactory.GetInstance(_serviceType);
        }

        /// <summary>
        ///     Called when an <see cref="T:System.ServiceModel.InstanceContext" /> object recycles a service object.
        /// </summary>
        /// <param name="instanceContext">The service's instance context.</param>
        /// <param name="instance">The service object to be recycled.</param>
        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {
        }
    }
}
