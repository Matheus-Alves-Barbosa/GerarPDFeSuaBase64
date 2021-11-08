using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GerarPDF
{
    public static class DownloadPDF
    {
        [Function("DownloadPDF")]

        public static byte[] Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "DownloadPDF")] FunctionContext context)
        {
            return GerarPDF.GeraPDF();            
        }
    }
}
