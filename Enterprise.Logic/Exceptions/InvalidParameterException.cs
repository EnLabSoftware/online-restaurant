using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Logic.Exceptions
{
    public class InvalidParameterException: EnterpriseException 
    {
        public InvalidParameterException(string parameterName) 
            : base(parameterName)
        {
        }
    }
}
