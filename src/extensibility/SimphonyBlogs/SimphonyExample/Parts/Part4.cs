using Micros.PosCore.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimphonyExample
{
    /// <summary>
    /// Part4
    /// </summary>
    public partial class SimphonyExampleApplication
    {

        [ExtensibilityMethod]
        public void Part4Test1()
        {
            Logger.LogAlways("Part4Test1");

            string contentName = "MyCustomDialogControl";

            Part4Model part4Model = new Part4Model();
            var dialogResult = this.OpsContext.RequestCustomDialog("test message", "test title", contentName, part4Model);

            //the dialogResult data type is Part4Model

            if (dialogResult == null)
                return;
            else
            {
                var result = dialogResult as Part4Model;
                this.OpsContext.ShowMessage(result.UserName);
            }
        }
    }


    public class Part4Model
    {
        public string UserName { get; set; }
    }
}
