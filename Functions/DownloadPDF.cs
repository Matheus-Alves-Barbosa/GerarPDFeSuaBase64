using Microsoft.Azure.Functions.Worker;
using System;
using System.Collections.Generic;
using System.IO;

namespace GerarPDF
{
    public static class DownloadPDF
    {
        [Function("DownloadPDF")]

        public static List<byte[]> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "DownloadPDF/{qtd}")] FunctionContext context, int qtd)
        {
            List<byte[]> lbyte = new List<byte[]>();
            for (int i = 1; i <= qtd; i++)
            {
            lbyte.Add(GerarPDF.GeraPDF());
                string finalPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                System.IO.File.Copy("ArquivoTeste-" + Guid.NewGuid().ToString() + ".pdf", finalPath);
            }
            return lbyte;
        }
    }
}
