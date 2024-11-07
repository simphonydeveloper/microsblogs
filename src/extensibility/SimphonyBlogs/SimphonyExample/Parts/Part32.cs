using Micros.PosCore.Extensibility;
using SimphonyExample.ViewModels;
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
        public void Part32Test1()
        {
            Logger.LogAlways("Part32Test1");
            this.OpsContext.RequestCustomDialog("SampleForm", "SampleForm", "SampleForm", null);
        }
    }
}
