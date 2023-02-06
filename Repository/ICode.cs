using ProjectCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCode.Repository
{
    public interface ICode
    {
        public string SaveCodeDetails(CodeDetails codeDetails);
        public string UpdateCodeDetails(CodeDetails codeDetails);
        public string DeleteCodeDetails(int codeID);
        List<CodeDetails> GetAllCodeDetails();
        CodeDetails GetCodeDetailsByID(int codeID);
    }
}
