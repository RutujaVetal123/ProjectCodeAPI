using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCode.Models;
using ProjectCode.Services;

namespace ProjectCode.Controllers
{
    public class CodeController : Controller
    {
        private CodeService _codeServices;
        public CodeController(CodeService code)
        {
            _codeServices = code;
        }
        [HttpPost("SaveCodeDetails")]
        public IActionResult SaveCodeDetails(CodeDetails code)
        {
            return Ok(_codeServices.SaveCodeDetails(code));
        }

        [HttpDelete("DeleteCodeDetails")]
        public IActionResult DeleteCodeDetails(int CodeID)
        {
            return Ok(_codeServices.DeleteCodeDetails(CodeID));
        }

        [HttpPut("UpdateCodeDetails")]
        public IActionResult UpdateCodeDetails(CodeDetails code)
        {
            return Ok(_codeServices.UpdateCodeDetails(code));
        }

        [HttpGet("GetCodeDetailsByID")]
        public IActionResult GetProduct(int CodeID)
        {
            return Ok(_codeServices.GetCodeDetailsByID(CodeID));
        }

        [HttpGet("GetAllCodeDetails()")]
        public List<CodeDetails> GetAllCodeDetails()
        {
            return _codeServices.GetAllCodeDetails();
        }
    }
}
