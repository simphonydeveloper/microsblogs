using Micros.Ops;
using Micros.PosCore.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimphonyExample
{
    partial class SimphonyExampleApplication
    {
        [ExtensibilityMethod]
        public void Part21Test1()
        {

            Logger.LogAlways("Par21Test1");
            GlobalApplicationCache.Add("flag", false);
        }

        /// <summary>
        /// the method in other dll
        /// </summary>
        [ExtensibilityMethod]
        public void Part21Test2()
        {

            Logger.LogAlways("Par21Test2");
            var flag = GlobalApplicationCache.ContainsKey("flag");
            if (flag)
            {
                this.OpsContext.ShowMessage("get flag");

                var flagValue = GlobalApplicationCache["flag"];
                if (Convert.ToBoolean(flagValue))
                {
                    this.OpsContext.ShowMessage("get flag true");
                }
                else
                {
                    this.OpsContext.ShowMessage("get flag false");
                }
            }
            else
            {
                this.OpsContext.ShowMessage("no flag");
            }
        }
    }
}
