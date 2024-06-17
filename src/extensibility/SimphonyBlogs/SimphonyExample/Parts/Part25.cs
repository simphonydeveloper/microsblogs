using Micros.PosCore.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimphonyExample
{
    public partial class SimphonyExampleApplication
    {
        [ExtensibilityMethod]
        public void Part25Test1()
        {
            Logger.LogAlways("Part25Test1");

            SimphonyLogHelper.LogAlways("SimphonyLogHelper");
        }

    }



    internal class SimphonyLogHelper
    {
        public static void LogAlways(string message)
        {
            ExtensibilityAppLogger.CurrentInstance.LogAlways(message);
        }
    }
}
