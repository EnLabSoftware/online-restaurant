using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Logic.Exceptions
{
    /// <summary>
    /// 
    /// </summary>
    public class EnterpriseException: Exception, IEnterpriseException
    {
        /// <summary>
        /// Gets the error code.
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        public virtual string ErrorCode { get; private set; }

        /// <summary>
        /// Gets a message that describes the current exception.
        /// </summary>
        /// <returns>The error message that explains the reason for the exception, or an empty string("").</returns>
        public virtual new string Message { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseException"/> class.
        /// </summary>
        public EnterpriseException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public EnterpriseException(string message)
        {
            Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseException"/> class.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="message">The message.</param>
        public EnterpriseException(string errorCode, string message)
        {
            ErrorCode = errorCode;
            Message = message;
        }

    }
}
