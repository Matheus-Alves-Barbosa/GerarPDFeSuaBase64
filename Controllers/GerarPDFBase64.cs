using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GerarPDFeBase64.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerarPDFBase64Controller : ControllerBase
    {
        [HttpGet("{qtd}")]
        public List<string> GeraPDFBase64(int qtd)
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