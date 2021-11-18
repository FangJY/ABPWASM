using ABPWASM.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPWASM.Controllers
{
    public class MESController : ABPWASMController
    {
        public MESController()
        {
            LocalizationResource = typeof(ABPWASMResource);
        }

        [HttpGet]
        public string add(string dd)
        {
            return dd;
        }

        [HttpGet, Route("api/MES/delete")]
        public string delete(string dd)
        {
            return dd;
        }
    }

}
