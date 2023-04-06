using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GerarPDFeBase64.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerarPDFBase64Controller : ControllerBase
    {
        [HttpGet]
        public List<string> GeraPDFBase64()
        {
            List<string> lbase64 = new()
            {
                Convert.ToBase64String(GerarPDF.GeraPDF())
            };

            return lbase64;
        }
    }
}