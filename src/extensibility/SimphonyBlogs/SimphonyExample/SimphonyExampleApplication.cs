using Micros.Ops;
using Micros.Ops.Extensibility;
using Micros.PosCore.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimphonyExample
{
    /// <summary>
    /// Implements the extension application
    /// </summary>
    public partial class SimphonyExampleApplication : OpsExtensibilityApplication
    {
        public SimphonyExampleApplication(IExecutionContext context) : base(context)
        {
           
        }
    }
}
