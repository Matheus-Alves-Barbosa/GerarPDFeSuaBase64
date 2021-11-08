using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
