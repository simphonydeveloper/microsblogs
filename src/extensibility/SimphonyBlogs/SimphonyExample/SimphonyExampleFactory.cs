using Micros.PosCore.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimphonyExample
{

    /// <summary>
    ///  Implements interface used by Simphony POS Client to create an instance of the extension application
    ///  https://docs.oracle.com/cd/E91245_01/api/html/7fc2e419-231a-4c4c-9b62-b86f701a9a8b.htm
    /// </summary>
    public class SimphonyExampleFactory: IExtensibilityAssemblyFactory
    {
        public ExtensibilityAssemblyBase Create(IExecutionContext context)
    {
        return new SimphonyExampleApplication(context);
    }

    public void Destroy(ExtensibilityAssemblyBase app)
    {
        app.Destroy();
    }
}
}
