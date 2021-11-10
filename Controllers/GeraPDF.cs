using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.IO;

namespace GerarPDFeBase64.Controllers
{
    public static class GerarPDF
    {
        public static byte[] GeraPDF()
        {
            MemoryStream ms = new MemoryStream();
            PdfWriter pw = new PdfWriter(ms);
            PdfDocument pdf = new PdfDocument(pw);
            Document doc = new Document(pdf, PageSize.A4);
            doc.Add(new Paragraph("PDF GERADO PARA TESTE").SetFontSize(30).SetBold().SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
            doc.Add(new Paragraph("PDF GERADO EM " + (DateTime.Now.AddHours(9)).ToString("dd-MM-yyyy hh:mm:ss")).SetFontSize(15).SetBold().SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
            doc.Add(new Paragraph("GUID GERADO PARA ESTE PDF " + Guid.NewGuid().ToString()).SetFontSize(15).SetBold().SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
            doc.Close();
            return ms.ToArray();
        }
    }
}
