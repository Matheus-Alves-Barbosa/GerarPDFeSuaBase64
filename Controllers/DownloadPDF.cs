using Microsoft.AspNetCore.Mvc;
using System;

namespace GerarPDFeBase64.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DownloadPDFController : ControllerBase
    {
        [HttpGet]
        public IActionResult DonwloadPDF ()
        {
            return File(GerarPDF.GeraPDF(), System.Net.Mime.MediaTypeNames.Application.Octet, "arquivoTeste-" + Guid.NewGuid().ToString() + ".pdf");
        }
    }
}
