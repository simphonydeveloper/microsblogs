using Micros.Ops;
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
        public void Part14Test1()
        {
            Logger.LogAlways("Part14Test1-HTML5");

            var parms = new Micros.PosCore.Extensibility.UserInterface.ExtensibilityInPlaceHtmlDialogParameters();

            //i don't know why this method will get an error in 19.5，so i use other method to do.
            //string html = DataStore.ReadExtensionApplicationContentTextByNameKey(OpsContext.RvcID, ApplicationName, "EchartsHtml");
            Logger.LogAlways("get html");
            var extcontent = DataStore.ReadExtensionApplicationContentByKey(OpsContext.RvcID, "EchartsHtml");
            var html = Encoding.Unicode.GetString(extcontent.ContentData.DataBlob);
            Logger.LogAlways(html);
            parms.HTML = html;
            parms.ShowCloseButton = true;
            parms.DebugMode = false;

            // show dialog and get back result
            string result = OpsContext.ShowExtensibilityHtmlDialog(parms);
        }
    }
}
