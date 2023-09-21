using Micros.PosCore.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimphonyExample
{
    /// <summary>
    /// part3 and part4
    /// </summary>
    public partial class SimphonyExampleApplication
    {
        [ExtensibilityMethod]
        public void Part3Test1()
        {
            Logger.LogAlways("Part3Test1");

            string contentName = "MyCustomDialogControl";
            this.OpsContext.RequestCustomDialog("test message", "test title", contentName, null);
        }


      
    }
}
