using Dependency_Injection_Code.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection_Code
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IProducts IProducts;
        public ValuesController(IProducts IProducts)
        {
            this.IProducts = IProducts;
        }
        public IActionResult GetProducct()
        {
            return Ok(IProducts.List());
        }
    }
}
