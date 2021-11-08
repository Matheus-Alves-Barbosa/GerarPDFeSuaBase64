using Microsoft.Azure.Functions.Worker;
using System;
using System.Collections.Generic;

namespace GerarPDF
{
    public static class GerarPDFBase64
    {
        [Function("GerarPDFBase64")]
        public static List<string> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "PDFBase64/{qtd}")] FunctionContext context, int qtd)
        {
            List<string> lbase64 = new List<string>();
            for (int i = 1; i <= qtd; i++)
            {
                lbase64.Add(Convert.ToBase64String(GerarPDF.GeraPDF()));
            }
            return lbase64;
        }
    }
}
