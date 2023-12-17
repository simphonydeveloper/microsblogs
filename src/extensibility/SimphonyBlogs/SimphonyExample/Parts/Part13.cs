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
        public void Part13Test1()
        {
            Logger.LogAlways("Part13Test1");
        }

        private byte[] Barcode()
        {
            string barcode = OpsContext.Check.CheckNumber.ToString("000000");
            byte[] barcodeBytes = Encoding.ASCII.GetBytes(barcode);
            byte[] command = new byte[] { 10, 10, 10, 29, 102, 1, 29, 104, 75, 27, 97, 1, 29, 72, 2, 29, 107, 69, 6 };
            byte[] trails = new byte[] { 27, 97, 48 };
            byte[] data = new byte[command.Length + barcodeBytes.Length + trails.Length];
            command.CopyTo(data, 0);
            barcodeBytes.CopyTo(data, command.Length);
            trails.CopyTo(data, command.Length + barcodeBytes.Length);

            return data;
        }
    }
}
