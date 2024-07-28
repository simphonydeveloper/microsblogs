using Micros.PosCore.Extensibility;
using Spire.Pdf.Graphics;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net.Mail;
using System.Net;

namespace SimphonyExample
{
    public partial class SimphonyExampleApplication
    {
        [ExtensibilityMethod]
        public void Part30Test1()
        {
            Logger.LogAlways("Part30Test1");
            CreatePdf(AppContext.BaseDirectory + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf");
            this.OpsContext.ShowMessage("pdf");
        }


        private void CreatePdf(string path)
        {
            PdfDocument doc = new PdfDocument();
            //get pdf height by checkmenuitem count
            int existsMenuitems = this.OpsContext.CheckDetail.Where(w => w.Void == false).Count();

            float height = existsMenuitems * 30;
            Logger.LogAlways("get height" + height);
            PdfPageBase page = doc.Pages.Add(new SizeF(315, height + 300));
            //PdfPageSize

            PdfSolidBrush paraBrush = new PdfSolidBrush(new PdfRGBColor(System.Drawing.Color.Black));
            PdfTrueTypeFont paraFont = new PdfTrueTypeFont(new System.Drawing.Font("宋体", 12f, FontStyle.Regular), true);

            string checkstring = this.OpsContext.GetGuestCheckImage();
            PdfStringFormat format2 = new PdfStringFormat();
            format2.Alignment = PdfTextAlignment.Left;
            page.Canvas.DrawString(checkstring, paraFont, paraBrush, 0, 0, format2);

            //Save pdf file.
            doc.SaveToFile(path);
            doc.Close();
        }
    }
}
