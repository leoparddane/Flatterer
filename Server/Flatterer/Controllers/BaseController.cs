using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Flatterer.Controllers
{
    [Route("Flatterer/[controller][action]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected int UserID { get; set; }
    }
}